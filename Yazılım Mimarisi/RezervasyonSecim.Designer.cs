namespace Yazılım_Mimarisi
{
    partial class RezervasyonSecim
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
            this.btn_Otobus_Cadir = new System.Windows.Forms.Button();
            this.btn_Otobus_Otel = new System.Windows.Forms.Button();
            this.btn_Ucak_Cadir = new System.Windows.Forms.Button();
            this.btn_Ucak_Otel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Türünüzü Seçiniz:";
            // 
            // btn_Otobus_Cadir
            // 
            this.btn_Otobus_Cadir.Location = new System.Drawing.Point(256, 347);
            this.btn_Otobus_Cadir.Name = "btn_Otobus_Cadir";
            this.btn_Otobus_Cadir.Size = new System.Drawing.Size(205, 126);
            this.btn_Otobus_Cadir.TabIndex = 1;
            this.btn_Otobus_Cadir.Text = "OTOBÜS - ÇADIR";
            this.btn_Otobus_Cadir.UseVisualStyleBackColor = true;
            this.btn_Otobus_Cadir.Click += new System.EventHandler(this.btn_Otobus_Cadir_Click);
            // 
            // btn_Otobus_Otel
            // 
            this.btn_Otobus_Otel.Location = new System.Drawing.Point(476, 345);
            this.btn_Otobus_Otel.Name = "btn_Otobus_Otel";
            this.btn_Otobus_Otel.Size = new System.Drawing.Size(205, 126);
            this.btn_Otobus_Otel.TabIndex = 2;
            this.btn_Otobus_Otel.Text = "OTOBÜS - OTEL";
            this.btn_Otobus_Otel.UseVisualStyleBackColor = true;
            this.btn_Otobus_Otel.Click += new System.EventHandler(this.btn_Otobus_Otel_Click);
            // 
            // btn_Ucak_Cadir
            // 
            this.btn_Ucak_Cadir.Location = new System.Drawing.Point(34, 345);
            this.btn_Ucak_Cadir.Name = "btn_Ucak_Cadir";
            this.btn_Ucak_Cadir.Size = new System.Drawing.Size(205, 128);
            this.btn_Ucak_Cadir.TabIndex = 3;
            this.btn_Ucak_Cadir.Text = "UÇAK - ÇADIR";
            this.btn_Ucak_Cadir.UseVisualStyleBackColor = true;
            this.btn_Ucak_Cadir.Click += new System.EventHandler(this.btn_Ucak_Cadir_Click);
            // 
            // btn_Ucak_Otel
            // 
            this.btn_Ucak_Otel.Location = new System.Drawing.Point(696, 345);
            this.btn_Ucak_Otel.Name = "btn_Ucak_Otel";
            this.btn_Ucak_Otel.Size = new System.Drawing.Size(214, 124);
            this.btn_Ucak_Otel.TabIndex = 4;
            this.btn_Ucak_Otel.Text = "UÇAK - OTEL";
            this.btn_Ucak_Otel.UseVisualStyleBackColor = true;
            this.btn_Ucak_Otel.Click += new System.EventHandler(this.btn_Ucak_Otel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gitmek İstediğiniz Yeri Seçiniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Antalya",
            "Balıkesir",
            "Mersin"});
            this.comboBox1.Location = new System.Drawing.Point(583, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 39);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "TC Kimlik Numaranız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik Numaranız:";
            // 
            // RezervasyonSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Ucak_Otel);
            this.Controls.Add(this.btn_Ucak_Cadir);
            this.Controls.Add(this.btn_Otobus_Otel);
            this.Controls.Add(this.btn_Otobus_Cadir);
            this.Controls.Add(this.label1);
            this.Name = "RezervasyonSecim";
            this.Text = "RezervasyonSecim";
            this.Load += new System.EventHandler(this.RezervasyonSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Otobus_Cadir;
        private System.Windows.Forms.Button btn_Otobus_Otel;
        private System.Windows.Forms.Button btn_Ucak_Cadir;
        private System.Windows.Forms.Button btn_Ucak_Otel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}