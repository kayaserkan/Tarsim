namespace TarsimLog
{
    partial class WeightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeightForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAgirlikDegeri = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.btnFileCreate = new System.Windows.Forms.Button();
            this.gridViewLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(53, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 86);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "VERİ KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAgirlikDegeri
            // 
            this.lblAgirlikDegeri.AutoSize = true;
            this.lblAgirlikDegeri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgirlikDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAgirlikDegeri.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAgirlikDegeri.Location = new System.Drawing.Point(49, 62);
            this.lblAgirlikDegeri.Name = "lblAgirlikDegeri";
            this.lblAgirlikDegeri.Size = new System.Drawing.Size(499, 135);
            this.lblAgirlikDegeri.TabIndex = 1;
            this.lblAgirlikDegeri.Text = "0010.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "BARKOD";
            // 
            // tbBarkod
            // 
            this.tbBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBarkod.Location = new System.Drawing.Point(133, 271);
            this.tbBarkod.MaxLength = 13;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(357, 45);
            this.tbBarkod.TabIndex = 5;
            // 
            // btnFileCreate
            // 
            this.btnFileCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFileCreate.Location = new System.Drawing.Point(315, 464);
            this.btnFileCreate.Name = "btnFileCreate";
            this.btnFileCreate.Size = new System.Drawing.Size(233, 86);
            this.btnFileCreate.TabIndex = 0;
            this.btnFileCreate.Text = "DOSYA OLUŞTUR";
            this.btnFileCreate.UseVisualStyleBackColor = true;
            this.btnFileCreate.Click += new System.EventHandler(this.btnFileCreate_Click);
            // 
            // gridViewLog
            // 
            this.gridViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLog.Location = new System.Drawing.Point(605, 62);
            this.gridViewLog.Name = "gridViewLog";
            this.gridViewLog.RowHeadersWidth = 51;
            this.gridViewLog.RowTemplate.Height = 24;
            this.gridViewLog.Size = new System.Drawing.Size(620, 535);
            this.gridViewLog.TabIndex = 7;
            // 
            // WeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 621);
            this.Controls.Add(this.gridViewLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBarkod);
            this.Controls.Add(this.lblAgirlikDegeri);
            this.Controls.Add(this.btnFileCreate);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1263, 668);
            this.Name = "WeightForm";
            this.Text = "WeightForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeightForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WeightForm_FormClosed);
            this.Load += new System.EventHandler(this.WeightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAgirlikDegeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBarkod;
        private System.Windows.Forms.Button btnFileCreate;
        private System.Windows.Forms.DataGridView gridViewLog;
    }
}