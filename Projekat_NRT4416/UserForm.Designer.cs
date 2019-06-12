namespace Projekat_NRT4416
{
    partial class UserForm
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
            this.trenutneRezBox = new System.Windows.Forms.ComboBox();
            this.obrisiRezBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodosli, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trenutne rezervacije:";
            // 
            // trenutneRezBox
            // 
            this.trenutneRezBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trenutneRezBox.FormattingEnabled = true;
            this.trenutneRezBox.Location = new System.Drawing.Point(161, 51);
            this.trenutneRezBox.Name = "trenutneRezBox";
            this.trenutneRezBox.Size = new System.Drawing.Size(276, 24);
            this.trenutneRezBox.TabIndex = 2;
            this.trenutneRezBox.SelectedIndexChanged += new System.EventHandler(this.trenutneRezBox_SelectedIndexChanged);
            this.trenutneRezBox.SelectedValueChanged += new System.EventHandler(this.trenutneRezBox_SelectedValueChanged);
            // 
            // obrisiRezBtn
            // 
            this.obrisiRezBtn.Location = new System.Drawing.Point(17, 185);
            this.obrisiRezBtn.Name = "obrisiRezBtn";
            this.obrisiRezBtn.Size = new System.Drawing.Size(150, 33);
            this.obrisiRezBtn.TabIndex = 3;
            this.obrisiRezBtn.Text = "Obrisi rezervaciju";
            this.obrisiRezBtn.UseVisualStyleBackColor = true;
            this.obrisiRezBtn.Click += new System.EventHandler(this.obrisiRezBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Nova rezervacija";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(420, 76);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.obrisiRezBtn);
            this.Controls.Add(this.trenutneRezBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trenutneRezBox;
        private System.Windows.Forms.Button obrisiRezBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}