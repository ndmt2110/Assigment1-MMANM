namespace Protect_Data
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
			if(disposing && (components != null))
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
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnInputFile = new System.Windows.Forms.Button();
			this.cmbInputType = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtInputFile = new DevExpress.XtraEditors.TextEdit();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtInputKey = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.xtraTabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbInputType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInputFile.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInputKey.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo
			// 
			this.picLogo.Image = global::ProtectFiles.Properties.Resources.logo;
			this.picLogo.Location = new System.Drawing.Point(6, 1);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(81, 77);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(76, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 75);
			this.label1.TabIndex = 1;
			this.label1.Text = "Protect Files";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.BackgroundImage = global::ProtectFiles.Properties.Resources.exit;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(747, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 59);
			this.button1.TabIndex = 3;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
			this.xtraTabPage2.Image = global::ProtectFiles.Properties.Resources.decrypt2;
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(599, 408);
			this.xtraTabPage2.Text = "DECRYPT";
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
			this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Maroon;
			this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
			this.xtraTabPage1.Controls.Add(this.groupBox1);
			this.xtraTabPage1.Image = global::ProtectFiles.Properties.Resources.encrypt2;
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(599, 408);
			this.xtraTabPage1.Text = "ENCRYPT";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnInputFile);
			this.groupBox1.Controls.Add(this.cmbInputType);
			this.groupBox1.Controls.Add(this.txtInputKey);
			this.groupBox1.Controls.Add(this.txtInputFile);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(14, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(571, 344);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnInputFile
			// 
			this.btnInputFile.Font = new System.Drawing.Font("Cambria", 14.25F);
			this.btnInputFile.Location = new System.Drawing.Point(489, 20);
			this.btnInputFile.Name = "btnInputFile";
			this.btnInputFile.Size = new System.Drawing.Size(36, 33);
			this.btnInputFile.TabIndex = 3;
			this.btnInputFile.Text = "...";
			this.btnInputFile.UseVisualStyleBackColor = true;
			this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
			// 
			// cmbInputType
			// 
			this.cmbInputType.Location = new System.Drawing.Point(140, 75);
			this.cmbInputType.Name = "cmbInputType";
			this.cmbInputType.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
			this.cmbInputType.Properties.Appearance.Options.UseFont = true;
			this.cmbInputType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbInputType.Properties.Items.AddRange(new object[] {
            "DES",
            "ABC",
            "RSA"});
			this.cmbInputType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.cmbInputType.Size = new System.Drawing.Size(143, 28);
			this.cmbInputType.TabIndex = 2;
			// 
			// txtInputFile
			// 
			this.txtInputFile.Location = new System.Drawing.Point(140, 25);
			this.txtInputFile.Name = "txtInputFile";
			this.txtInputFile.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
			this.txtInputFile.Properties.Appearance.Options.UseFont = true;
			this.txtInputFile.Size = new System.Drawing.Size(321, 28);
			this.txtInputFile.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 22);
			this.label3.TabIndex = 0;
			this.label3.Text = "Type Encrypt";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Input File Path";
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
			this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
			this.xtraTabControl1.Location = new System.Drawing.Point(27, 110);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.Size = new System.Drawing.Size(778, 414);
			this.xtraTabControl1.TabIndex = 4;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.BackgroundImage = global::ProtectFiles.Properties.Resources.minisize;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(662, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(58, 59);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Key";
			// 
			// txtInputKey
			// 
			this.txtInputKey.Location = new System.Drawing.Point(140, 125);
			this.txtInputKey.Name = "txtInputKey";
			this.txtInputKey.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
			this.txtInputKey.Properties.Appearance.Options.UseFont = true;
			this.txtInputKey.Size = new System.Drawing.Size(143, 28);
			this.txtInputKey.TabIndex = 1;
			// 
			// Form1
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 549);
			this.Controls.Add(this.xtraTabControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLogo);
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.xtraTabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbInputType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInputFile.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtInputKey.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private DevExpress.XtraEditors.TextEdit txtInputFile;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.ComboBoxEdit cmbInputType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnInputFile;
		private DevExpress.XtraEditors.TextEdit txtInputKey;
		private System.Windows.Forms.Label label4;
	}
}

