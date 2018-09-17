namespace MyMovies
{
    partial class frmDodaj
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
            this.frm_Dodaj_nazwa = new System.Windows.Forms.TextBox();
            this.frm_Dodaj_rezyser = new System.Windows.Forms.TextBox();
            this.frm_Dodaj_gatunek = new System.Windows.Forms.TextBox();
            this.frm_Dodaj_obejrzany = new System.Windows.Forms.CheckBox();
            this.frm_Dodaj_ocena = new System.Windows.Forms.ComboBox();
            this.frm_Dodaj_lokalizacja = new System.Windows.Forms.TextBox();
            this.frm_Dodaj_btn_dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frm_Dodaj_nazwa
            // 
            this.frm_Dodaj_nazwa.Location = new System.Drawing.Point(14, 25);
            this.frm_Dodaj_nazwa.Name = "frm_Dodaj_nazwa";
            this.frm_Dodaj_nazwa.Size = new System.Drawing.Size(269, 20);
            this.frm_Dodaj_nazwa.TabIndex = 0;
            this.frm_Dodaj_nazwa.Text = "Tytuł filmu";
            // 
            // frm_Dodaj_rezyser
            // 
            this.frm_Dodaj_rezyser.Location = new System.Drawing.Point(14, 65);
            this.frm_Dodaj_rezyser.Name = "frm_Dodaj_rezyser";
            this.frm_Dodaj_rezyser.Size = new System.Drawing.Size(269, 20);
            this.frm_Dodaj_rezyser.TabIndex = 1;
            this.frm_Dodaj_rezyser.Text = "Reżyser filmu";
            // 
            // frm_Dodaj_gatunek
            // 
            this.frm_Dodaj_gatunek.Location = new System.Drawing.Point(14, 105);
            this.frm_Dodaj_gatunek.Name = "frm_Dodaj_gatunek";
            this.frm_Dodaj_gatunek.Size = new System.Drawing.Size(269, 20);
            this.frm_Dodaj_gatunek.TabIndex = 2;
            this.frm_Dodaj_gatunek.Text = "Gatunek";
            // 
            // frm_Dodaj_obejrzany
            // 
            this.frm_Dodaj_obejrzany.AutoSize = true;
            this.frm_Dodaj_obejrzany.Location = new System.Drawing.Point(14, 144);
            this.frm_Dodaj_obejrzany.Name = "frm_Dodaj_obejrzany";
            this.frm_Dodaj_obejrzany.Size = new System.Drawing.Size(86, 18);
            this.frm_Dodaj_obejrzany.TabIndex = 3;
            this.frm_Dodaj_obejrzany.Text = "Obejrzany";
            this.frm_Dodaj_obejrzany.UseVisualStyleBackColor = true;
            // 
            // frm_Dodaj_ocena
            // 
            this.frm_Dodaj_ocena.FormattingEnabled = true;
            this.frm_Dodaj_ocena.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.frm_Dodaj_ocena.Location = new System.Drawing.Point(143, 142);
            this.frm_Dodaj_ocena.Name = "frm_Dodaj_ocena";
            this.frm_Dodaj_ocena.Size = new System.Drawing.Size(121, 22);
            this.frm_Dodaj_ocena.TabIndex = 4;
            this.frm_Dodaj_ocena.Text = "Ocena";
            // 
            // frm_Dodaj_lokalizacja
            // 
            this.frm_Dodaj_lokalizacja.Location = new System.Drawing.Point(14, 185);
            this.frm_Dodaj_lokalizacja.Name = "frm_Dodaj_lokalizacja";
            this.frm_Dodaj_lokalizacja.Size = new System.Drawing.Size(269, 20);
            this.frm_Dodaj_lokalizacja.TabIndex = 5;
            this.frm_Dodaj_lokalizacja.Text = "Lokalizacja filmu";
            this.frm_Dodaj_lokalizacja.TextChanged += new System.EventHandler(this.frm_Dodaj_lokalizacja_TextChanged);
            // 
            // frm_Dodaj_btn_dodaj
            // 
            this.frm_Dodaj_btn_dodaj.Location = new System.Drawing.Point(143, 226);
            this.frm_Dodaj_btn_dodaj.Name = "frm_Dodaj_btn_dodaj";
            this.frm_Dodaj_btn_dodaj.Size = new System.Drawing.Size(121, 23);
            this.frm_Dodaj_btn_dodaj.TabIndex = 6;
            this.frm_Dodaj_btn_dodaj.Text = "Dodaj film";
            this.frm_Dodaj_btn_dodaj.UseVisualStyleBackColor = true;
            this.frm_Dodaj_btn_dodaj.Click += new System.EventHandler(this.frm_Dodaj_btn_dodaj_Click);
            // 
            // frmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 269);
            this.Controls.Add(this.frm_Dodaj_btn_dodaj);
            this.Controls.Add(this.frm_Dodaj_lokalizacja);
            this.Controls.Add(this.frm_Dodaj_ocena);
            this.Controls.Add(this.frm_Dodaj_obejrzany);
            this.Controls.Add(this.frm_Dodaj_gatunek);
            this.Controls.Add(this.frm_Dodaj_rezyser);
            this.Controls.Add(this.frm_Dodaj_nazwa);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmDodaj";
            this.Text = "Dodaj nowy film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDodaj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frm_Dodaj_nazwa;
        private System.Windows.Forms.TextBox frm_Dodaj_rezyser;
        private System.Windows.Forms.TextBox frm_Dodaj_gatunek;
        private System.Windows.Forms.CheckBox frm_Dodaj_obejrzany;
        private System.Windows.Forms.ComboBox frm_Dodaj_ocena;
        private System.Windows.Forms.TextBox frm_Dodaj_lokalizacja;
        private System.Windows.Forms.Button frm_Dodaj_btn_dodaj;
    }
}