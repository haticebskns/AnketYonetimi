
namespace AnketYonetimi
{
    partial class frmAnketOlusturma
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
            this.kayitClosebtn = new System.Windows.Forms.Button();
            this.Fpnlolusturma = new System.Windows.Forms.FlowLayoutPanel();
            this.cbOOsorutur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOsoru = new System.Windows.Forms.Button();
            this.grbxOsoru = new System.Windows.Forms.GroupBox();
            this.btnOremove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxOsıklar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOsık = new System.Windows.Forms.TextBox();
            this.rtxtAsoru = new System.Windows.Forms.RichTextBox();
            this.btnOsık = new System.Windows.Forms.Button();
            this.txtAnketAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOolustur = new System.Windows.Forms.Button();
            this.cbOankettur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOsure = new System.Windows.Forms.TextBox();
            this.grbxOsoru.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitClosebtn
            // 
            this.kayitClosebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kayitClosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitClosebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitClosebtn.ForeColor = System.Drawing.Color.White;
            this.kayitClosebtn.Location = new System.Drawing.Point(752, 17);
            this.kayitClosebtn.Name = "kayitClosebtn";
            this.kayitClosebtn.Size = new System.Drawing.Size(36, 48);
            this.kayitClosebtn.TabIndex = 20;
            this.kayitClosebtn.Text = "X";
            this.kayitClosebtn.UseVisualStyleBackColor = false;
            this.kayitClosebtn.Click += new System.EventHandler(this.kayitClosebtn_Click);
            // 
            // Fpnlolusturma
            // 
            this.Fpnlolusturma.AutoScroll = true;
            this.Fpnlolusturma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Fpnlolusturma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Fpnlolusturma.Location = new System.Drawing.Point(0, 486);
            this.Fpnlolusturma.Name = "Fpnlolusturma";
            this.Fpnlolusturma.Size = new System.Drawing.Size(800, 308);
            this.Fpnlolusturma.TabIndex = 21;
            // 
            // cbOOsorutur
            // 
            this.cbOOsorutur.FormattingEnabled = true;
            this.cbOOsorutur.Location = new System.Drawing.Point(120, 148);
            this.cbOOsorutur.Name = "cbOOsorutur";
            this.cbOOsorutur.Size = new System.Drawing.Size(250, 28);
            this.cbOOsorutur.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Soru Türü";
            // 
            // btnOsoru
            // 
            this.btnOsoru.BackColor = System.Drawing.Color.Fuchsia;
            this.btnOsoru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsoru.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOsoru.ForeColor = System.Drawing.Color.White;
            this.btnOsoru.Location = new System.Drawing.Point(643, 31);
            this.btnOsoru.Name = "btnOsoru";
            this.btnOsoru.Size = new System.Drawing.Size(151, 57);
            this.btnOsoru.TabIndex = 26;
            this.btnOsoru.Text = "Soru Ekle";
            this.btnOsoru.UseVisualStyleBackColor = false;
            this.btnOsoru.Click += new System.EventHandler(this.btnOsoru_Click);
            // 
            // grbxOsoru
            // 
            this.grbxOsoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbxOsoru.Controls.Add(this.btnOremove);
            this.grbxOsoru.Controls.Add(this.button1);
            this.grbxOsoru.Controls.Add(this.lbxOsıklar);
            this.grbxOsoru.Controls.Add(this.label4);
            this.grbxOsoru.Controls.Add(this.txtOsık);
            this.grbxOsoru.Controls.Add(this.rtxtAsoru);
            this.grbxOsoru.Controls.Add(this.btnOsık);
            this.grbxOsoru.Controls.Add(this.btnOsoru);
            this.grbxOsoru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbxOsoru.Location = new System.Drawing.Point(0, 204);
            this.grbxOsoru.Name = "grbxOsoru";
            this.grbxOsoru.Size = new System.Drawing.Size(800, 263);
            this.grbxOsoru.TabIndex = 27;
            this.grbxOsoru.TabStop = false;
            this.grbxOsoru.Text = "Soru :";
            // 
            // btnOremove
            // 
            this.btnOremove.BackColor = System.Drawing.Color.Fuchsia;
            this.btnOremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOremove.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOremove.ForeColor = System.Drawing.Color.White;
            this.btnOremove.Location = new System.Drawing.Point(415, 200);
            this.btnOremove.Name = "btnOremove";
            this.btnOremove.Size = new System.Drawing.Size(151, 56);
            this.btnOremove.TabIndex = 28;
            this.btnOremove.Text = "Şıkkı Sil";
            this.btnOremove.UseVisualStyleBackColor = false;
            this.btnOremove.Click += new System.EventHandler(this.btnOremove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // lbxOsıklar
            // 
            this.lbxOsıklar.FormattingEnabled = true;
            this.lbxOsıklar.ItemHeight = 25;
            this.lbxOsıklar.Location = new System.Drawing.Point(643, 118);
            this.lbxOsıklar.Name = "lbxOsıklar";
            this.lbxOsıklar.Size = new System.Drawing.Size(133, 104);
            this.lbxOsıklar.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şıklar:";
            // 
            // txtOsık
            // 
            this.txtOsık.Location = new System.Drawing.Point(12, 225);
            this.txtOsık.Name = "txtOsık";
            this.txtOsık.Size = new System.Drawing.Size(189, 32);
            this.txtOsık.TabIndex = 1;
            // 
            // rtxtAsoru
            // 
            this.rtxtAsoru.Location = new System.Drawing.Point(24, 26);
            this.rtxtAsoru.Name = "rtxtAsoru";
            this.rtxtAsoru.Size = new System.Drawing.Size(607, 168);
            this.rtxtAsoru.TabIndex = 0;
            this.rtxtAsoru.Text = "";
            // 
            // btnOsık
            // 
            this.btnOsık.BackColor = System.Drawing.Color.Fuchsia;
            this.btnOsık.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsık.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOsık.ForeColor = System.Drawing.Color.White;
            this.btnOsık.Location = new System.Drawing.Point(239, 200);
            this.btnOsık.Name = "btnOsık";
            this.btnOsık.Size = new System.Drawing.Size(151, 57);
            this.btnOsık.TabIndex = 26;
            this.btnOsık.Text = "Şık Ekle";
            this.btnOsık.UseVisualStyleBackColor = false;
            this.btnOsık.Click += new System.EventHandler(this.btnOsık_Click);
            // 
            // txtAnketAdi
            // 
            this.txtAnketAdi.Location = new System.Drawing.Point(182, 61);
            this.txtAnketAdi.Name = "txtAnketAdi";
            this.txtAnketAdi.Size = new System.Drawing.Size(173, 27);
            this.txtAnketAdi.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(182, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Anket Adı : ";
            // 
            // btnOolustur
            // 
            this.btnOolustur.BackColor = System.Drawing.Color.Fuchsia;
            this.btnOolustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOolustur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOolustur.ForeColor = System.Drawing.Color.White;
            this.btnOolustur.Location = new System.Drawing.Point(543, 21);
            this.btnOolustur.Name = "btnOolustur";
            this.btnOolustur.Size = new System.Drawing.Size(151, 66);
            this.btnOolustur.TabIndex = 26;
            this.btnOolustur.Text = "Anket Oluştur";
            this.btnOolustur.UseVisualStyleBackColor = false;
            this.btnOolustur.Click += new System.EventHandler(this.btnOolustur_Click);
            // 
            // cbOankettur
            // 
            this.cbOankettur.FormattingEnabled = true;
            this.cbOankettur.Location = new System.Drawing.Point(12, 60);
            this.cbOankettur.Name = "cbOankettur";
            this.cbOankettur.Size = new System.Drawing.Size(151, 28);
            this.cbOankettur.TabIndex = 30;
            this.cbOankettur.SelectedIndexChanged += new System.EventHandler(this.cbOankettur_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Anket Türü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(361, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Yayınlanma Süresi:";
            // 
            // txtOsure
            // 
            this.txtOsure.Location = new System.Drawing.Point(361, 60);
            this.txtOsure.Name = "txtOsure";
            this.txtOsure.Size = new System.Drawing.Size(105, 27);
            this.txtOsure.TabIndex = 33;
            // 
            // frmAnketOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 794);
            this.Controls.Add(this.txtOsure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOankettur);
            this.Controls.Add(this.cbOOsorutur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnketAdi);
            this.Controls.Add(this.grbxOsoru);
            this.Controls.Add(this.btnOolustur);
            this.Controls.Add(this.Fpnlolusturma);
            this.Controls.Add(this.kayitClosebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnketOlusturma";
            this.Text = "frmAnketOlusturma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnketOlusturma_Load);
            this.grbxOsoru.ResumeLayout(false);
            this.grbxOsoru.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitClosebtn;
        private System.Windows.Forms.FlowLayoutPanel Fpnlolusturma;
        private System.Windows.Forms.ComboBox cbOOsorutur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOsoru;
        private System.Windows.Forms.GroupBox grbxOsoru;
        private System.Windows.Forms.TextBox txtAnketAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOsık;
        private System.Windows.Forms.RichTextBox rtxtAsoru;
        private System.Windows.Forms.Button btnOolustur;
        private System.Windows.Forms.Button btnOsık;
        private System.Windows.Forms.ComboBox cbOankettur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOsure;
        private System.Windows.Forms.ListBox lbxOsıklar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOremove;
    }
}