namespace autoTrans
{
    partial class LaporanBulanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanBulanan));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tahuntextBox = new System.Windows.Forms.TextBox();
            this.tahunLabel = new System.Windows.Forms.Label();
            this.bulanComboBox = new System.Windows.Forms.ComboBox();
            this.bulanLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tanggalLabel = new System.Windows.Forms.Label();
            this.ketTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.namaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlahTextBox = new System.Windows.Forms.TextBox();
            this.biayaLabel = new System.Windows.Forms.Label();
            this.biayaTextBox = new System.Windows.Forms.TextBox();
            this.cetakButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laporanHarianLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tahuntextBox);
            this.groupBox2.Controls.Add(this.tahunLabel);
            this.groupBox2.Controls.Add(this.bulanComboBox);
            this.groupBox2.Controls.Add(this.cetakButton);
            this.groupBox2.Controls.Add(this.bulanLabel);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cetak Laporan Bulanan";
            // 
            // tahuntextBox
            // 
            this.tahuntextBox.Location = new System.Drawing.Point(85, 61);
            this.tahuntextBox.Name = "tahuntextBox";
            this.tahuntextBox.Size = new System.Drawing.Size(75, 26);
            this.tahuntextBox.TabIndex = 6;
            // 
            // tahunLabel
            // 
            this.tahunLabel.AutoSize = true;
            this.tahunLabel.Location = new System.Drawing.Point(20, 65);
            this.tahunLabel.Name = "tahunLabel";
            this.tahunLabel.Size = new System.Drawing.Size(45, 19);
            this.tahunLabel.TabIndex = 5;
            this.tahunLabel.Text = "Tahun";
            // 
            // bulanComboBox
            // 
            this.bulanComboBox.FormattingEnabled = true;
            this.bulanComboBox.Location = new System.Drawing.Point(85, 28);
            this.bulanComboBox.Name = "bulanComboBox";
            this.bulanComboBox.Size = new System.Drawing.Size(75, 27);
            this.bulanComboBox.TabIndex = 3;
            // 
            // bulanLabel
            // 
            this.bulanLabel.AutoSize = true;
            this.bulanLabel.Location = new System.Drawing.Point(21, 32);
            this.bulanLabel.Name = "bulanLabel";
            this.bulanLabel.Size = new System.Drawing.Size(43, 19);
            this.bulanLabel.TabIndex = 1;
            this.bulanLabel.Text = "Bulan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.biayaLabel);
            this.groupBox1.Controls.Add(this.biayaTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.jumlahTextBox);
            this.groupBox1.Controls.Add(this.namaLabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.ketTextBox);
            this.groupBox1.Controls.Add(this.tanggalLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Pengeluaran";
            // 
            // tanggalLabel
            // 
            this.tanggalLabel.AutoSize = true;
            this.tanggalLabel.Location = new System.Drawing.Point(21, 34);
            this.tanggalLabel.Name = "tanggalLabel";
            this.tanggalLabel.Size = new System.Drawing.Size(55, 19);
            this.tanggalLabel.TabIndex = 0;
            this.tanggalLabel.Text = "Tanggal";
            this.tanggalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ketTextBox
            // 
            this.ketTextBox.Location = new System.Drawing.Point(102, 62);
            this.ketTextBox.Name = "ketTextBox";
            this.ketTextBox.Size = new System.Drawing.Size(344, 26);
            this.ketTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // namaLabel
            // 
            this.namaLabel.AutoSize = true;
            this.namaLabel.Location = new System.Drawing.Point(21, 66);
            this.namaLabel.Name = "namaLabel";
            this.namaLabel.Size = new System.Drawing.Size(79, 19);
            this.namaLabel.TabIndex = 3;
            this.namaLabel.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah/Unit";
            // 
            // jumlahTextBox
            // 
            this.jumlahTextBox.Location = new System.Drawing.Point(346, 95);
            this.jumlahTextBox.Name = "jumlahTextBox";
            this.jumlahTextBox.Size = new System.Drawing.Size(50, 26);
            this.jumlahTextBox.TabIndex = 4;
            // 
            // biayaLabel
            // 
            this.biayaLabel.AutoSize = true;
            this.biayaLabel.Location = new System.Drawing.Point(21, 99);
            this.biayaLabel.Name = "biayaLabel";
            this.biayaLabel.Size = new System.Drawing.Size(75, 19);
            this.biayaLabel.TabIndex = 7;
            this.biayaLabel.Text = "Biaya (Rp)";
            // 
            // biayaTextBox
            // 
            this.biayaTextBox.Location = new System.Drawing.Point(102, 95);
            this.biayaTextBox.Name = "biayaTextBox";
            this.biayaTextBox.Size = new System.Drawing.Size(157, 26);
            this.biayaTextBox.TabIndex = 6;
            // 
            // cetakButton
            // 
            this.cetakButton.Location = new System.Drawing.Point(85, 91);
            this.cetakButton.Name = "cetakButton";
            this.cetakButton.Size = new System.Drawing.Size(75, 29);
            this.cetakButton.TabIndex = 2;
            this.cetakButton.Text = "Cetak";
            this.cetakButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(371, 127);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 29);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 231);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // laporanHarianLabel
            // 
            this.laporanHarianLabel.AutoSize = true;
            this.laporanHarianLabel.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanHarianLabel.Location = new System.Drawing.Point(173, 24);
            this.laporanHarianLabel.Name = "laporanHarianLabel";
            this.laporanHarianLabel.Size = new System.Drawing.Size(291, 43);
            this.laporanHarianLabel.TabIndex = 7;
            this.laporanHarianLabel.Text = "Laporan Bulanan";
            this.laporanHarianLabel.Click += new System.EventHandler(this.laporanHarianLabel_Click);
            // 
            // LaporanBulanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 506);
            this.Controls.Add(this.laporanHarianLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "LaporanBulanan";
            this.Text = "autoTrans";
            this.Load += new System.EventHandler(this.LaporanBulanan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tahuntextBox;
        private System.Windows.Forms.Label tahunLabel;
        private System.Windows.Forms.ComboBox bulanComboBox;
        private System.Windows.Forms.Label bulanLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jumlahTextBox;
        private System.Windows.Forms.Label namaLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ketTextBox;
        private System.Windows.Forms.Label tanggalLabel;
        private System.Windows.Forms.Label biayaLabel;
        private System.Windows.Forms.TextBox biayaTextBox;
        private System.Windows.Forms.Button cetakButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laporanHarianLabel;
    }
}