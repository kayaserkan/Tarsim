namespace TarsimLog
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPcAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPcKayit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbR2 = new System.Windows.Forms.RadioButton();
            this.rbR2M = new System.Windows.Forms.RadioButton();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPortKaydet = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tbPcAdi);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnPcKayit);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 211);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(9, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "PC ADI";
            // 
            // tbPcAdi
            // 
            this.tbPcAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPcAdi.Location = new System.Drawing.Point(99, 46);
            this.tbPcAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPcAdi.Name = "tbPcAdi";
            this.tbPcAdi.Size = new System.Drawing.Size(265, 27);
            this.tbPcAdi.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "BİLGİSAYAR KAYIT";
            // 
            // btnPcKayit
            // 
            this.btnPcKayit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPcKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnPcKayit.Image")));
            this.btnPcKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPcKayit.Location = new System.Drawing.Point(26, 141);
            this.btnPcKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPcKayit.Name = "btnPcKayit";
            this.btnPcKayit.Size = new System.Drawing.Size(326, 49);
            this.btnPcKayit.TabIndex = 1;
            this.btnPcKayit.Text = "PC  KAYDET";
            this.btnPcKayit.UseVisualStyleBackColor = false;
            this.btnPcKayit.Click += new System.EventHandler(this.btnPcKayit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbR2);
            this.groupBox1.Controls.Add(this.rbR2M);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.cbPortName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnPortKaydet);
            this.groupBox1.Location = new System.Drawing.Point(442, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 281);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // rbR2
            // 
            this.rbR2.AutoSize = true;
            this.rbR2.Location = new System.Drawing.Point(218, 153);
            this.rbR2.Name = "rbR2";
            this.rbR2.Size = new System.Drawing.Size(97, 20);
            this.rbR2.TabIndex = 34;
            this.rbR2.TabStop = true;
            this.rbR2.Text = "PS 4500.R2";
            this.rbR2.UseVisualStyleBackColor = true;
            // 
            // rbR2M
            // 
            this.rbR2M.AutoSize = true;
            this.rbR2M.Location = new System.Drawing.Point(30, 153);
            this.rbR2M.Name = "rbR2M";
            this.rbR2M.Size = new System.Drawing.Size(111, 20);
            this.rbR2M.TabIndex = 35;
            this.rbR2M.TabStop = true;
            this.rbR2M.Text = "PS 4500.R2.M";
            this.rbR2M.UseVisualStyleBackColor = true;
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(230, 99);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 28);
            this.cbParity.TabIndex = 33;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(230, 65);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cbBaudRate.TabIndex = 32;
            // 
            // cbPortName
            // 
            this.cbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(230, 27);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(121, 28);
            this.cbPortName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "PARITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "BAUDRATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(22, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "COM PORT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(96, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "COMPORT AYARLARI";
            // 
            // btnPortKaydet
            // 
            this.btnPortKaydet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPortKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnPortKaydet.Image")));
            this.btnPortKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPortKaydet.Location = new System.Drawing.Point(26, 208);
            this.btnPortKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPortKaydet.Name = "btnPortKaydet";
            this.btnPortKaydet.Size = new System.Drawing.Size(326, 49);
            this.btnPortKaydet.TabIndex = 1;
            this.btnPortKaydet.Text = "PORT KAYDET";
            this.btnPortKaydet.UseVisualStyleBackColor = false;
            this.btnPortKaydet.Click += new System.EventHandler(this.btnPortKaydet_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(896, 393);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPcAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPcKayit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbR2;
        private System.Windows.Forms.RadioButton rbR2M;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPortKaydet;
    }
}