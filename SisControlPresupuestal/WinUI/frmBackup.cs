using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
namespace WinUI
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

      

        private void btnExec_Click(object sender, EventArgs e)
        {
        
            if (!string.IsNullOrEmpty(this.txtpath.Text.Trim()))
            {
                if (new Backup_BUS().BackupGenerate(this.txtpath.Text.Trim()))
                {
                    //activate controls
                    MessageBox.Show("ok");
                }
            }
        }

        

        private void btnadd_Click(object sender, EventArgs e)
        {
            try {
                FolderBrowserDialog fdialog = new FolderBrowserDialog
                {
                    RootFolder = Environment.SpecialFolder.MyComputer,
                    ShowNewFolderButton = false
                };
                if (fdialog.ShowDialog() == DialogResult.OK)
                {
                    string spath = fdialog.SelectedPath;
                    this.txtpath.Text = Path.Combine(spath, "Data_" + DateTime.Today.ToString("ddMMyyyy") + ".bak");
                }
                }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
