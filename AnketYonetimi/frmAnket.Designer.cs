
namespace AnketYonetimi
{
    partial class frmAnket
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
            this.FpnlAnket = new System.Windows.Forms.FlowLayoutPanel();
            this.AClosebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FpnlAnket
            // 
            this.FpnlAnket.AutoScroll = true;
            this.FpnlAnket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FpnlAnket.Location = new System.Drawing.Point(0, 189);
            this.FpnlAnket.Name = "FpnlAnket";
            this.FpnlAnket.Size = new System.Drawing.Size(871, 612);
            this.FpnlAnket.TabIndex = 0;
            // 
            // AClosebtn
            // 
            this.AClosebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AClosebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AClosebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AClosebtn.ForeColor = System.Drawing.Color.White;
            this.AClosebtn.Location = new System.Drawing.Point(794, 12);
            this.AClosebtn.Name = "AClosebtn";
            this.AClosebtn.Size = new System.Drawing.Size(56, 37);
            this.AClosebtn.TabIndex = 4;
            this.AClosebtn.Text = "X";
            this.AClosebtn.UseVisualStyleBackColor = false;
            this.AClosebtn.Click += new System.EventHandler(this.AClosebtn_Click);
            // 
            // frmAnket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 801);
            this.Controls.Add(this.AClosebtn);
            this.Controls.Add(this.FpnlAnket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnket";
            this.Text = "frmAnket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FpnlAnket;
        private System.Windows.Forms.Button AClosebtn;
    }
}