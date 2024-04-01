namespace Emlak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DogrulamaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GizliGosterchc = new System.Windows.Forms.CheckBox();
            this.DogrulamaKodu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KullaniciAdiTxt
            // 
            this.KullaniciAdiTxt.Location = new System.Drawing.Point(347, 134);
            this.KullaniciAdiTxt.Name = "KullaniciAdiTxt";
            this.KullaniciAdiTxt.Size = new System.Drawing.Size(114, 20);
            this.KullaniciAdiTxt.TabIndex = 0;
            // 
            // SifreTxt
            // 
            this.SifreTxt.Location = new System.Drawing.Point(347, 176);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(114, 20);
            this.SifreTxt.TabIndex = 1;
            // 
            // GirisBtn
            // 
            this.GirisBtn.Location = new System.Drawing.Point(347, 263);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(102, 58);
            this.GirisBtn.TabIndex = 2;
            this.GirisBtn.Text = "GİRİŞ";
            this.GirisBtn.UseVisualStyleBackColor = true;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(140, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE :";
            // 
            // DogrulamaTxt
            // 
            this.DogrulamaTxt.Location = new System.Drawing.Point(347, 212);
            this.DogrulamaTxt.Name = "DogrulamaTxt";
            this.DogrulamaTxt.Size = new System.Drawing.Size(114, 20);
            this.DogrulamaTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOĞRULAMA KODU : ";
            // 
            // GizliGosterchc
            // 
            this.GizliGosterchc.AutoSize = true;
            this.GizliGosterchc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GizliGosterchc.Location = new System.Drawing.Point(481, 178);
            this.GizliGosterchc.Name = "GizliGosterchc";
            this.GizliGosterchc.Size = new System.Drawing.Size(106, 22);
            this.GizliGosterchc.TabIndex = 7;
            this.GizliGosterchc.Text = "Gizli\\Göster";
            this.GizliGosterchc.UseVisualStyleBackColor = true;
            this.GizliGosterchc.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DogrulamaKodu
            // 
            this.DogrulamaKodu.AutoSize = true;
            this.DogrulamaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogrulamaKodu.Location = new System.Drawing.Point(478, 217);
            this.DogrulamaKodu.Name = "DogrulamaKodu";
            this.DogrulamaKodu.Size = new System.Drawing.Size(0, 20);
            this.DogrulamaKodu.TabIndex = 8;
            this.DogrulamaKodu.Click += new System.EventHandler(this.DogrulamaLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emlak.Properties.Resources.emlak1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.DogrulamaKodu);
            this.Controls.Add(this.GizliGosterchc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DogrulamaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.KullaniciAdiTxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GİRİŞ EKRANI ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KullaniciAdiTxt;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DogrulamaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox GizliGosterchc;
        private System.Windows.Forms.Label DogrulamaKodu;
    }
}

