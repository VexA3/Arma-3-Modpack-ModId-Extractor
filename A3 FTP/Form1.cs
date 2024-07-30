using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = "Select Modpack file";
        }

        private void btn_modpack_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBox_Modpack.Text = openFileDialog1.FileName;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new StreamReader(txtBox_Modpack.Text);

                string line;
                string modIds = "";
                string searchString = "steamcommunity.com/sharedfiles/filedetails/?id=";
                string endSearchString = "\" data-type";
                while ((line = sr.ReadLine()) != null)
                {
                    int index = line.IndexOf(searchString);
                    int length = line.IndexOf(endSearchString);
                    if (index > 0)
                    {
                        modIds += line.Substring((index + searchString.Length), (length - (index + searchString.Length))) + ",";
                    }
                }

                modIds = modIds.TrimEnd(',');

                Clipboard.SetText(modIds);

                MessageBox.Show("The following Ids where copied to clipboard: \n" + modIds);

            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
