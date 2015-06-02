using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Configuration;

namespace LiteMate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }        


        private void Main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            foreach (Environment.SpecialFolder hs1 in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                Debug.WriteLine(hs1, Environment.GetFolderPath(hs1));
            }


            var configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "LiteMate");

            if ( !Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }

            _configFile = new IniFile(configPath + "\\config.ini");

            RefreshNames();

            LoadConfig();
        }

        string _fileName;
        IniFile _configFile;
        void LoadConfig( )
        {
            var dir = Directory.GetCurrentDirectory();
            _fileName = _configFile.ReadValue("Settings","LiteIDEFileName");
        }

        void SaveConfig( )
        {
            _configFile.WriteValue("Settings", "LiteIDEFileName", _fileName);
        }

        void RefreshNames( )
        {
            var configpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "liteide");

            if (!Directory.Exists(configpath))
            {                
                return;
            }

            var files = Directory.GetFiles(configpath);

            lstMain.Items.Clear();

            foreach (var file in files)
            {
                var filename = Path.GetFileNameWithoutExtension(file);

                lstMain.Items.Add(filename);
            }
        }

        string GetFullPathName( string name )
        {
            var configpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "liteide");

            return string.Format( "{0}\\{1}.ini", configpath , name);
        }

        bool Rename( string oldName, string newName )
        {
            try
            {
                File.Move(GetFullPathName(oldName), GetFullPathName(newName));
            }
            catch( Exception )
            {
                return false;
            }

            return true;
        }

        bool Clone(string oldName, string newName)
        {
            try
            {
                File.Copy(GetFullPathName(oldName), GetFullPathName(newName), true);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }

            return true;
        }

        bool Delete(string name)
        {
            try
            {
                File.Delete(GetFullPathName(name));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        string GetSelectedName()
        {
            return (string)lstMain.SelectedItem;
        }


        private void lstMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartWithConfig();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartWithConfig();
        }


        void SetAppFileName( )
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "exe files (*.exe)|*.exe|bat files(*.bat)|*.bat";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }

            _fileName = dialog.FileName;
            SaveConfig();
        }

        void StartWithConfig(  )
        {
            if (!File.Exists(_fileName))
            {
                SetAppFileName();
            }

            var selectedName = GetSelectedName();
            if (selectedName == "")
                return;

            Clone(selectedName, "liteide");

            Process.Start(_fileName);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedName = GetSelectedName();
 
            if ( selectedName == "liteide")
            {
                MessageBox.Show("默认配置文件不能删除", "无法删除", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var result = MessageBox.Show("确认删除配置?", "删除配置", MessageBoxButtons.YesNo );
            if (result != System.Windows.Forms.DialogResult.Yes)
                return;

            Delete(selectedName);
        }


        private void btnClone_Click(object sender, EventArgs e)
        {
            var selectedName = GetSelectedName();
            var name = Interaction.InputBox("输入名称", "克隆配置", selectedName);
            if (name == "")
                return;

            Clone(selectedName, name);

            RefreshNames();
        }


        private void btnRename_Click(object sender, EventArgs e)
        {
            var selectedName = GetSelectedName();
            var name = Interaction.InputBox("输入名称", "修改名字", selectedName);
            if (name == "")
                return;

            Rename(selectedName, name);

            RefreshNames();
        }

        private void btnSetPath_Click(object sender, EventArgs e)
        {
            SetAppFileName();
        }

    }
}
