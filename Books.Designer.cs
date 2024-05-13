namespace KYS
{
    partial class Books
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.btsrc = new System.Windows.Forms.Button();
            this.tbd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsi = new System.Windows.Forms.TextBox();
            this.tbi = new System.Windows.Forms.TextBox();
            this.dltbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.renew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.GridColor = System.Drawing.SystemColors.Window;
            this.dgwCustomers.Location = new System.Drawing.Point(36, 39);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.RowHeadersWidth = 51;
            this.dgwCustomers.RowTemplate.Height = 24;
            this.dgwCustomers.Size = new System.Drawing.Size(863, 298);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellClick);
            // 
            // btsrc
            // 
            this.btsrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btsrc.Location = new System.Drawing.Point(121, 512);
            this.btsrc.Name = "btsrc";
            this.btsrc.Size = new System.Drawing.Size(129, 54);
            this.btsrc.TabIndex = 5;
            this.btsrc.Text = "Update";
            this.btsrc.UseVisualStyleBackColor = true;
            this.btsrc.Click += new System.EventHandler(this.btsrc_Click);
            // 
            // tbd
            // 
            this.tbd.Location = new System.Drawing.Point(121, 459);
            this.tbd.Name = "tbd";
            this.tbd.Size = new System.Drawing.Size(157, 22);
            this.tbd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // tbsi
            // 
            this.tbsi.Location = new System.Drawing.Point(121, 407);
            this.tbsi.Name = "tbsi";
            this.tbsi.Size = new System.Drawing.Size(157, 22);
            this.tbsi.TabIndex = 3;
            // 
            // tbi
            // 
            this.tbi.Location = new System.Drawing.Point(121, 358);
            this.tbi.Name = "tbi";
            this.tbi.Size = new System.Drawing.Size(157, 22);
            this.tbi.TabIndex = 4;
            // 
            // dltbtn
            // 
            this.dltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dltbtn.Location = new System.Drawing.Point(781, 479);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(129, 54);
            this.dltbtn.TabIndex = 8;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = true;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Randevu Tablosu";
            // 
            // renew
            // 
            this.renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renew.Location = new System.Drawing.Point(781, 343);
            this.renew.Name = "renew";
            this.renew.Size = new System.Drawing.Size(118, 55);
            this.renew.TabIndex = 10;
            this.renew.Text = "Yenile";
            this.renew.UseVisualStyleBackColor = true;
            this.renew.Click += new System.EventHandler(this.renew_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.renew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.btsrc);
            this.Controls.Add(this.tbi);
            this.Controls.Add(this.tbsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCustomers);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(931, 595);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Button btsrc;
        private System.Windows.Forms.TextBox tbd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbsi;
        private System.Windows.Forms.TextBox tbi;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button renew;
    }
}
