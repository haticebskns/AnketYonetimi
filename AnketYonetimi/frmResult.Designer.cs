
namespace AnketYonetimi
{
    partial class frmResult
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
            this.btnRclose = new System.Windows.Forms.Button();
            this.cbRanket = new System.Windows.Forms.ComboBox();
            this.btnRsonuc = new System.Windows.Forms.Button();
            this.btnRkatilimci = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRclose
            // 
            this.btnRclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRclose.ForeColor = System.Drawing.Color.White;
            this.btnRclose.Location = new System.Drawing.Point(903, 36);
            this.btnRclose.Name = "btnRclose";
            this.btnRclose.Size = new System.Drawing.Size(40, 55);
            this.btnRclose.TabIndex = 20;
            this.btnRclose.Text = "X";
            this.btnRclose.UseVisualStyleBackColor = false;
            this.btnRclose.Click += new System.EventHandler(this.btnRclose_Click);
            // 
            // cbRanket
            // 
            this.cbRanket.FormattingEnabled = true;
            this.cbRanket.Location = new System.Drawing.Point(28, 82);
            this.cbRanket.Name = "cbRanket";
            this.cbRanket.Size = new System.Drawing.Size(169, 31);
            this.cbRanket.TabIndex = 21;
            this.cbRanket.SelectedValueChanged += new System.EventHandler(this.cbRanket_SelectedValueChanged);
            // 
            // btnRsonuc
            // 
            this.btnRsonuc.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRsonuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRsonuc.ForeColor = System.Drawing.Color.White;
            this.btnRsonuc.Location = new System.Drawing.Point(205, 18);
            this.btnRsonuc.Name = "btnRsonuc";
            this.btnRsonuc.Size = new System.Drawing.Size(192, 95);
            this.btnRsonuc.TabIndex = 22;
            this.btnRsonuc.Text = "Anket Sonuclarını Göster";
            this.btnRsonuc.UseVisualStyleBackColor = false;
            this.btnRsonuc.Click += new System.EventHandler(this.btnRsonuc_Click);
            // 
            // btnRkatilimci
            // 
            this.btnRkatilimci.BackColor = System.Drawing.Color.Fuchsia;
            this.btnRkatilimci.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRkatilimci.ForeColor = System.Drawing.Color.White;
            this.btnRkatilimci.Location = new System.Drawing.Point(403, 18);
            this.btnRkatilimci.Name = "btnRkatilimci";
            this.btnRkatilimci.Size = new System.Drawing.Size(192, 95);
            this.btnRkatilimci.TabIndex = 23;
            this.btnRkatilimci.Text = "Katılımcıları Göster";
            this.btnRkatilimci.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(980, 188);
            this.dataGridView1.TabIndex = 24;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRkatilimci);
            this.Controls.Add(this.btnRsonuc);
            this.Controls.Add(this.cbRanket);
            this.Controls.Add(this.btnRclose);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResult";
            this.Text = "frmResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRclose;
        private System.Windows.Forms.ComboBox cbRanket;
        private System.Windows.Forms.Button btnRsonuc;
        private System.Windows.Forms.Button btnRkatilimci;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}