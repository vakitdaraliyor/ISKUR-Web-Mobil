namespace WebAPIRESTKullan
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSONUC = new System.Windows.Forms.TextBox();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.txtYONETICI_REFNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKULLANICI_ADI = new System.Windows.Forms.TextBox();
            this.txtSIFRESI = new System.Windows.Forms.TextBox();
            this.txtDURUMU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtSONUC
            // 
            this.txtSONUC.Location = new System.Drawing.Point(71, 84);
            this.txtSONUC.Multiline = true;
            this.txtSONUC.Name = "txtSONUC";
            this.txtSONUC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSONUC.Size = new System.Drawing.Size(659, 102);
            this.txtSONUC.TabIndex = 1;
            // 
            // txtADRES
            // 
            this.txtADRES.Location = new System.Drawing.Point(71, 55);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(578, 20);
            this.txtADRES.TabIndex = 2;
            // 
            // txtYONETICI_REFNO
            // 
            this.txtYONETICI_REFNO.Location = new System.Drawing.Point(168, 245);
            this.txtYONETICI_REFNO.Name = "txtYONETICI_REFNO";
            this.txtYONETICI_REFNO.Size = new System.Drawing.Size(100, 20);
            this.txtYONETICI_REFNO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici Refno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durumu";
            // 
            // txtKULLANICI_ADI
            // 
            this.txtKULLANICI_ADI.Location = new System.Drawing.Point(168, 296);
            this.txtKULLANICI_ADI.Name = "txtKULLANICI_ADI";
            this.txtKULLANICI_ADI.Size = new System.Drawing.Size(100, 20);
            this.txtKULLANICI_ADI.TabIndex = 8;
            // 
            // txtSIFRESI
            // 
            this.txtSIFRESI.Location = new System.Drawing.Point(168, 338);
            this.txtSIFRESI.Name = "txtSIFRESI";
            this.txtSIFRESI.Size = new System.Drawing.Size(100, 20);
            this.txtSIFRESI.TabIndex = 9;
            // 
            // txtDURUMU
            // 
            this.txtDURUMU.Location = new System.Drawing.Point(168, 371);
            this.txtDURUMU.Name = "txtDURUMU";
            this.txtDURUMU.Size = new System.Drawing.Size(100, 20);
            this.txtDURUMU.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDURUMU);
            this.Controls.Add(this.txtSIFRESI);
            this.Controls.Add(this.txtKULLANICI_ADI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYONETICI_REFNO);
            this.Controls.Add(this.txtADRES);
            this.Controls.Add(this.txtSONUC);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSONUC;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox txtYONETICI_REFNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKULLANICI_ADI;
        private System.Windows.Forms.TextBox txtSIFRESI;
        private System.Windows.Forms.TextBox txtDURUMU;
    }
}

