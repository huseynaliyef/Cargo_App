namespace Carco_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.ceki_box = new System.Windows.Forms.TextBox();
            this.qiymet_box = new System.Windows.Forms.TextBox();
            this.Ceki = new System.Windows.Forms.Label();
            this.Qiymet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.malin_qiymeti_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Lime;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Turkey",
            "England",
            "China"});
            this.comboBox.Location = new System.Drawing.Point(127, 94);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // ceki_box
            // 
            this.ceki_box.Location = new System.Drawing.Point(345, 214);
            this.ceki_box.Name = "ceki_box";
            this.ceki_box.Size = new System.Drawing.Size(120, 23);
            this.ceki_box.TabIndex = 1;
            // 
            // qiymet_box
            // 
            this.qiymet_box.Enabled = false;
            this.qiymet_box.Location = new System.Drawing.Point(344, 287);
            this.qiymet_box.Name = "qiymet_box";
            this.qiymet_box.Size = new System.Drawing.Size(120, 23);
            this.qiymet_box.TabIndex = 4;
            // 
            // Ceki
            // 
            this.Ceki.AutoSize = true;
            this.Ceki.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ceki.Location = new System.Drawing.Point(285, 212);
            this.Ceki.Name = "Ceki";
            this.Ceki.Size = new System.Drawing.Size(54, 25);
            this.Ceki.TabIndex = 5;
            this.Ceki.Text = "Ceki:";
            // 
            // Qiymet
            // 
            this.Qiymet.AutoSize = true;
            this.Qiymet.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Qiymet.Location = new System.Drawing.Point(202, 284);
            this.Qiymet.Name = "Qiymet";
            this.Qiymet.Size = new System.Drawing.Size(136, 25);
            this.Qiymet.TabIndex = 6;
            this.Qiymet.Text = "Yekun Qiymet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Olke Secin:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sulu Mehsul",
            "Quru Mehsul"});
            this.comboBox2.Location = new System.Drawing.Point(592, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mehsulun Novun Secin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "HUSEYN CARGO SERVICE";
            // 
            // button_hesapla
            // 
            this.button_hesapla.Location = new System.Drawing.Point(498, 286);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(75, 23);
            this.button_hesapla.TabIndex = 11;
            this.button_hesapla.Text = "Hesapla";
            this.button_hesapla.UseVisualStyleBackColor = true;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(206, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Malin Qiymet:";
            // 
            // malin_qiymeti_box
            // 
            this.malin_qiymeti_box.Location = new System.Drawing.Point(345, 253);
            this.malin_qiymeti_box.Name = "malin_qiymeti_box";
            this.malin_qiymeti_box.Size = new System.Drawing.Size(119, 23);
            this.malin_qiymeti_box.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Qramla / 1000q = 1Kq";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(254, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.malin_qiymeti_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Qiymet);
            this.Controls.Add(this.Ceki);
            this.Controls.Add(this.qiymet_box);
            this.Controls.Add(this.ceki_box);
            this.Controls.Add(this.comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox;
        private TextBox ceki_box;
        private TextBox qiymet_box;
        private Label Ceki;
        private Label Qiymet;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Button button_hesapla;
        private Label label4;
        private TextBox malin_qiymeti_box;
        private Label label5;
        private PictureBox pictureBox1;
    }
}