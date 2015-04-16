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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tahuntextBox = new System.Windows.Forms.TextBox();
            this.tahunLabel = new System.Windows.Forms.Label();
            this.bulanComboBox = new System.Windows.Forms.ComboBox();
            this.tampilkanButton = new System.Windows.Forms.Button();
            this.bulanLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.biayaLabel = new System.Windows.Forms.Label();
            this.biayaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlahTextBox = new System.Windows.Forms.TextBox();
            this.namaLabel = new System.Windows.Forms.Label();
            this.tanggalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ketTextBox = new System.Windows.Forms.TextBox();
            this.tanggalLabel = new System.Windows.Forms.Label();
            this.laporanHarianLabel = new System.Windows.Forms.Label();
            this.pengeluaranDataGridView = new System.Windows.Forms.DataGridView();
            this.pemasukanDataGridView = new System.Windows.Forms.DataGridView();
            this.pemasukanLabel = new System.Windows.Forms.Label();
            this.pengeluaranLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pemasukanTotalLabel = new System.Windows.Forms.Label();
            this.pengeluaranTotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.anggaranTotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tahuntextBox);
            this.groupBox2.Controls.Add(this.tahunLabel);
            this.groupBox2.Controls.Add(this.bulanComboBox);
            this.groupBox2.Controls.Add(this.tampilkanButton);
            this.groupBox2.Controls.Add(this.bulanLabel);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lihat Laporan Bulanan";
            // 
            // tahuntextBox
            // 
            this.tahuntextBox.Location = new System.Drawing.Point(61, 61);
            this.tahuntextBox.Name = "tahuntextBox";
            this.tahuntextBox.Size = new System.Drawing.Size(55, 26);
            this.tahuntextBox.TabIndex = 6;
            // 
            // tahunLabel
            // 
            this.tahunLabel.AutoSize = true;
            this.tahunLabel.Location = new System.Drawing.Point(7, 65);
            this.tahunLabel.Name = "tahunLabel";
            this.tahunLabel.Size = new System.Drawing.Size(45, 19);
            this.tahunLabel.TabIndex = 5;
            this.tahunLabel.Text = "Tahun";
            // 
            // bulanComboBox
            // 
            this.bulanComboBox.FormattingEnabled = true;
            this.bulanComboBox.Location = new System.Drawing.Point(61, 28);
            this.bulanComboBox.Name = "bulanComboBox";
            this.bulanComboBox.Size = new System.Drawing.Size(98, 27);
            this.bulanComboBox.TabIndex = 3;
            // 
            // tampilkanButton
            // 
            this.tampilkanButton.Location = new System.Drawing.Point(78, 99);
            this.tampilkanButton.Name = "tampilkanButton";
            this.tampilkanButton.Size = new System.Drawing.Size(81, 29);
            this.tampilkanButton.TabIndex = 2;
            this.tampilkanButton.Text = "Tampilkan";
            this.tampilkanButton.UseVisualStyleBackColor = true;
            this.tampilkanButton.Click += new System.EventHandler(this.tampilkanButton_Click);
            // 
            // bulanLabel
            // 
            this.bulanLabel.AutoSize = true;
            this.bulanLabel.Location = new System.Drawing.Point(8, 32);
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
            this.groupBox1.Controls.Add(this.tanggalDateTimePicker);
            this.groupBox1.Controls.Add(this.ketTextBox);
            this.groupBox1.Controls.Add(this.tanggalLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Pengeluaran";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(371, 127);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 29);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
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
            // namaLabel
            // 
            this.namaLabel.AutoSize = true;
            this.namaLabel.Location = new System.Drawing.Point(21, 66);
            this.namaLabel.Name = "namaLabel";
            this.namaLabel.Size = new System.Drawing.Size(79, 19);
            this.namaLabel.TabIndex = 3;
            this.namaLabel.Text = "Keterangan";
            // 
            // tanggalDateTimePicker
            // 
            this.tanggalDateTimePicker.Location = new System.Drawing.Point(102, 30);
            this.tanggalDateTimePicker.Name = "tanggalDateTimePicker";
            this.tanggalDateTimePicker.Size = new System.Drawing.Size(166, 26);
            this.tanggalDateTimePicker.TabIndex = 2;
            // 
            // ketTextBox
            // 
            this.ketTextBox.Location = new System.Drawing.Point(102, 62);
            this.ketTextBox.Name = "ketTextBox";
            this.ketTextBox.Size = new System.Drawing.Size(344, 26);
            this.ketTextBox.TabIndex = 1;
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
            // laporanHarianLabel
            // 
            this.laporanHarianLabel.AutoSize = true;
            this.laporanHarianLabel.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanHarianLabel.Location = new System.Drawing.Point(173, 6);
            this.laporanHarianLabel.Name = "laporanHarianLabel";
            this.laporanHarianLabel.Size = new System.Drawing.Size(291, 43);
            this.laporanHarianLabel.TabIndex = 7;
            this.laporanHarianLabel.Text = "Laporan Bulanan";
            this.laporanHarianLabel.Click += new System.EventHandler(this.laporanHarianLabel_Click);
            // 
            // pengeluaranDataGridView
            // 
            this.pengeluaranDataGridView.AllowUserToAddRows = false;
            this.pengeluaranDataGridView.AllowUserToDeleteRows = false;
            this.pengeluaranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pengeluaranDataGridView.Location = new System.Drawing.Point(12, 458);
            this.pengeluaranDataGridView.Name = "pengeluaranDataGridView";
            this.pengeluaranDataGridView.ReadOnly = true;
            this.pengeluaranDataGridView.Size = new System.Drawing.Size(632, 166);
            this.pengeluaranDataGridView.TabIndex = 8;
            this.pengeluaranDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pemasukanDataGridView
            // 
            this.pemasukanDataGridView.AllowUserToAddRows = false;
            this.pemasukanDataGridView.AllowUserToDeleteRows = false;
            this.pemasukanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pemasukanDataGridView.Location = new System.Drawing.Point(12, 236);
            this.pemasukanDataGridView.Name = "pemasukanDataGridView";
            this.pemasukanDataGridView.ReadOnly = true;
            this.pemasukanDataGridView.Size = new System.Drawing.Size(632, 166);
            this.pemasukanDataGridView.TabIndex = 9;
            // 
            // pemasukanLabel
            // 
            this.pemasukanLabel.AutoSize = true;
            this.pemasukanLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukanLabel.Location = new System.Drawing.Point(19, 214);
            this.pemasukanLabel.Name = "pemasukanLabel";
            this.pemasukanLabel.Size = new System.Drawing.Size(86, 19);
            this.pemasukanLabel.TabIndex = 10;
            this.pemasukanLabel.Text = "Pemasukan";
            // 
            // pengeluaranLabel
            // 
            this.pengeluaranLabel.AutoSize = true;
            this.pengeluaranLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranLabel.Location = new System.Drawing.Point(19, 436);
            this.pengeluaranLabel.Name = "pengeluaranLabel";
            this.pengeluaranLabel.Size = new System.Drawing.Size(92, 19);
            this.pengeluaranLabel.TabIndex = 11;
            this.pengeluaranLabel.Text = "Pengeluaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pemasukan Total :";
            // 
            // pemasukanTotalLabel
            // 
            this.pemasukanTotalLabel.AutoSize = true;
            this.pemasukanTotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukanTotalLabel.Location = new System.Drawing.Point(500, 405);
            this.pemasukanTotalLabel.Name = "pemasukanTotalLabel";
            this.pemasukanTotalLabel.Size = new System.Drawing.Size(33, 19);
            this.pemasukanTotalLabel.TabIndex = 12;
            this.pemasukanTotalLabel.Text = "###";
            // 
            // pengeluaranTotalLabel
            // 
            this.pengeluaranTotalLabel.AutoSize = true;
            this.pengeluaranTotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranTotalLabel.Location = new System.Drawing.Point(500, 627);
            this.pengeluaranTotalLabel.Name = "pengeluaranTotalLabel";
            this.pengeluaranTotalLabel.Size = new System.Drawing.Size(33, 19);
            this.pengeluaranTotalLabel.TabIndex = 14;
            this.pengeluaranTotalLabel.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pengeluaran Total :";
            // 
            // anggaranTotalLabel
            // 
            this.anggaranTotalLabel.AutoSize = true;
            this.anggaranTotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anggaranTotalLabel.Location = new System.Drawing.Point(500, 655);
            this.anggaranTotalLabel.Name = "anggaranTotalLabel";
            this.anggaranTotalLabel.Size = new System.Drawing.Size(33, 19);
            this.anggaranTotalLabel.TabIndex = 16;
            this.anggaranTotalLabel.Text = "###";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Anggaran Total :";
            // 
            // LaporanBulanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 680);
            this.Controls.Add(this.anggaranTotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pengeluaranTotalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pemasukanTotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pengeluaranLabel);
            this.Controls.Add(this.pemasukanLabel);
            this.Controls.Add(this.pemasukanDataGridView);
            this.Controls.Add(this.pengeluaranDataGridView);
            this.Controls.Add(this.laporanHarianLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "LaporanBulanan";
            this.Text = "autoTrans";
            this.Load += new System.EventHandler(this.LaporanBulanan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanDataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker tanggalDateTimePicker;
        private System.Windows.Forms.TextBox ketTextBox;
        private System.Windows.Forms.Label tanggalLabel;
        private System.Windows.Forms.Label biayaLabel;
        private System.Windows.Forms.TextBox biayaTextBox;
        private System.Windows.Forms.Button tampilkanButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label laporanHarianLabel;
        private System.Windows.Forms.DataGridView pengeluaranDataGridView;
        private System.Windows.Forms.DataGridView pemasukanDataGridView;
        private System.Windows.Forms.Label pemasukanLabel;
        private System.Windows.Forms.Label pengeluaranLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pemasukanTotalLabel;
        private System.Windows.Forms.Label pengeluaranTotalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label anggaranTotalLabel;
        private System.Windows.Forms.Label label5;
    }
}