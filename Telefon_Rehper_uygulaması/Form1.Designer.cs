namespace Telefon_Rehper_uygulaması
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_AD = new System.Windows.Forms.TextBox();
            this.btn_EKLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SOYAD = new System.Windows.Forms.TextBox();
            this.txt_MAİL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TEMİZLE = new System.Windows.Forms.Button();
            this.btn_GÜNCELLE = new System.Windows.Forms.Button();
            this.btn_SİL = new System.Windows.Forms.Button();
            this.msk_TEL = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehper";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msk_TEL);
            this.groupBox2.Controls.Add(this.btn_SİL);
            this.groupBox2.Controls.Add(this.btn_GÜNCELLE);
            this.groupBox2.Controls.Add(this.btn_TEMİZLE);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_MAİL);
            this.groupBox2.Controls.Add(this.txt_SOYAD);
            this.groupBox2.Controls.Add(this.btn_EKLE);
            this.groupBox2.Controls.Add(this.txt_AD);
            this.groupBox2.Controls.Add(this.txt_ID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(923, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(110, 48);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(297, 34);
            this.txt_ID.TabIndex = 1;
            // 
            // txt_AD
            // 
            this.txt_AD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_AD.Location = new System.Drawing.Point(110, 100);
            this.txt_AD.Name = "txt_AD";
            this.txt_AD.Size = new System.Drawing.Size(297, 34);
            this.txt_AD.TabIndex = 2;
            // 
            // btn_EKLE
            // 
            this.btn_EKLE.Location = new System.Drawing.Point(45, 321);
            this.btn_EKLE.Name = "btn_EKLE";
            this.btn_EKLE.Size = new System.Drawing.Size(173, 53);
            this.btn_EKLE.TabIndex = 6;
            this.btn_EKLE.Text = "EKLE";
            this.btn_EKLE.UseVisualStyleBackColor = true;
            this.btn_EKLE.Click += new System.EventHandler(this.btn_EKLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYAD:";
            // 
            // txt_SOYAD
            // 
            this.txt_SOYAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_SOYAD.Location = new System.Drawing.Point(111, 156);
            this.txt_SOYAD.Name = "txt_SOYAD";
            this.txt_SOYAD.Size = new System.Drawing.Size(297, 34);
            this.txt_SOYAD.TabIndex = 3;
            // 
            // txt_MAİL
            // 
            this.txt_MAİL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_MAİL.Location = new System.Drawing.Point(111, 265);
            this.txt_MAİL.Name = "txt_MAİL";
            this.txt_MAİL.Size = new System.Drawing.Size(297, 34);
            this.txt_MAİL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "MAİL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "TEL:";
            // 
            // btn_TEMİZLE
            // 
            this.btn_TEMİZLE.Location = new System.Drawing.Point(224, 394);
            this.btn_TEMİZLE.Name = "btn_TEMİZLE";
            this.btn_TEMİZLE.Size = new System.Drawing.Size(184, 53);
            this.btn_TEMİZLE.TabIndex = 9;
            this.btn_TEMİZLE.Text = "TEMİZLE";
            this.btn_TEMİZLE.UseVisualStyleBackColor = true;
            this.btn_TEMİZLE.Click += new System.EventHandler(this.btn_TEMİZLE_Click);
            // 
            // btn_GÜNCELLE
            // 
            this.btn_GÜNCELLE.Location = new System.Drawing.Point(45, 394);
            this.btn_GÜNCELLE.Name = "btn_GÜNCELLE";
            this.btn_GÜNCELLE.Size = new System.Drawing.Size(173, 53);
            this.btn_GÜNCELLE.TabIndex = 8;
            this.btn_GÜNCELLE.Text = "GÜNCELLE";
            this.btn_GÜNCELLE.UseVisualStyleBackColor = true;
            this.btn_GÜNCELLE.Click += new System.EventHandler(this.btn_GÜNCELLE_Click);
            // 
            // btn_SİL
            // 
            this.btn_SİL.Location = new System.Drawing.Point(224, 321);
            this.btn_SİL.Name = "btn_SİL";
            this.btn_SİL.Size = new System.Drawing.Size(184, 53);
            this.btn_SİL.TabIndex = 7;
            this.btn_SİL.Text = "SİL";
            this.btn_SİL.UseVisualStyleBackColor = true;
            this.btn_SİL.Click += new System.EventHandler(this.btn_SİL_Click);
            // 
            // msk_TEL
            // 
            this.msk_TEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.msk_TEL.Location = new System.Drawing.Point(110, 212);
            this.msk_TEL.Mask = "(999) 000-0000";
            this.msk_TEL.Name = "msk_TEL";
            this.msk_TEL.Size = new System.Drawing.Size(297, 34);
            this.msk_TEL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1400, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox msk_TEL;
        private System.Windows.Forms.Button btn_SİL;
        private System.Windows.Forms.Button btn_GÜNCELLE;
        private System.Windows.Forms.Button btn_TEMİZLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MAİL;
        private System.Windows.Forms.TextBox txt_SOYAD;
        private System.Windows.Forms.Button btn_EKLE;
        private System.Windows.Forms.TextBox txt_AD;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

