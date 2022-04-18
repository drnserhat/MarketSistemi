
namespace SatisSitesi
{
    partial class AnaMenu
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
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnNewPass = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridUrun = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrun
            // 
            this.btnUrun.BackgroundImage = global::SatisSitesi.Properties.Resources.orange_button_md;
            this.btnUrun.Location = new System.Drawing.Point(12, 1);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(104, 47);
            this.btnUrun.TabIndex = 0;
            this.btnUrun.Text = "Ürün Kontrol";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackgroundImage = global::SatisSitesi.Properties.Resources.orange_button_md;
            this.btnKategori.Location = new System.Drawing.Point(112, 2);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(104, 47);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnFirma
            // 
            this.btnFirma.BackgroundImage = global::SatisSitesi.Properties.Resources.orange_button_md;
            this.btnFirma.Location = new System.Drawing.Point(213, 3);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(104, 47);
            this.btnFirma.TabIndex = 0;
            this.btnFirma.Text = "Firmalar";
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            // 
            // btnNewPass
            // 
            this.btnNewPass.BackgroundImage = global::SatisSitesi.Properties.Resources.orange_button_md;
            this.btnNewPass.Location = new System.Drawing.Point(314, 3);
            this.btnNewPass.Name = "btnNewPass";
            this.btnNewPass.Size = new System.Drawing.Size(104, 47);
            this.btnNewPass.TabIndex = 0;
            this.btnNewPass.Text = "Şifre Değiştir";
            this.btnNewPass.UseVisualStyleBackColor = true;
            this.btnNewPass.Click += new System.EventHandler(this.btnNewPass_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::SatisSitesi.Properties.Resources.power_on;
            this.btnClose.Location = new System.Drawing.Point(1018, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridUrun
            // 
            this.dataGridUrun.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrun.Location = new System.Drawing.Point(12, 54);
            this.dataGridUrun.Name = "dataGridUrun";
            this.dataGridUrun.RowHeadersWidth = 51;
            this.dataGridUrun.RowTemplate.Height = 29;
            this.dataGridUrun.Size = new System.Drawing.Size(1056, 606);
            this.dataGridUrun.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.SystemColors.Control;
            this.btnYenile.BackgroundImage = global::SatisSitesi.Properties.Resources.refresh;
            this.btnYenile.Location = new System.Drawing.Point(962, -2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(50, 50);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(688, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(212, 27);
            this.txtAra.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.Control;
            this.btnAra.BackgroundImage = global::SatisSitesi.Properties.Resources.search;
            this.btnAra.Location = new System.Drawing.Point(906, -1);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(50, 50);
            this.btnAra.TabIndex = 4;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 670);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridUrun);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewPass);
            this.Controls.Add(this.btnFirma);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnUrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaMenu_FormClosed);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btnNewPass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridUrun;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
    }
}