namespace LiteMate
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMain = new System.Windows.Forms.ListBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnSyncToCurr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstMain.FormattingEnabled = true;
            this.lstMain.ItemHeight = 31;
            this.lstMain.Location = new System.Drawing.Point(12, 8);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(170, 221);
            this.lstMain.TabIndex = 0;
            this.lstMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMain_MouseDoubleClick);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(188, 89);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(62, 28);
            this.btnClone.TabIndex = 2;
            this.btnClone.Text = "克隆";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(256, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(188, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 65);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(188, 123);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(62, 28);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "改名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnSetPath
            // 
            this.btnSetPath.Location = new System.Drawing.Point(256, 89);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(62, 28);
            this.btnSetPath.TabIndex = 1;
            this.btnSetPath.Text = "设置路径";
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnSyncToCurr
            // 
            this.btnSyncToCurr.Location = new System.Drawing.Point(188, 168);
            this.btnSyncToCurr.Name = "btnSyncToCurr";
            this.btnSyncToCurr.Size = new System.Drawing.Size(130, 32);
            this.btnSyncToCurr.TabIndex = 2;
            this.btnSyncToCurr.Text = "保存:当前->选中";
            this.btnSyncToCurr.UseVisualStyleBackColor = true;
            this.btnSyncToCurr.Click += new System.EventHandler(this.btnSyncToCurr_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(332, 238);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSyncToCurr);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.lstMain);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "LiteMate";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.ListBox lstMain;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Button btnSyncToCurr;

    }
}

