namespace CalisanAylikUcretHesaplama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.adresTxt = new System.Windows.Forms.TextBox();
            this.yasTxt = new System.Windows.Forms.TextBox();
            this.mesaiSaatiTxt = new System.Windows.Forms.TextBox();
            this.unvanTxt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "yaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "unvan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "mesai saati";
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(173, 29);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(128, 22);
            this.adSoyadTxt.TabIndex = 5;
            // 
            // adresTxt
            // 
            this.adresTxt.Location = new System.Drawing.Point(173, 72);
            this.adresTxt.Name = "adresTxt";
            this.adresTxt.Size = new System.Drawing.Size(128, 22);
            this.adresTxt.TabIndex = 6;
            // 
            // yasTxt
            // 
            this.yasTxt.Location = new System.Drawing.Point(173, 117);
            this.yasTxt.Name = "yasTxt";
            this.yasTxt.Size = new System.Drawing.Size(128, 22);
            this.yasTxt.TabIndex = 7;
            // 
            // mesaiSaatiTxt
            // 
            this.mesaiSaatiTxt.Location = new System.Drawing.Point(173, 210);
            this.mesaiSaatiTxt.Name = "mesaiSaatiTxt";
            this.mesaiSaatiTxt.Size = new System.Drawing.Size(128, 22);
            this.mesaiSaatiTxt.TabIndex = 8;
            // 
            // unvanTxt
            // 
            this.unvanTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unvanTxt.FormattingEnabled = true;
            this.unvanTxt.Items.AddRange(new object[] {
            "Mühendis",
            "İşçi"});
            this.unvanTxt.Location = new System.Drawing.Point(173, 166);
            this.unvanTxt.Name = "unvanTxt";
            this.unvanTxt.Size = new System.Drawing.Size(128, 24);
            this.unvanTxt.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "personel oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unvanTxt);
            this.Controls.Add(this.mesaiSaatiTxt);
            this.Controls.Add(this.yasTxt);
            this.Controls.Add(this.adresTxt);
            this.Controls.Add(this.adSoyadTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.TextBox adresTxt;
        private System.Windows.Forms.TextBox yasTxt;
        private System.Windows.Forms.TextBox mesaiSaatiTxt;
        private System.Windows.Forms.ComboBox unvanTxt;
        private System.Windows.Forms.Button button1;
    }
}

