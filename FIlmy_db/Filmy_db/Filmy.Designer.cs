namespace Filmy_db_ukol
{
    partial class Filmy
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxrziseri = new System.Windows.Forms.ComboBox();
            this.comboBoxZanr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDelka = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxPopis = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonodstran = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownupravadelky = new System.Windows.Forms.NumericUpDown();
            this.comboBoxupravzanr = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxreziseruprava = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxupravnazev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxupravpopis = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonUprav = new System.Windows.Forms.Button();
            this.buttonPridej = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownupravadelky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Režisér:";
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxJmeno.Location = new System.Drawing.Point(21, 245);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(314, 45);
            this.textBoxJmeno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Název:";
            // 
            // comboBoxrziseri
            // 
            this.comboBoxrziseri.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxrziseri.FormattingEnabled = true;
            this.comboBoxrziseri.Location = new System.Drawing.Point(21, 358);
            this.comboBoxrziseri.Name = "comboBoxrziseri";
            this.comboBoxrziseri.Size = new System.Drawing.Size(314, 46);
            this.comboBoxrziseri.TabIndex = 8;
            // 
            // comboBoxZanr
            // 
            this.comboBoxZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxZanr.FormattingEnabled = true;
            this.comboBoxZanr.Location = new System.Drawing.Point(21, 588);
            this.comboBoxZanr.Name = "comboBoxZanr";
            this.comboBoxZanr.Size = new System.Drawing.Size(314, 46);
            this.comboBoxZanr.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Žánr:";
            // 
            // numericUpDownDelka
            // 
            this.numericUpDownDelka.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownDelka.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDelka.Location = new System.Drawing.Point(21, 476);
            this.numericUpDownDelka.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownDelka.Name = "numericUpDownDelka";
            this.numericUpDownDelka.Size = new System.Drawing.Size(314, 45);
            this.numericUpDownDelka.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Délka (v min):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(372, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Popis:";
            // 
            // richTextBoxPopis
            // 
            this.richTextBoxPopis.Location = new System.Drawing.Point(379, 245);
            this.richTextBoxPopis.Name = "richTextBoxPopis";
            this.richTextBoxPopis.Size = new System.Drawing.Size(331, 276);
            this.richTextBoxPopis.TabIndex = 14;
            this.richTextBoxPopis.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(741, 197);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 324);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // buttonodstran
            // 
            this.buttonodstran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonodstran.Location = new System.Drawing.Point(798, 552);
            this.buttonodstran.Name = "buttonodstran";
            this.buttonodstran.Size = new System.Drawing.Size(206, 82);
            this.buttonodstran.TabIndex = 18;
            this.buttonodstran.Text = "ODSTRANIT FILM";
            this.buttonodstran.UseVisualStyleBackColor = true;
            this.buttonodstran.Click += new System.EventHandler(this.buttonodstran_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1087, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 38);
            this.label6.TabIndex = 26;
            this.label6.Text = "Délka (v min):";
            // 
            // numericUpDownupravadelky
            // 
            this.numericUpDownupravadelky.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownupravadelky.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownupravadelky.Location = new System.Drawing.Point(1094, 476);
            this.numericUpDownupravadelky.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownupravadelky.Name = "numericUpDownupravadelky";
            this.numericUpDownupravadelky.Size = new System.Drawing.Size(314, 45);
            this.numericUpDownupravadelky.TabIndex = 25;
            // 
            // comboBoxupravzanr
            // 
            this.comboBoxupravzanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxupravzanr.FormattingEnabled = true;
            this.comboBoxupravzanr.Location = new System.Drawing.Point(1094, 588);
            this.comboBoxupravzanr.Name = "comboBoxupravzanr";
            this.comboBoxupravzanr.Size = new System.Drawing.Size(314, 46);
            this.comboBoxupravzanr.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1087, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 38);
            this.label7.TabIndex = 23;
            this.label7.Text = "Žánr:";
            // 
            // comboBoxreziseruprava
            // 
            this.comboBoxreziseruprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxreziseruprava.FormattingEnabled = true;
            this.comboBoxreziseruprava.Location = new System.Drawing.Point(1094, 358);
            this.comboBoxreziseruprava.Name = "comboBoxreziseruprava";
            this.comboBoxreziseruprava.Size = new System.Drawing.Size(314, 46);
            this.comboBoxreziseruprava.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1087, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 38);
            this.label8.TabIndex = 21;
            this.label8.Text = "Režisér:";
            // 
            // textBoxupravnazev
            // 
            this.textBoxupravnazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxupravnazev.Location = new System.Drawing.Point(1094, 245);
            this.textBoxupravnazev.Name = "textBoxupravnazev";
            this.textBoxupravnazev.Size = new System.Drawing.Size(314, 45);
            this.textBoxupravnazev.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1087, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 38);
            this.label9.TabIndex = 19;
            this.label9.Text = "Název:";
            // 
            // richTextBoxupravpopis
            // 
            this.richTextBoxupravpopis.Location = new System.Drawing.Point(1455, 245);
            this.richTextBoxupravpopis.Name = "richTextBoxupravpopis";
            this.richTextBoxupravpopis.Size = new System.Drawing.Size(331, 276);
            this.richTextBoxupravpopis.TabIndex = 28;
            this.richTextBoxupravpopis.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1448, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 38);
            this.label10.TabIndex = 27;
            this.label10.Text = "Popis:";
            // 
            // buttonUprav
            // 
            this.buttonUprav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUprav.Location = new System.Drawing.Point(1514, 552);
            this.buttonUprav.Name = "buttonUprav";
            this.buttonUprav.Size = new System.Drawing.Size(206, 82);
            this.buttonUprav.TabIndex = 29;
            this.buttonUprav.Text = "UPRAVIT FILM";
            this.buttonUprav.UseVisualStyleBackColor = true;
            this.buttonUprav.Click += new System.EventHandler(this.buttonUprav_Click);
            // 
            // buttonPridej
            // 
            this.buttonPridej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridej.Location = new System.Drawing.Point(442, 552);
            this.buttonPridej.Name = "buttonPridej";
            this.buttonPridej.Size = new System.Drawing.Size(208, 82);
            this.buttonPridej.TabIndex = 30;
            this.buttonPridej.Text = "PŘIDAT FILM";
            this.buttonPridej.UseVisualStyleBackColor = true;
            this.buttonPridej.Click += new System.EventHandler(this.buttonPridej_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1357, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 39);
            this.label11.TabIndex = 33;
            this.label11.Text = "Upravit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(819, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 39);
            this.label12.TabIndex = 32;
            this.label12.Text = "Odstranit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(266, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 39);
            this.label13.TabIndex = 31;
            this.label13.Text = "Přidat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Filmy_db_ukol.Properties.Resources.bitmapa;
            this.pictureBox1.Location = new System.Drawing.Point(1717, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, -18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1809, 104);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // Filmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonPridej);
            this.Controls.Add(this.buttonUprav);
            this.Controls.Add(this.richTextBoxupravpopis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownupravadelky);
            this.Controls.Add(this.comboBoxupravzanr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxreziseruprava);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxupravnazev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonodstran);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBoxPopis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDelka);
            this.Controls.Add(this.comboBoxZanr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxrziseri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.label1);
            this.Name = "Filmy";
            this.Text = "CČSFD (Copka Česká Filmová Databáze) - Správa filmů";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownupravadelky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxrziseri;
        private System.Windows.Forms.ComboBox comboBoxZanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDelka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxPopis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonodstran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownupravadelky;
        private System.Windows.Forms.ComboBox comboBoxupravzanr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxreziseruprava;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxupravnazev;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxupravpopis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonUprav;
        private System.Windows.Forms.Button buttonPridej;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}