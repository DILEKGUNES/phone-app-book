namespace TelefonDefteriUygulaması
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
            groupBox1 = new GroupBox();
            txtSoyad = new TextBox();
            txtTelefon = new MaskedTextBox();
            txtEposta = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            btnResimEkleDegisitr = new Button();
            picResim = new PictureBox();
            toolStrip1 = new ToolStrip();
            btnEkle = new ToolStripButton();
            btnKAydet = new ToolStripButton();
            btnSil = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnTemizle = new ToolStripButton();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            listKisiler = new ListBox();
            statusStrip1 = new StatusStrip();
            lblAdet = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResim).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtEposta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnResimEkleDegisitr);
            groupBox1.Controls.Add(picResim);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(95, 130);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(143, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(96, 163);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(142, 27);
            txtTelefon.TabIndex = 5;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(96, 196);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(142, 27);
            txtEposta.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 199);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "E-posta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 133);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 166);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(96, 97);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(142, 27);
            txtAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 100);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // btnResimEkleDegisitr
            // 
            btnResimEkleDegisitr.Location = new Point(244, 195);
            btnResimEkleDegisitr.Name = "btnResimEkleDegisitr";
            btnResimEkleDegisitr.Size = new Size(125, 29);
            btnResimEkleDegisitr.TabIndex = 2;
            btnResimEkleDegisitr.Text = "Ekle / Değiştir";
            btnResimEkleDegisitr.UseVisualStyleBackColor = true;
            btnResimEkleDegisitr.Click += btnResimEkleDegisitr_Click;
            // 
            // picResim
            // 
            picResim.BorderStyle = BorderStyle.FixedSingle;
            picResim.Image = Properties.Resources.user1;
            picResim.InitialImage = Properties.Resources.user1;
            picResim.Location = new Point(244, 97);
            picResim.Name = "picResim";
            picResim.Size = new Size(125, 93);
            picResim.SizeMode = PictureBoxSizeMode.Zoom;
            picResim.TabIndex = 1;
            picResim.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEkle, btnKAydet, btnSil, toolStripSeparator1, btnTemizle });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(372, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnEkle
            // 
            btnEkle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEkle.Image = Properties.Resources.Ekle;
            btnEkle.ImageTransparentColor = Color.Magenta;
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(29, 24);
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKAydet
            // 
            btnKAydet.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnKAydet.Image = Properties.Resources.Kaydet;
            btnKAydet.ImageTransparentColor = Color.Magenta;
            btnKAydet.Name = "btnKAydet";
            btnKAydet.Size = new Size(29, 24);
            btnKAydet.Text = "Kaydet";
            btnKAydet.Click += btnKAydet_Click;
            // 
            // btnSil
            // 
            btnSil.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSil.Image = Properties.Resources.Sil;
            btnSil.ImageTransparentColor = Color.Magenta;
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(29, 24);
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnTemizle
            // 
            btnTemizle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnTemizle.Image = Properties.Resources.Temizle;
            btnTemizle.ImageTransparentColor = Color.Magenta;
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(29, 24);
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(378, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 303);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listKisiler);
            groupBox2.Controls.Add(statusStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(388, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 303);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kişiler";
            // 
            // listKisiler
            // 
            listKisiler.Dock = DockStyle.Fill;
            listKisiler.FormattingEnabled = true;
            listKisiler.ItemHeight = 20;
            listKisiler.Location = new Point(3, 23);
            listKisiler.Name = "listKisiler";
            listKisiler.Size = new Size(406, 251);
            listKisiler.TabIndex = 1;
            listKisiler.SelectedIndexChanged += listKisiler_SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblAdet });
            statusStrip1.Location = new Point(3, 274);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(406, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblAdet
            // 
            lblAdet.Name = "lblAdet";
            lblAdet.Size = new Size(27, 20);
            lblAdet.Text = "......";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 303);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Telefon Defteri Uygulaması";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picResim).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEposta;
        private TextBox textBox2;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox txtAd;
        private Label label1;
        private Button btnResimEkleDegisitr;
        private PictureBox picResim;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private GroupBox groupBox2;
        private ListBox listKisiler;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblAdet;
        private MaskedTextBox txtTelefon;
        private ToolStripButton btnEkle;
        private ToolStripButton btnKAydet;
        private ToolStripButton btnSil;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnTemizle;
        private TextBox txtSoyad;
    }
}