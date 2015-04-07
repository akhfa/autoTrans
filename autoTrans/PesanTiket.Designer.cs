namespace autoTrans
{
    partial class Tiket
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
            this.judulTiketLabel = new System.Windows.Forms.Label();
            this.pelangganGroupBox = new System.Windows.Forms.GroupBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.namaTiketLabel = new System.Windows.Forms.Label();
            this.tujuanTiketLabel = new System.Windows.Forms.Label();
            this.waktuLabel = new System.Windows.Forms.Label();
            this.waktuComboBox = new System.Windows.Forms.ComboBox();
            this.tujuanTextBox = new System.Windows.Forms.TextBox();
            this.waktuMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pelangganGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // judulTiketLabel
            // 
            this.judulTiketLabel.AutoSize = true;
            this.judulTiketLabel.Font = new System.Drawing.Font("Motorwerk", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulTiketLabel.Location = new System.Drawing.Point(99, 9);
            this.judulTiketLabel.Name = "judulTiketLabel";
            this.judulTiketLabel.Size = new System.Drawing.Size(540, 51);
            this.judulTiketLabel.TabIndex = 0;
            this.judulTiketLabel.Text = "Pemesanan Tiket";
            // 
            // pelangganGroupBox
            // 
            this.pelangganGroupBox.Controls.Add(this.waktuMonthCalendar);
            this.pelangganGroupBox.Controls.Add(this.tujuanTextBox);
            this.pelangganGroupBox.Controls.Add(this.waktuComboBox);
            this.pelangganGroupBox.Controls.Add(this.waktuLabel);
            this.pelangganGroupBox.Controls.Add(this.tujuanTiketLabel);
            this.pelangganGroupBox.Controls.Add(this.namaTiketLabel);
            this.pelangganGroupBox.Controls.Add(this.namaTextBox);
            this.pelangganGroupBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelangganGroupBox.Location = new System.Drawing.Point(12, 85);
            this.pelangganGroupBox.Name = "pelangganGroupBox";
            this.pelangganGroupBox.Size = new System.Drawing.Size(272, 373);
            this.pelangganGroupBox.TabIndex = 1;
            this.pelangganGroupBox.TabStop = false;
            this.pelangganGroupBox.Text = "Pelanggan";
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(96, 23);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(170, 23);
            this.namaTextBox.TabIndex = 0;
            // 
            // namaTiketLabel
            // 
            this.namaTiketLabel.AutoSize = true;
            this.namaTiketLabel.Location = new System.Drawing.Point(32, 26);
            this.namaTiketLabel.Name = "namaTiketLabel";
            this.namaTiketLabel.Size = new System.Drawing.Size(41, 16);
            this.namaTiketLabel.TabIndex = 1;
            this.namaTiketLabel.Text = "Nama";
            // 
            // tujuanTiketLabel
            // 
            this.tujuanTiketLabel.AutoSize = true;
            this.tujuanTiketLabel.Location = new System.Drawing.Point(32, 58);
            this.tujuanTiketLabel.Name = "tujuanTiketLabel";
            this.tujuanTiketLabel.Size = new System.Drawing.Size(47, 16);
            this.tujuanTiketLabel.TabIndex = 2;
            this.tujuanTiketLabel.Text = "Tujuan";
            // 
            // waktuLabel
            // 
            this.waktuLabel.AutoSize = true;
            this.waktuLabel.Location = new System.Drawing.Point(35, 89);
            this.waktuLabel.Name = "waktuLabel";
            this.waktuLabel.Size = new System.Drawing.Size(44, 16);
            this.waktuLabel.TabIndex = 5;
            this.waktuLabel.Text = "Waktu";
            // 
            // waktuComboBox
            // 
            this.waktuComboBox.FormattingEnabled = true;
            this.waktuComboBox.Location = new System.Drawing.Point(96, 82);
            this.waktuComboBox.Name = "waktuComboBox";
            this.waktuComboBox.Size = new System.Drawing.Size(74, 23);
            this.waktuComboBox.TabIndex = 6;
            // 
            // tujuanTextBox
            // 
            this.tujuanTextBox.Location = new System.Drawing.Point(96, 53);
            this.tujuanTextBox.Name = "tujuanTextBox";
            this.tujuanTextBox.Size = new System.Drawing.Size(170, 23);
            this.tujuanTextBox.TabIndex = 7;
            // 
            // waktuMonthCalendar
            // 
            this.waktuMonthCalendar.Location = new System.Drawing.Point(33, 117);
            this.waktuMonthCalendar.Name = "waktuMonthCalendar";
            this.waktuMonthCalendar.TabIndex = 8;
            // 
            // Tiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 470);
            this.Controls.Add(this.pelangganGroupBox);
            this.Controls.Add(this.judulTiketLabel);
            this.Name = "Tiket";
            this.Text = "autoTrans";
            this.pelangganGroupBox.ResumeLayout(false);
            this.pelangganGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judulTiketLabel;
        private System.Windows.Forms.GroupBox pelangganGroupBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Label tujuanTiketLabel;
        private System.Windows.Forms.Label namaTiketLabel;
        private System.Windows.Forms.ComboBox waktuComboBox;
        private System.Windows.Forms.Label waktuLabel;
        private System.Windows.Forms.TextBox tujuanTextBox;
        private System.Windows.Forms.MonthCalendar waktuMonthCalendar;
    }
}

