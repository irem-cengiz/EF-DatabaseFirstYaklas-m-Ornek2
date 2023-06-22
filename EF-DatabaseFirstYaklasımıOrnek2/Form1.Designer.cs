namespace EF_DatabaseFirstYaklasımıOrnek2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtSirketAdi = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvMusteri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Şirket Adı:";
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 23);
            txtId.TabIndex = 2;
            // 
            // txtSirketAdi
            // 
            txtSirketAdi.Location = new Point(153, 92);
            txtSirketAdi.Name = "txtSirketAdi";
            txtSirketAdi.Size = new Size(152, 23);
            txtSirketAdi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(83, 162);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 28);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(187, 159);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 31);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(282, 159);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 31);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvMusteri
            // 
            dgvMusteri.AllowUserToAddRows = false;
            dgvMusteri.AllowUserToDeleteRows = false;
            dgvMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteri.Location = new Point(487, 43);
            dgvMusteri.Name = "dgvMusteri";
            dgvMusteri.ReadOnly = true;
            dgvMusteri.RowTemplate.Height = 25;
            dgvMusteri.Size = new Size(547, 447);
            dgvMusteri.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 546);
            Controls.Add(dgvMusteri);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtSirketAdi);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtSirketAdi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvMusteri;
    }
}