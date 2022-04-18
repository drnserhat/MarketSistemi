
namespace SatisSitesi
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtKul = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImage = global::SatisSitesi.Properties.Resources.AA;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGiris.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.Maroon;
            this.btnGiris.Location = new System.Drawing.Point(527, 400);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(6);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(246, 77);
            this.btnGiris.TabIndex = 26;
            this.btnGiris.Text = " G I R I S";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Khaki;
            this.txtPass.Location = new System.Drawing.Point(527, 283);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(246, 44);
            this.txtPass.TabIndex = 24;
            this.txtPass.Text = "Parola";
            this.txtPass.MouseHover += new System.EventHandler(this.txtPass_MouseHover);
            // 
            // txtKul
            // 
            this.txtKul.BackColor = System.Drawing.Color.Khaki;
            this.txtKul.Location = new System.Drawing.Point(527, 227);
            this.txtKul.Margin = new System.Windows.Forms.Padding(6);
            this.txtKul.Name = "txtKul";
            this.txtKul.Size = new System.Drawing.Size(246, 44);
            this.txtKul.TabIndex = 25;
            this.txtKul.Text = "Kullanıcı Adı";
            this.txtKul.MouseHover += new System.EventHandler(this.txtKul_MouseHover);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl12.Location = new System.Drawing.Point(527, 355);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(0, 39);
            this.lbl12.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SatisSitesi.Properties.Resources.giris_ekrani;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtKul);
            this.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtKul;
        private System.Windows.Forms.Label lbl12;
    }
}

