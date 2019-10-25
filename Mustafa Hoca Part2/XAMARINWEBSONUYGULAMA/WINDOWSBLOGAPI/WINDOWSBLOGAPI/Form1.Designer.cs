namespace WINDOWSBLOGAPI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKULLANICI_REFNO = new System.Windows.Forms.TextBox();
            this.txtKULLANICI_ADI = new System.Windows.Forms.TextBox();
            this.txtPAROLA = new System.Windows.Forms.TextBox();
            this.txtDURUMU = new System.Windows.Forms.TextBox();
            this.Yeni = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Refno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durumu";
            // 
            // txtKULLANICI_REFNO
            // 
            this.txtKULLANICI_REFNO.Location = new System.Drawing.Point(256, 13);
            this.txtKULLANICI_REFNO.Name = "txtKULLANICI_REFNO";
            this.txtKULLANICI_REFNO.Size = new System.Drawing.Size(100, 20);
            this.txtKULLANICI_REFNO.TabIndex = 5;
            // 
            // txtKULLANICI_ADI
            // 
            this.txtKULLANICI_ADI.Location = new System.Drawing.Point(256, 44);
            this.txtKULLANICI_ADI.Name = "txtKULLANICI_ADI";
            this.txtKULLANICI_ADI.Size = new System.Drawing.Size(100, 20);
            this.txtKULLANICI_ADI.TabIndex = 6;
            // 
            // txtPAROLA
            // 
            this.txtPAROLA.Location = new System.Drawing.Point(256, 81);
            this.txtPAROLA.Name = "txtPAROLA";
            this.txtPAROLA.Size = new System.Drawing.Size(100, 20);
            this.txtPAROLA.TabIndex = 7;
            // 
            // txtDURUMU
            // 
            this.txtDURUMU.Location = new System.Drawing.Point(256, 112);
            this.txtDURUMU.Name = "txtDURUMU";
            this.txtDURUMU.Size = new System.Drawing.Size(100, 20);
            this.txtDURUMU.TabIndex = 8;
            // 
            // Yeni
            // 
            this.Yeni.Location = new System.Drawing.Point(137, 158);
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(75, 23);
            this.Yeni.TabIndex = 9;
            this.Yeni.Text = "Yeni";
            this.Yeni.UseVisualStyleBackColor = true;
            this.Yeni.Click += new System.EventHandler(this.Yeni_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(563, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Yeni);
            this.Controls.Add(this.txtDURUMU);
            this.Controls.Add(this.txtPAROLA);
            this.Controls.Add(this.txtKULLANICI_ADI);
            this.Controls.Add(this.txtKULLANICI_REFNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKULLANICI_REFNO;
        private System.Windows.Forms.TextBox txtKULLANICI_ADI;
        private System.Windows.Forms.TextBox txtPAROLA;
        private System.Windows.Forms.TextBox txtDURUMU;
        private System.Windows.Forms.Button Yeni;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

