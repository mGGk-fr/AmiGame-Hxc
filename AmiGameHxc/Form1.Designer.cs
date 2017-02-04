namespace AmiGameHxc
{
    partial class Form1
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
            this.tb_adfDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_outDir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_gameList = new System.Windows.Forms.ListBox();
            this.lbl_pgl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_fileFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_adfDir
            // 
            this.tb_adfDir.Location = new System.Drawing.Point(67, 40);
            this.tb_adfDir.Name = "tb_adfDir";
            this.tb_adfDir.Size = new System.Drawing.Size(304, 20);
            this.tb_adfDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HFE Dir : ";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(377, 38);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(94, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // browser
            // 
            this.browser.Description = "Select directory that contains your adf";
            this.browser.ShowNewFolderButton = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Do the Work Buddy !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Out dir :";
            // 
            // tb_outDir
            // 
            this.tb_outDir.Location = new System.Drawing.Point(67, 68);
            this.tb_outDir.Name = "tb_outDir";
            this.tb_outDir.Size = new System.Drawing.Size(304, 20);
            this.tb_outDir.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_gameList
            // 
            this.lb_gameList.FormattingEnabled = true;
            this.lb_gameList.Location = new System.Drawing.Point(15, 137);
            this.lb_gameList.Name = "lb_gameList";
            this.lb_gameList.Size = new System.Drawing.Size(456, 290);
            this.lb_gameList.TabIndex = 7;
            // 
            // lbl_pgl
            // 
            this.lbl_pgl.AutoSize = true;
            this.lbl_pgl.Location = new System.Drawing.Point(15, 121);
            this.lbl_pgl.Name = "lbl_pgl";
            this.lbl_pgl.Size = new System.Drawing.Size(116, 13);
            this.lbl_pgl.TabIndex = 8;
            this.lbl_pgl.Text = "Processed Game List : ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(406, 17);
            this.toolStripStatusLabel1.Text = "AmiGame HxC  (v1.1) : Guillaume \"mGGk\" Arino / 2015 / Under GNU GPL v3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "About...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_fileFormat
            // 
            this.tb_fileFormat.Location = new System.Drawing.Point(353, 13);
            this.tb_fileFormat.Name = "tb_fileFormat";
            this.tb_fileFormat.Size = new System.Drawing.Size(115, 20);
            this.tb_fileFormat.TabIndex = 11;
            this.tb_fileFormat.Text = "hfe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "File extension : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_fileFormat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_pgl);
            this.Controls.Add(this.lb_gameList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_outDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_adfDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AmiGame HxC";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_adfDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.FolderBrowserDialog browser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_outDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lb_gameList;
        private System.Windows.Forms.Label lbl_pgl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_fileFormat;
        private System.Windows.Forms.Label label3;
    }
}

