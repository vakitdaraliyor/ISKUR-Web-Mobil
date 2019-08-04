namespace KUTUPHANE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKITAP_REFNO = new System.Windows.Forms.TextBox();
            this.txtADI = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYAZARI = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtYAYIN_EVI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOZET = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçKitapİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerilenKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alınanVerilenKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlınanKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtKITAP_REFNO
            // 
            resources.ApplyResources(this.txtKITAP_REFNO, "txtKITAP_REFNO");
            this.txtKITAP_REFNO.Name = "txtKITAP_REFNO";
            this.txtKITAP_REFNO.ReadOnly = true;
            // 
            // txtADI
            // 
            resources.ApplyResources(this.txtADI, "txtADI");
            this.txtADI.Name = "txtADI";
            // 
            // txtISBN
            // 
            resources.ApplyResources(this.txtISBN, "txtISBN");
            this.txtISBN.Name = "txtISBN";
            // 
            // txtYAZARI
            // 
            resources.ApplyResources(this.txtYAZARI, "txtYAZARI");
            this.txtYAZARI.Name = "txtYAZARI";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // txtYAYIN_EVI
            // 
            resources.ApplyResources(this.txtYAYIN_EVI, "txtYAYIN_EVI");
            this.txtYAYIN_EVI.Name = "txtYAYIN_EVI";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtOZET
            // 
            resources.ApplyResources(this.txtOZET, "txtOZET");
            this.txtOZET.Name = "txtOZET";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemlerToolStripMenuItem,
            this.üyeİşlemlerToolStripMenuItem,
            this.ödünçKitapİşlemlerToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            resources.ApplyResources(this.işlemlerToolStripMenuItem, "işlemlerToolStripMenuItem");
            // 
            // kitapİşlemlerToolStripMenuItem
            // 
            this.kitapİşlemlerToolStripMenuItem.Name = "kitapİşlemlerToolStripMenuItem";
            resources.ApplyResources(this.kitapİşlemlerToolStripMenuItem, "kitapİşlemlerToolStripMenuItem");
            this.kitapİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.KitapİşlemlerToolStripMenuItem_Click);
            // 
            // üyeİşlemlerToolStripMenuItem
            // 
            this.üyeİşlemlerToolStripMenuItem.Name = "üyeİşlemlerToolStripMenuItem";
            resources.ApplyResources(this.üyeİşlemlerToolStripMenuItem, "üyeİşlemlerToolStripMenuItem");
            this.üyeİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.ÜyeİşlemlerToolStripMenuItem_Click);
            // 
            // ödünçKitapİşlemlerToolStripMenuItem
            // 
            this.ödünçKitapİşlemlerToolStripMenuItem.Name = "ödünçKitapİşlemlerToolStripMenuItem";
            resources.ApplyResources(this.ödünçKitapİşlemlerToolStripMenuItem, "ödünçKitapİşlemlerToolStripMenuItem");
            this.ödünçKitapİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.ÖdünçKitapİşlemlerToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiToolStripMenuItem,
            this.üyeListesiRaporuToolStripMenuItem,
            this.ödünçVerilenKitaplarToolStripMenuItem,
            this.alınanVerilenKitaplarToolStripMenuItem,
            this.geriAlınanKitaplarToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            resources.ApplyResources(this.raporlarToolStripMenuItem, "raporlarToolStripMenuItem");
            // 
            // kitapListesiToolStripMenuItem
            // 
            this.kitapListesiToolStripMenuItem.Name = "kitapListesiToolStripMenuItem";
            resources.ApplyResources(this.kitapListesiToolStripMenuItem, "kitapListesiToolStripMenuItem");
            this.kitapListesiToolStripMenuItem.Click += new System.EventHandler(this.KitapListesiToolStripMenuItem_Click);
            // 
            // üyeListesiRaporuToolStripMenuItem
            // 
            this.üyeListesiRaporuToolStripMenuItem.Name = "üyeListesiRaporuToolStripMenuItem";
            resources.ApplyResources(this.üyeListesiRaporuToolStripMenuItem, "üyeListesiRaporuToolStripMenuItem");
            this.üyeListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.ÜyeListesiRaporuToolStripMenuItem_Click);
            // 
            // ödünçVerilenKitaplarToolStripMenuItem
            // 
            this.ödünçVerilenKitaplarToolStripMenuItem.Name = "ödünçVerilenKitaplarToolStripMenuItem";
            resources.ApplyResources(this.ödünçVerilenKitaplarToolStripMenuItem, "ödünçVerilenKitaplarToolStripMenuItem");
            // 
            // alınanVerilenKitaplarToolStripMenuItem
            // 
            this.alınanVerilenKitaplarToolStripMenuItem.Name = "alınanVerilenKitaplarToolStripMenuItem";
            resources.ApplyResources(this.alınanVerilenKitaplarToolStripMenuItem, "alınanVerilenKitaplarToolStripMenuItem");
            // 
            // geriAlınanKitaplarToolStripMenuItem
            // 
            this.geriAlınanKitaplarToolStripMenuItem.Name = "geriAlınanKitaplarToolStripMenuItem";
            resources.ApplyResources(this.geriAlınanKitaplarToolStripMenuItem, "geriAlınanKitaplarToolStripMenuItem");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOZET);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYAYIN_EVI);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtYAZARI);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtADI);
            this.Controls.Add(this.txtKITAP_REFNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKITAP_REFNO;
        private System.Windows.Forms.TextBox txtADI;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYAZARI;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtYAYIN_EVI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOZET;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçKitapİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçVerilenKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alınanVerilenKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlınanKitaplarToolStripMenuItem;
    }
}

