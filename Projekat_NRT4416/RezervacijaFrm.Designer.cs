namespace Projekat_NRT4416
{
    partial class RezervacijaFrm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.markaBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.kubikazaBox = new System.Windows.Forms.ComboBox();
            this.godisteBox = new System.Windows.Forms.ComboBox();
            this.karoserijaBox = new System.Windows.Forms.ComboBox();
            this.brojVrataBox = new System.Windows.Forms.ComboBox();
            this.gorivoBox = new System.Windows.Forms.ComboBox();
            this.pogonBox = new System.Windows.Forms.ComboBox();
            this.menjacBox = new System.Windows.Forms.ComboBox();
            this.prikaziTermineBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.datumPreuzimanjaDtp = new System.Windows.Forms.DateTimePicker();
            this.datumVracanjaDtp = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rezervisiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite marku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberite model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite godiste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odaberite kubikazu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Odaberite karoseriju:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Odaberite broj vrata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Odaberite gorivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Odaberite pogon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Odaberite menjac:";
            // 
            // markaBox
            // 
            this.markaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaBox.FormattingEnabled = true;
            this.markaBox.Location = new System.Drawing.Point(25, 33);
            this.markaBox.Name = "markaBox";
            this.markaBox.Size = new System.Drawing.Size(121, 24);
            this.markaBox.TabIndex = 9;
            this.markaBox.SelectedIndexChanged += new System.EventHandler(this.markaBox_SelectedIndexChanged);
            // 
            // modelBox
            // 
            this.modelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(25, 96);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(121, 24);
            this.modelBox.TabIndex = 10;
            this.modelBox.SelectedIndexChanged += new System.EventHandler(this.modelBox_SelectedIndexChanged);
            // 
            // kubikazaBox
            // 
            this.kubikazaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kubikazaBox.FormattingEnabled = true;
            this.kubikazaBox.Location = new System.Drawing.Point(25, 150);
            this.kubikazaBox.Name = "kubikazaBox";
            this.kubikazaBox.Size = new System.Drawing.Size(121, 24);
            this.kubikazaBox.TabIndex = 11;
            this.kubikazaBox.SelectedIndexChanged += new System.EventHandler(this.kubikazaBox_SelectedIndexChanged);
            // 
            // godisteBox
            // 
            this.godisteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.godisteBox.FormattingEnabled = true;
            this.godisteBox.Location = new System.Drawing.Point(182, 33);
            this.godisteBox.Name = "godisteBox";
            this.godisteBox.Size = new System.Drawing.Size(121, 24);
            this.godisteBox.TabIndex = 12;
            this.godisteBox.SelectedIndexChanged += new System.EventHandler(this.godisteBox_SelectedIndexChanged);
            // 
            // karoserijaBox
            // 
            this.karoserijaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.karoserijaBox.FormattingEnabled = true;
            this.karoserijaBox.Location = new System.Drawing.Point(346, 33);
            this.karoserijaBox.Name = "karoserijaBox";
            this.karoserijaBox.Size = new System.Drawing.Size(121, 24);
            this.karoserijaBox.TabIndex = 13;
            this.karoserijaBox.SelectedIndexChanged += new System.EventHandler(this.karoserijaBox_SelectedIndexChanged);
            // 
            // brojVrataBox
            // 
            this.brojVrataBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brojVrataBox.FormattingEnabled = true;
            this.brojVrataBox.Location = new System.Drawing.Point(346, 150);
            this.brojVrataBox.Name = "brojVrataBox";
            this.brojVrataBox.Size = new System.Drawing.Size(121, 24);
            this.brojVrataBox.TabIndex = 14;
            this.brojVrataBox.SelectedIndexChanged += new System.EventHandler(this.brojVrataBox_SelectedIndexChanged);
            // 
            // gorivoBox
            // 
            this.gorivoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gorivoBox.FormattingEnabled = true;
            this.gorivoBox.Location = new System.Drawing.Point(347, 92);
            this.gorivoBox.Name = "gorivoBox";
            this.gorivoBox.Size = new System.Drawing.Size(121, 24);
            this.gorivoBox.TabIndex = 15;
            this.gorivoBox.SelectedIndexChanged += new System.EventHandler(this.gorivoBox_SelectedIndexChanged);
            // 
            // pogonBox
            // 
            this.pogonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pogonBox.FormattingEnabled = true;
            this.pogonBox.Location = new System.Drawing.Point(182, 96);
            this.pogonBox.Name = "pogonBox";
            this.pogonBox.Size = new System.Drawing.Size(121, 24);
            this.pogonBox.TabIndex = 16;
            this.pogonBox.SelectedIndexChanged += new System.EventHandler(this.pogonBox_SelectedIndexChanged);
            // 
            // menjacBox
            // 
            this.menjacBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menjacBox.FormattingEnabled = true;
            this.menjacBox.Location = new System.Drawing.Point(182, 150);
            this.menjacBox.Name = "menjacBox";
            this.menjacBox.Size = new System.Drawing.Size(121, 24);
            this.menjacBox.TabIndex = 17;
            this.menjacBox.SelectedIndexChanged += new System.EventHandler(this.menjacBox_SelectedIndexChanged);
            // 
            // prikaziTermineBtn
            // 
            this.prikaziTermineBtn.Location = new System.Drawing.Point(130, 189);
            this.prikaziTermineBtn.Name = "prikaziTermineBtn";
            this.prikaziTermineBtn.Size = new System.Drawing.Size(258, 33);
            this.prikaziTermineBtn.TabIndex = 18;
            this.prikaziTermineBtn.Text = "Prikazi dostupne termine automobila";
            this.prikaziTermineBtn.UseVisualStyleBackColor = true;
            this.prikaziTermineBtn.Click += new System.EventHandler(this.prikaziTermineBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(461, 134);
            this.textBox1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Datum preuzimanja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Datum vracanja:";
            // 
            // datumPreuzimanjaDtp
            // 
            this.datumPreuzimanjaDtp.Location = new System.Drawing.Point(277, 384);
            this.datumPreuzimanjaDtp.Name = "datumPreuzimanjaDtp";
            this.datumPreuzimanjaDtp.Size = new System.Drawing.Size(200, 22);
            this.datumPreuzimanjaDtp.TabIndex = 22;
            // 
            // datumVracanjaDtp
            // 
            this.datumVracanjaDtp.Location = new System.Drawing.Point(277, 416);
            this.datumVracanjaDtp.Name = "datumVracanjaDtp";
            this.datumVracanjaDtp.Size = new System.Drawing.Size(200, 22);
            this.datumVracanjaDtp.TabIndex = 23;
            this.datumVracanjaDtp.ValueChanged += new System.EventHandler(this.datumVracanjaDtp_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ukupna cena rezervacije:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 454);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 25;
            // 
            // rezervisiBtn
            // 
            this.rezervisiBtn.Location = new System.Drawing.Point(157, 492);
            this.rezervisiBtn.Name = "rezervisiBtn";
            this.rezervisiBtn.Size = new System.Drawing.Size(203, 34);
            this.rezervisiBtn.TabIndex = 26;
            this.rezervisiBtn.Text = "Rezervisi";
            this.rezervisiBtn.UseVisualStyleBackColor = true;
            this.rezervisiBtn.Click += new System.EventHandler(this.rezervisiBtn_Click);
            // 
            // RezervacijaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 538);
            this.Controls.Add(this.rezervisiBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.datumVracanjaDtp);
            this.Controls.Add(this.datumPreuzimanjaDtp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.prikaziTermineBtn);
            this.Controls.Add(this.menjacBox);
            this.Controls.Add(this.pogonBox);
            this.Controls.Add(this.gorivoBox);
            this.Controls.Add(this.brojVrataBox);
            this.Controls.Add(this.karoserijaBox);
            this.Controls.Add(this.godisteBox);
            this.Controls.Add(this.kubikazaBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.markaBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RezervacijaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija";
            this.Load += new System.EventHandler(this.RezervacijaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox markaBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.ComboBox kubikazaBox;
        private System.Windows.Forms.ComboBox godisteBox;
        private System.Windows.Forms.ComboBox karoserijaBox;
        private System.Windows.Forms.ComboBox brojVrataBox;
        private System.Windows.Forms.ComboBox gorivoBox;
        private System.Windows.Forms.ComboBox pogonBox;
        private System.Windows.Forms.ComboBox menjacBox;
        private System.Windows.Forms.Button prikaziTermineBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datumPreuzimanjaDtp;
        private System.Windows.Forms.DateTimePicker datumVracanjaDtp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button rezervisiBtn;
    }
}