namespace STATE_PrepaidKartica
{
    partial class PrepaidForm
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
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznosUplate = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIsplati = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIznosIsplate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serijski broj:";
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Enabled = false;
            this.txtSerijskiBroj.Location = new System.Drawing.Point(18, 42);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(158, 20);
            this.txtSerijskiBroj.TabIndex = 1;
            // 
            // txtIznos
            // 
            this.txtIznos.Enabled = false;
            this.txtIznos.Location = new System.Drawing.Point(18, 81);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(158, 20);
            this.txtIznos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos:";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(18, 120);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(158, 20);
            this.txtStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAktiviraj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtSerijskiBroj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIznos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci kartice";
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.Location = new System.Drawing.Point(57, 146);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(119, 23);
            this.btnAktiviraj.TabIndex = 6;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = true;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUplati);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIznosUplate);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uplata sredstava na karticu:";
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(182, 43);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 7;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.btnUplati_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Iznos uplate:";
            // 
            // txtIznosUplate
            // 
            this.txtIznosUplate.Location = new System.Drawing.Point(18, 43);
            this.txtIznosUplate.Name = "txtIznosUplate";
            this.txtIznosUplate.Size = new System.Drawing.Size(158, 20);
            this.txtIznosUplate.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIsplati);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtIznosIsplate);
            this.groupBox3.Location = new System.Drawing.Point(217, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 89);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Isplate sredstava sa kartice:";
            // 
            // btnIsplati
            // 
            this.btnIsplati.Location = new System.Drawing.Point(182, 41);
            this.btnIsplati.Name = "btnIsplati";
            this.btnIsplati.Size = new System.Drawing.Size(75, 23);
            this.btnIsplati.TabIndex = 10;
            this.btnIsplati.Text = "Isplati";
            this.btnIsplati.UseVisualStyleBackColor = true;
            this.btnIsplati.Click += new System.EventHandler(this.btnIsplati_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iznos isplate:";
            // 
            // txtIznosIsplate
            // 
            this.txtIznosIsplate.Location = new System.Drawing.Point(18, 41);
            this.txtIznosIsplate.Name = "txtIznosIsplate";
            this.txtIznosIsplate.Size = new System.Drawing.Size(158, 20);
            this.txtIznosIsplate.TabIndex = 9;
            // 
            // PrepaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 222);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrepaidForm";
            this.Text = "Prepaid kartica";
            this.Load += new System.EventHandler(this.PrepaidForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznosUplate;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIsplati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIznosIsplate;
    }
}

