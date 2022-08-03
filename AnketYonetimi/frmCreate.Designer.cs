
namespace AnketYonetimi
{
    partial class frmCreate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOoku = new System.Windows.Forms.Button();
            this.btnCKayit = new System.Windows.Forms.Button();
            this.btnCdegerlendirme = new System.Windows.Forms.Button();
            this.btnCara = new System.Windows.Forms.Button();
            this.btnCekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCankettur = new System.Windows.Forms.ComboBox();
            this.kayitClosebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvcontent = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnOoku);
            this.panel1.Controls.Add(this.btnCKayit);
            this.panel1.Controls.Add(this.btnCdegerlendirme);
            this.panel1.Controls.Add(this.btnCara);
            this.panel1.Controls.Add(this.btnCekle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCankettur);
            this.panel1.Controls.Add(this.kayitClosebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 328);
            this.panel1.TabIndex = 0;
            // 
            // btnOoku
            // 
            this.btnOoku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOoku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOoku.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOoku.ForeColor = System.Drawing.Color.White;
            this.btnOoku.Location = new System.Drawing.Point(240, 194);
            this.btnOoku.Name = "btnOoku";
            this.btnOoku.Size = new System.Drawing.Size(227, 88);
            this.btnOoku.TabIndex = 23;
            this.btnOoku.Text = "Anket Oku";
            this.btnOoku.UseVisualStyleBackColor = false;
            this.btnOoku.Click += new System.EventHandler(this.btnOoku_Click);
            // 
            // btnCKayit
            // 
            this.btnCKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCKayit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCKayit.ForeColor = System.Drawing.Color.White;
            this.btnCKayit.Location = new System.Drawing.Point(477, 58);
            this.btnCKayit.Name = "btnCKayit";
            this.btnCKayit.Size = new System.Drawing.Size(227, 88);
            this.btnCKayit.TabIndex = 20;
            this.btnCKayit.Text = "Kayıt İşlemleri";
            this.btnCKayit.UseVisualStyleBackColor = false;
            this.btnCKayit.Click += new System.EventHandler(this.btnCKayit_Click);
            // 
            // btnCdegerlendirme
            // 
            this.btnCdegerlendirme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCdegerlendirme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCdegerlendirme.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCdegerlendirme.ForeColor = System.Drawing.Color.White;
            this.btnCdegerlendirme.Location = new System.Drawing.Point(477, 194);
            this.btnCdegerlendirme.Name = "btnCdegerlendirme";
            this.btnCdegerlendirme.Size = new System.Drawing.Size(227, 88);
            this.btnCdegerlendirme.TabIndex = 20;
            this.btnCdegerlendirme.Text = "Değerlendirme";
            this.btnCdegerlendirme.UseVisualStyleBackColor = false;
            this.btnCdegerlendirme.Click += new System.EventHandler(this.btnCekle_Click);
            // 
            // btnCara
            // 
            this.btnCara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCara.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCara.ForeColor = System.Drawing.Color.White;
            this.btnCara.Location = new System.Drawing.Point(3, 58);
            this.btnCara.Name = "btnCara";
            this.btnCara.Size = new System.Drawing.Size(227, 88);
            this.btnCara.TabIndex = 20;
            this.btnCara.Text = "Anket Listele";
            this.btnCara.UseVisualStyleBackColor = false;
            this.btnCara.Click += new System.EventHandler(this.btnCara_Click);
            // 
            // btnCekle
            // 
            this.btnCekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCekle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCekle.ForeColor = System.Drawing.Color.White;
            this.btnCekle.Location = new System.Drawing.Point(240, 58);
            this.btnCekle.Name = "btnCekle";
            this.btnCekle.Size = new System.Drawing.Size(227, 88);
            this.btnCekle.TabIndex = 20;
            this.btnCekle.Text = "Anket Ekle";
            this.btnCekle.UseVisualStyleBackColor = false;
            this.btnCekle.Click += new System.EventHandler(this.btnCekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Anket Türü :";
            // 
            // cbCankettur
            // 
            this.cbCankettur.FormattingEnabled = true;
            this.cbCankettur.Location = new System.Drawing.Point(24, 254);
            this.cbCankettur.Name = "cbCankettur";
            this.cbCankettur.Size = new System.Drawing.Size(169, 28);
            this.cbCankettur.TabIndex = 21;
            // 
            // kayitClosebtn
            // 
            this.kayitClosebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kayitClosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kayitClosebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitClosebtn.ForeColor = System.Drawing.Color.White;
            this.kayitClosebtn.Location = new System.Drawing.Point(752, 12);
            this.kayitClosebtn.Name = "kayitClosebtn";
            this.kayitClosebtn.Size = new System.Drawing.Size(36, 37);
            this.kayitClosebtn.TabIndex = 19;
            this.kayitClosebtn.Text = "X";
            this.kayitClosebtn.UseVisualStyleBackColor = false;
            this.kayitClosebtn.Click += new System.EventHandler(this.kayitClosebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.dgvcontent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 373);
            this.panel2.TabIndex = 1;
            // 
            // dgvcontent
            // 
            this.dgvcontent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcontent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcontent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcontent.Location = new System.Drawing.Point(0, 60);
            this.dgvcontent.Name = "dgvcontent";
            this.dgvcontent.RowHeadersWidth = 51;
            this.dgvcontent.RowTemplate.Height = 29;
            this.dgvcontent.Size = new System.Drawing.Size(800, 313);
            this.dgvcontent.TabIndex = 0;
            this.dgvcontent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcontent_CellDoubleClick);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreate";
            this.Text = "frmCreate";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcontent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCankettur;
        private System.Windows.Forms.Button btnCKayit;
        private System.Windows.Forms.Button btnCara;
        private System.Windows.Forms.Button kayitClosebtn;
        private System.Windows.Forms.DataGridView dgvcontent;
        private System.Windows.Forms.Button btnCdegerlendirme;
        private System.Windows.Forms.Button btnOoku;
    }
}