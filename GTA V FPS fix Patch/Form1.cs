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

namespace GTA_V_FPS_fix_Patch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string orgFile = "settings.xml";
                string repFile = GTA_V_FPS_fix_Patch.Resource1.settings;
                orgFile = System.IO.Path.Combine(path, orgFile);
                //File.SetAttributes(orgFile, FileAttributes.Normal);
                //File.Delete(orgFile);
               
                bool a = Uri.IsWellFormedUriString(repFile, UriKind.RelativeOrAbsolute);
                if(a == false)
                {
                    MessageBox.Show("No");
                }
                File.Copy(repFile, orgFile, true);
            }
            catch (Exception k)
            {
                MessageBox.Show(k.ToString());
            }
        }
    }
}
