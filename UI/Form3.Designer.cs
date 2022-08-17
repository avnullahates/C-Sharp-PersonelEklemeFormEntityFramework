
namespace UI
{
    partial class Form3
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
            this.lblPerosnelBilgiler = new System.Windows.Forms.Label();
            this.grpPersonel = new System.Windows.Forms.GroupBox();
            this.btnTemizleBilgiler = new System.Windows.Forms.Button();
            this.grpPersonelBul = new System.Windows.Forms.GroupBox();
            this.btnTemizleBul = new System.Windows.Forms.Button();
            this.lbxPersoneller = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbAranacak = new System.Windows.Forms.ComboBox();
            this.txtAranacakMetin = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpPersonel.SuspendLayout();
            this.grpPersonelBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerosnelBilgiler
            // 
            this.lblPerosnelBilgiler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerosnelBilgiler.Location = new System.Drawing.Point(6, 20);
            this.lblPerosnelBilgiler.Name = "lblPerosnelBilgiler";
            this.lblPerosnelBilgiler.Size = new System.Drawing.Size(368, 246);
            this.lblPerosnelBilgiler.TabIndex = 0;
            // 
            // grpPersonel
            // 
            this.grpPersonel.Controls.Add(this.btnTemizleBilgiler);
            this.grpPersonel.Controls.Add(this.lblPerosnelBilgiler);
            this.grpPersonel.Location = new System.Drawing.Point(12, 42);
            this.grpPersonel.Name = "grpPersonel";
            this.grpPersonel.Size = new System.Drawing.Size(380, 315);
            this.grpPersonel.TabIndex = 3;
            this.grpPersonel.TabStop = false;
            this.grpPersonel.Text = "Personel Bilgiler";
            // 
            // btnTemizleBilgiler
            // 
            this.btnTemizleBilgiler.Location = new System.Drawing.Point(128, 269);
            this.btnTemizleBilgiler.Name = "btnTemizleBilgiler";
            this.btnTemizleBilgiler.Size = new System.Drawing.Size(105, 40);
            this.btnTemizleBilgiler.TabIndex = 1;
            this.btnTemizleBilgiler.Text = "TEMIZLE";
            this.btnTemizleBilgiler.UseVisualStyleBackColor = true;
            this.btnTemizleBilgiler.Click += new System.EventHandler(this.btnTemizleBilgiler_Click);
            // 
            // grpPersonelBul
            // 
            this.grpPersonelBul.Controls.Add(this.btnTemizleBul);
            this.grpPersonelBul.Controls.Add(this.lbxPersoneller);
            this.grpPersonelBul.Controls.Add(this.btnAra);
            this.grpPersonelBul.Controls.Add(this.cmbAranacak);
            this.grpPersonelBul.Controls.Add(this.txtAranacakMetin);
            this.grpPersonelBul.Location = new System.Drawing.Point(408, 42);
            this.grpPersonelBul.Name = "grpPersonelBul";
            this.grpPersonelBul.Size = new System.Drawing.Size(380, 315);
            this.grpPersonelBul.TabIndex = 4;
            this.grpPersonelBul.TabStop = false;
            this.grpPersonelBul.Text = "Personel Bul";
            // 
            // btnTemizleBul
            // 
            this.btnTemizleBul.Location = new System.Drawing.Point(126, 269);
            this.btnTemizleBul.Name = "btnTemizleBul";
            this.btnTemizleBul.Size = new System.Drawing.Size(105, 40);
            this.btnTemizleBul.TabIndex = 2;
            this.btnTemizleBul.Text = "TEMIZLE";
            this.btnTemizleBul.UseVisualStyleBackColor = true;
            this.btnTemizleBul.Click += new System.EventHandler(this.btnTemizleBul_Click);
            // 
            // lbxPersoneller
            // 
            this.lbxPersoneller.FormattingEnabled = true;
            this.lbxPersoneller.Location = new System.Drawing.Point(7, 56);
            this.lbxPersoneller.Name = "lbxPersoneller";
            this.lbxPersoneller.Size = new System.Drawing.Size(367, 212);
            this.lbxPersoneller.TabIndex = 3;
            this.lbxPersoneller.SelectedIndexChanged += new System.EventHandler(this.lbxPersoneller_SelectedIndexChanged);
            this.lbxPersoneller.DoubleClick += new System.EventHandler(this.lbxPersoneller_DoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(269, 17);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(105, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbAranacak
            // 
            this.cmbAranacak.FormattingEnabled = true;
            this.cmbAranacak.Items.AddRange(new object[] {
            "ile baslayan",
            "iceren",
            "ile biten"});
            this.cmbAranacak.Location = new System.Drawing.Point(126, 20);
            this.cmbAranacak.Name = "cmbAranacak";
            this.cmbAranacak.Size = new System.Drawing.Size(121, 21);
            this.cmbAranacak.TabIndex = 1;
            // 
            // txtAranacakMetin
            // 
            this.txtAranacakMetin.Location = new System.Drawing.Point(7, 20);
            this.txtAranacakMetin.Name = "txtAranacakMetin";
            this.txtAranacakMetin.Size = new System.Drawing.Size(100, 20);
            this.txtAranacakMetin.TabIndex = 0;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(16, 363);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(499, 46);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "ANA MENU";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(683, 369);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 40);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "PERSONEL SIL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.grpPersonel);
            this.Controls.Add(this.grpPersonelBul);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpPersonel.ResumeLayout(false);
            this.grpPersonelBul.ResumeLayout(false);
            this.grpPersonelBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPerosnelBilgiler;
        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.Button btnTemizleBilgiler;
        private System.Windows.Forms.GroupBox grpPersonelBul;
        private System.Windows.Forms.Button btnTemizleBul;
        private System.Windows.Forms.ListBox lbxPersoneller;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbAranacak;
        private System.Windows.Forms.TextBox txtAranacakMetin;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnSil;
    }
}