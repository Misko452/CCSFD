namespace Filmy_db_ukol
{
    partial class Hlavni
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonZobraz = new System.Windows.Forms.Button();
            this.buttonVypis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.buttonHledej = new System.Windows.Forms.Button();
            this.buttonSpravaZanru = new System.Windows.Forms.Button();
            this.buttonSpravaReziseru = new System.Windows.Forms.Button();
            this.buttonsprava_filmy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(832, 452);
            this.listBox1.TabIndex = 0;
            // 
            // buttonZobraz
            // 
            this.buttonZobraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZobraz.Location = new System.Drawing.Point(8, 86);
            this.buttonZobraz.Name = "buttonZobraz";
            this.buttonZobraz.Size = new System.Drawing.Size(606, 57);
            this.buttonZobraz.TabIndex = 1;
            this.buttonZobraz.Text = "ZOBRAZ FILMY";
            this.buttonZobraz.UseVisualStyleBackColor = true;
            this.buttonZobraz.Click += new System.EventHandler(this.buttonZobraz_Click);
            // 
            // buttonVypis
            // 
            this.buttonVypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVypis.Location = new System.Drawing.Point(620, 87);
            this.buttonVypis.Name = "buttonVypis";
            this.buttonVypis.Size = new System.Drawing.Size(599, 57);
            this.buttonVypis.TabIndex = 2;
            this.buttonVypis.Text = "VYPSAT FILMY (VŠE)";
            this.buttonVypis.UseVisualStyleBackColor = true;
            this.buttonVypis.Click += new System.EventHandler(this.buttonVypis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(846, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Název:";
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazev.Location = new System.Drawing.Point(972, 173);
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(247, 45);
            this.textBoxNazev.TabIndex = 8;
            // 
            // buttonHledej
            // 
            this.buttonHledej.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHledej.Location = new System.Drawing.Point(846, 245);
            this.buttonHledej.Name = "buttonHledej";
            this.buttonHledej.Size = new System.Drawing.Size(373, 57);
            this.buttonHledej.TabIndex = 10;
            this.buttonHledej.Text = "VYHLEDAT FILM";
            this.buttonHledej.UseVisualStyleBackColor = true;
            this.buttonHledej.Click += new System.EventHandler(this.buttonHledej_Click);
            // 
            // buttonSpravaZanru
            // 
            this.buttonSpravaZanru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpravaZanru.Location = new System.Drawing.Point(942, 423);
            this.buttonSpravaZanru.Name = "buttonSpravaZanru";
            this.buttonSpravaZanru.Size = new System.Drawing.Size(181, 48);
            this.buttonSpravaZanru.TabIndex = 11;
            this.buttonSpravaZanru.Text = "SPRÁVA ŽÁNRŮ";
            this.buttonSpravaZanru.UseVisualStyleBackColor = true;
            this.buttonSpravaZanru.Click += new System.EventHandler(this.buttonSpravaZanru_Click);
            // 
            // buttonSpravaReziseru
            // 
            this.buttonSpravaReziseru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpravaReziseru.Location = new System.Drawing.Point(942, 477);
            this.buttonSpravaReziseru.Name = "buttonSpravaReziseru";
            this.buttonSpravaReziseru.Size = new System.Drawing.Size(181, 48);
            this.buttonSpravaReziseru.TabIndex = 12;
            this.buttonSpravaReziseru.Text = "SPRÁVA REŽISÉRŮ";
            this.buttonSpravaReziseru.UseVisualStyleBackColor = true;
            this.buttonSpravaReziseru.Click += new System.EventHandler(this.buttonSpravaReziseru_Click);
            // 
            // buttonsprava_filmy
            // 
            this.buttonsprava_filmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonsprava_filmy.Location = new System.Drawing.Point(942, 369);
            this.buttonsprava_filmy.Name = "buttonsprava_filmy";
            this.buttonsprava_filmy.Size = new System.Drawing.Size(181, 48);
            this.buttonsprava_filmy.TabIndex = 13;
            this.buttonsprava_filmy.Text = "SPRÁVA FILMŮ";
            this.buttonsprava_filmy.UseVisualStyleBackColor = true;
            this.buttonsprava_filmy.Click += new System.EventHandler(this.buttonsprava_filmy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, -19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 99);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Filmy_db_ukol.Properties.Resources.bitmapa;
            this.pictureBox1.Location = new System.Drawing.Point(1140, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Hlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 634);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonsprava_filmy);
            this.Controls.Add(this.buttonSpravaReziseru);
            this.Controls.Add(this.buttonSpravaZanru);
            this.Controls.Add(this.buttonHledej);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.buttonVypis);
            this.Controls.Add(this.buttonZobraz);
            this.Controls.Add(this.listBox1);
            this.Name = "Hlavni";
            this.Text = "CČSFD (Copka Česká Filmová Databáze) - Filmy";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonZobraz;
        private System.Windows.Forms.Button buttonVypis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.Button buttonHledej;
        private System.Windows.Forms.Button buttonSpravaZanru;
        private System.Windows.Forms.Button buttonSpravaReziseru;
        private System.Windows.Forms.Button buttonsprava_filmy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

