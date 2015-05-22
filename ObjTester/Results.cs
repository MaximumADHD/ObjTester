using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json;

namespace ObjTester
{

    public partial class Results : Form
    {
        WebClient http = new WebClient();
        public NameValueCollection JsonToNVC(string json)
        {
            ListDictionary parse = JsonConvert.DeserializeObject<ListDictionary>(json);
            NameValueCollection nvc = new NameValueCollection();
            foreach (DictionaryEntry pair in parse)
            {
                if (pair.Value != null)
                {
                    nvc.Add(pair.Key.ToString(), pair.Value.ToString());
                }
            }
            return nvc;
        }

        bool logging = false;

        private void log(params string[] logTxts)
        {
            logging = true;
            foreach (string logTxt in logTxts)
            {
                if (logTxt != null)
                {
                    resultsList.Items.Add(logTxt);
                    resultsList.SelectedIndex = resultsList.Items.Count - 1;
                }
            }
            logging = false;
        }

        bool errored = false;

        public void error(string msg)
        {
            if (!errored)
            {
                errored = true;
                this.Enabled = false;
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public string resolveHash(string hash)
        {
            try
            {
                string json = http.DownloadString("http://www.roblox.com/thumbnail/resolve-hash/" + hash);
                NameValueCollection data = JsonToNVC(json);
                return data["Url"];
            }
            catch
            {
                error("Couldn't Resolve Hash: " + hash);
                return "";
            }
        }
        public Results(Object id, int condition)
        {
            InitializeComponent();
            string url = "";
            if (condition == 1)
            {
                url = "http://www.roblox.com/asset-thumbnail-3d/json?assetId=" + id.ToString();
            }
            else if (condition == 2)
            {
                url = "http://www.roblox.com/avatar-thumbnail-3d/json?userId=" + id.ToString();
            }
            else if (condition == 3)
            {
                try
                {
                    string json = http.DownloadString("http://api.roblox.com/users/get-by-username?username=" + id);
                    if (json.Contains("errorMessage"))
                    {
                        error("User not found");
                    }
                    else
                    {
                        NameValueCollection data = JsonToNVC(json);
                        string userId = data["Id"];
                        url = "http://www.roblox.com/avatar-thumbnail-3d/json?userId=" + userId;
                    }
                }
                catch
                {
                    error("Could not load user information.");
                }
            }
            try
            {
                string json = http.DownloadString(url);
                if (json.Contains("null"))
                {
                    throw new Exception();
                }
                NameValueCollection data = JsonToNVC(json);
                string dataUrl = data["Url"];
                log("DATA URL:", dataUrl);
                try
                {
                    string objDataJson = http.DownloadString(dataUrl);
                    NameValueCollection objData = JsonToNVC(objDataJson);
                    string obj = resolveHash(objData["obj"]);
                    string mtl = resolveHash(objData["mtl"]);
                    string[] textures = JsonConvert.DeserializeObject<string[]>(objData["textures"]);
                    log("OBJ FILE:", obj);
                    log("MTL FILE:", mtl);
                    if (textures.Length > 0)
                    {
                        log("TEXTURE FILES:");
                        foreach (string hash in textures)
                        {
                            log(resolveHash(hash));
                        }
                    }
                    else
                    {
                        log("NO TEXTURE FILES FOUND.");
                    }
                }
                catch
                {
                    error("Could not load obj data");
                }
            }
            catch
            {
                error("Could not get obj data url");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkUrl(string selected)
        {
            try
            {
                http.DownloadString(selected);
                this.openUrl.Enabled = true;
            }
            catch
            {
                this.openUrl.Enabled = false;
            }
            return this.openUrl.Enabled;
        }

        string currentSelection = "";

        private void resultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!logging)
            {
                string selected = resultsList.SelectedItem.ToString();
                bool isUrl = checkUrl(selected);
                if (currentSelection == selected && isUrl)
                {
                    logging = true;
                    resultsList.SelectedIndex = -1;
                    Process.Start(currentSelection);
                    currentSelection = "";
                    logging = false;
                }
                else
                {
                    currentSelection = selected;
                }

            }
            else
            {
                resultsList.SelectedIndex = 0;
            }
        }

        private void openUrl_Click(object sender, EventArgs e)
        {
            Process.Start(resultsList.SelectedItem.ToString());
        }
    }
}
