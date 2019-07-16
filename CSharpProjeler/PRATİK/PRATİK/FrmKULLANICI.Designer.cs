namespace PRATİK
{
    partial class FrmKULLANICI
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
            this.txtKULLANICI_ADI = new System.Windows.Forms.TextBox();
            this.comboDURUMU = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSIFRESI = new System.Windows.Forms.TextBox();
            this.txtKULLANICI_REFNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSON = new System.Windows.Forms.Button();
            this.btnSONRAKI = new System.Windows.Forms.Button();
            this.btnONCEKI = new System.Windows.Forms.Button();
            this.btnILK = new System.Windows.Forms.Button();
            this.btnARAMA = new System.Windows.Forms.Button();
            this.btnSIL = new System.Windows.Forms.Button();
            this.btnVAZGEC = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnYENI = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKULLANICI_ADI);
            this.groupBox1.Controls.Add(this.comboDURUMU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSIFRESI);
            this.groupBox1.Controls.Add(this.txtKULLANICI_REFNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtKULLANICI_ADI
            // 
            this.txtKULLANICI_ADI.Location = new System.Drawing.Point(370, 27);
            this.txtKULLANICI_ADI.Name = "txtKULLANICI_ADI";
            this.txtKULLANICI_ADI.Size = new System.Drawing.Size(100, 20);
            this.txtKULLANICI_ADI.TabIndex = 1;
            this.txtKULLANICI_ADI.TextChanged += new System.EventHandler(this.TxtKULLANICI_ADI_TextChanged);
            // 
            // comboDURUMU
            // 
            this.comboDURUMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDURUMU.FormattingEnabled = true;
            this.comboDURUMU.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboDURUMU.Location = new System.Drawing.Point(370, 64);
            this.comboDURUMU.Name = "comboDURUMU";
            this.comboDURUMU.Size = new System.Drawing.Size(100, 21);
            this.comboDURUMU.TabIndex = 3;
            this.comboDURUMU.SelectedIndexChanged += new System.EventHandler(this.ComboDURUMU_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durumu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // txtSIFRESI
            // 
            this.txtSIFRESI.Location = new System.Drawing.Point(143, 65);
            this.txtSIFRESI.Name = "txtSIFRESI";
            this.txtSIFRESI.Size = new System.Drawing.Size(100, 20);
            this.txtSIFRESI.TabIndex = 2;
            this.txtSIFRESI.TextChanged += new System.EventHandler(this.TxtSIFRESI_TextChanged);
            // 
            // txtKULLANICI_REFNO
            // 
            this.txtKULLANICI_REFNO.Location = new System.Drawing.Point(143, 27);
            this.txtKULLANICI_REFNO.Name = "txtKULLANICI_REFNO";
            this.txtKULLANICI_REFNO.ReadOnly = true;
            this.txtKULLANICI_REFNO.Size = new System.Drawing.Size(100, 20);
            this.txtKULLANICI_REFNO.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı REFNO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 211);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // btnSON
            // 
            this.btnSON.Location = new System.Drawing.Point(353, 195);
            this.btnSON.Name = "btnSON";
            this.btnSON.Size = new System.Drawing.Size(75, 23);
            this.btnSON.TabIndex = 8;
            this.btnSON.Text = ">>";
            this.btnSON.UseVisualStyleBackColor = true;
            this.btnSON.Click += new System.EventHandler(this.Button9_Click);
            // 
            // btnSONRAKI
            // 
            this.btnSONRAKI.Location = new System.Drawing.Point(271, 195);
            this.btnSONRAKI.Name = "btnSONRAKI";
            this.btnSONRAKI.Size = new System.Drawing.Size(75, 23);
            this.btnSONRAKI.TabIndex = 7;
            this.btnSONRAKI.Text = ">";
            this.btnSONRAKI.UseVisualStyleBackColor = true;
            this.btnSONRAKI.Click += new System.EventHandler(this.Button8_Click);
            // 
            // btnONCEKI
            // 
            this.btnONCEKI.Location = new System.Drawing.Point(189, 195);
            this.btnONCEKI.Name = "btnONCEKI";
            this.btnONCEKI.Size = new System.Drawing.Size(75, 23);
            this.btnONCEKI.TabIndex = 6;
            this.btnONCEKI.Text = "<";
            this.btnONCEKI.UseVisualStyleBackColor = true;
            this.btnONCEKI.Click += new System.EventHandler(this.Button7_Click);
            // 
            // btnILK
            // 
            this.btnILK.Location = new System.Drawing.Point(107, 195);
            this.btnILK.Name = "btnILK";
            this.btnILK.Size = new System.Drawing.Size(75, 23);
            this.btnILK.TabIndex = 5;
            this.btnILK.Text = "<<";
            this.btnILK.UseVisualStyleBackColor = true;
            this.btnILK.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnARAMA
            // 
            this.btnARAMA.Location = new System.Drawing.Point(436, 151);
            this.btnARAMA.Name = "btnARAMA";
            this.btnARAMA.Size = new System.Drawing.Size(75, 23);
            this.btnARAMA.TabIndex = 4;
            this.btnARAMA.Text = "Arama";
            this.btnARAMA.UseVisualStyleBackColor = true;
            this.btnARAMA.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnSIL
            // 
            this.btnSIL.Location = new System.Drawing.Point(333, 151);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(75, 23);
            this.btnSIL.TabIndex = 3;
            this.btnSIL.Text = "Sil";
            this.btnSIL.UseVisualStyleBackColor = true;
            this.btnSIL.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnVAZGEC
            // 
            this.btnVAZGEC.Location = new System.Drawing.Point(230, 151);
            this.btnVAZGEC.Name = "btnVAZGEC";
            this.btnVAZGEC.Size = new System.Drawing.Size(75, 23);
            this.btnVAZGEC.TabIndex = 2;
            this.btnVAZGEC.Text = "Vazgeç";
            this.btnVAZGEC.UseVisualStyleBackColor = true;
            this.btnVAZGEC.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(127, 151);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(75, 23);
            this.btnKAYDET.TabIndex = 1;
            this.btnKAYDET.Text = "Kaydet";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnYENI
            // 
            this.btnYENI.Location = new System.Drawing.Point(24, 151);
            this.btnYENI.Name = "btnYENI";
            this.btnYENI.Size = new System.Drawing.Size(75, 23);
            this.btnYENI.TabIndex = 0;
            this.btnYENI.Text = "Yeni";
            this.btnYENI.UseVisualStyleBackColor = true;
            this.btnYENI.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(397, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yetkilendirme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // FrmKULLANICI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSON);
            this.Controls.Add(this.btnSONRAKI);
            this.Controls.Add(this.btnONCEKI);
            this.Controls.Add(this.btnILK);
            this.Controls.Add(this.btnARAMA);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnVAZGEC);
            this.Controls.Add(this.btnKAYDET);
            this.Controls.Add(this.btnYENI);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKULLANICI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.FrmKULLANICI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSON;
        private System.Windows.Forms.Button btnSONRAKI;
        private System.Windows.Forms.Button btnONCEKI;
        private System.Windows.Forms.Button btnILK;
        private System.Windows.Forms.Button btnARAMA;
        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnVAZGEC;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnYENI;
        private System.Windows.Forms.TextBox txtKULLANICI_ADI;
        private System.Windows.Forms.ComboBox comboDURUMU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSIFRESI;
        private System.Windows.Forms.TextBox txtKULLANICI_REFNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}