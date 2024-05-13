namespace KYS
{
    partial class EmployeersInterface
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
            this.tbn = new System.Windows.Forms.TextBox();
            this.tbs = new System.Windows.Forms.TextBox();
            this.tbj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbjup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbsalup = new System.Windows.Forms.TextBox();
            this.dgwEmployeers = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.rnw = new System.Windows.Forms.Button();
            this.dlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployeers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbn
            // 
            this.tbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbn.Location = new System.Drawing.Point(110, 458);
            this.tbn.Name = "tbn";
            this.tbn.Size = new System.Drawing.Size(198, 22);
            this.tbn.TabIndex = 0;
            // 
            // tbs
            // 
            this.tbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbs.Location = new System.Drawing.Point(110, 486);
            this.tbs.Name = "tbs";
            this.tbs.Size = new System.Drawing.Size(198, 22);
            this.tbs.TabIndex = 1;
            // 
            // tbj
            // 
            this.tbj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbj.Location = new System.Drawing.Point(110, 519);
            this.tbj.Name = "tbj";
            this.tbj.Size = new System.Drawing.Size(198, 22);
            this.tbj.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "İş";
            // 
            // tbsal
            // 
            this.tbsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsal.Location = new System.Drawing.Point(110, 550);
            this.tbsal.Name = "tbsal";
            this.tbsal.Size = new System.Drawing.Size(198, 22);
            this.tbsal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maaş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(453, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "İş";
            // 
            // tbjup
            // 
            this.tbjup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbjup.Location = new System.Drawing.Point(523, 482);
            this.tbjup.Name = "tbjup";
            this.tbjup.Size = new System.Drawing.Size(198, 22);
            this.tbjup.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(453, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Maaş";
            // 
            // tbsalup
            // 
            this.tbsalup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsalup.Location = new System.Drawing.Point(523, 519);
            this.tbsalup.Name = "tbsalup";
            this.tbsalup.Size = new System.Drawing.Size(198, 22);
            this.tbsalup.TabIndex = 10;
            // 
            // dgwEmployeers
            // 
            this.dgwEmployeers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwEmployeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployeers.GridColor = System.Drawing.SystemColors.Window;
            this.dgwEmployeers.Location = new System.Drawing.Point(18, 49);
            this.dgwEmployeers.Name = "dgwEmployeers";
            this.dgwEmployeers.RowHeadersWidth = 51;
            this.dgwEmployeers.RowTemplate.Height = 24;
            this.dgwEmployeers.Size = new System.Drawing.Size(1007, 309);
            this.dgwEmployeers.TabIndex = 16;
            this.dgwEmployeers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployeers_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Employeers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(106, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Add Employeers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(520, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Update Employeers";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add.Location = new System.Drawing.Point(111, 596);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 53);
            this.add.TabIndex = 20;
            this.add.Text = "Ekle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // upd
            // 
            this.upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.upd.Location = new System.Drawing.Point(523, 596);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(134, 53);
            this.upd.TabIndex = 21;
            this.upd.Text = "Güncelle";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // rnw
            // 
            this.rnw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rnw.Location = new System.Drawing.Point(891, 364);
            this.rnw.Name = "rnw";
            this.rnw.Size = new System.Drawing.Size(134, 53);
            this.rnw.TabIndex = 22;
            this.rnw.Text = "Yenile";
            this.rnw.UseVisualStyleBackColor = true;
            this.rnw.Click += new System.EventHandler(this.rnw_Click);
            // 
            // dlt
            // 
            this.dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dlt.Location = new System.Drawing.Point(891, 596);
            this.dlt.Name = "dlt";
            this.dlt.Size = new System.Drawing.Size(134, 53);
            this.dlt.TabIndex = 23;
            this.dlt.Text = "Sil";
            this.dlt.UseVisualStyleBackColor = true;
            this.dlt.Click += new System.EventHandler(this.dlt_Click);
            // 
            // EmployeersInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dlt);
            this.Controls.Add(this.rnw);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgwEmployeers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbjup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbsalup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbj);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbn);
            this.Name = "EmployeersInterface";
            this.Size = new System.Drawing.Size(1041, 689);
            this.Load += new System.EventHandler(this.EmployeersInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployeers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbn;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.TextBox tbj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbjup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbsalup;
        private System.Windows.Forms.DataGridView dgwEmployeers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button rnw;
        private System.Windows.Forms.Button dlt;
    }
}
