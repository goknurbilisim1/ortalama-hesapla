namespace ortalamaHesapla
{
    partial class Form1
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
            this.txtYazili1 = new System.Windows.Forms.TextBox();
            this.lblYazili1 = new System.Windows.Forms.Label();
            this.lblYazili2 = new System.Windows.Forms.Label();
            this.txtYazili2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYazili1
            // 
            this.txtYazili1.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.txtYazili1.Location = new System.Drawing.Point(126, 57);
            this.txtYazili1.Name = "txtYazili1";
            this.txtYazili1.Size = new System.Drawing.Size(100, 21);
            this.txtYazili1.TabIndex = 1;
            // 
            // lblYazili1
            // 
            this.lblYazili1.AutoSize = true;
            this.lblYazili1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili1.Location = new System.Drawing.Point(53, 55);
            this.lblYazili1.Name = "lblYazili1";
            this.lblYazili1.Size = new System.Drawing.Size(67, 18);
            this.lblYazili1.TabIndex = 2;
            this.lblYazili1.Text = "Yazılı 1:";
            // 
            // lblYazili2
            // 
            this.lblYazili2.AutoSize = true;
            this.lblYazili2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazili2.Location = new System.Drawing.Point(53, 86);
            this.lblYazili2.Name = "lblYazili2";
            this.lblYazili2.Size = new System.Drawing.Size(67, 18);
            this.lblYazili2.TabIndex = 3;
            this.lblYazili2.Text = "Yazılı 2:";
            // 
            // txtYazili2
            // 
            this.txtYazili2.Location = new System.Drawing.Point(126, 84);
            this.txtYazili2.Name = "txtYazili2";
            this.txtYazili2.Size = new System.Drawing.Size(100, 20);
            this.txtYazili2.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(126, 111);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 54);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(33, 169);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(87, 20);
            this.lblOrtalama.TabIndex = 6;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Location = new System.Drawing.Point(126, 171);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(336, 244);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYazili2);
            this.Controls.Add(this.lblYazili2);
            this.Controls.Add(this.lblYazili1);
            this.Controls.Add(this.txtYazili1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtYazili1;
        private System.Windows.Forms.Label lblYazili1;
        private System.Windows.Forms.Label lblYazili2;
        private System.Windows.Forms.TextBox txtYazili2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtOrtalama;
    }
}

