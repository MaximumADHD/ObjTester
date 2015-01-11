using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ObjTester
{
    public partial class Input : Form
    {
        int condition = 0;
        public Input()
        {
            InitializeComponent();
        }

        public void error(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void onClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        public void showResults(object sender, EventArgs e)
        {
            Results results = null;
            if (condition != 3)
            {
                int test = 0;
                Int32.TryParse(inputBox.Text, out test);
                if (test != 0)
                {
                    results = new Results(test, condition);
                }
                else
                {
                    error("Invalid input");
                    inputBox.Clear();
                }
            }
            else
            {
                results = new Results(inputBox.Text, 3);
            }
            try
            {
                this.Enabled = false;
                results.Show();
                results.FormClosed += new FormClosedEventHandler(onClosed);
            }
            catch
            {
                this.Enabled = true;
            }
        }

        private void methodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            condition = methodSelect.SelectedIndex + 1;
            this.inputBox.Clear();
            this.inputBox.Enabled = true;
            this.go.Enabled = true;
        }
    }
}
