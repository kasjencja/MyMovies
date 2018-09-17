namespace MyMovies
{
    partial class frmStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.frm_Start_dgw = new System.Windows.Forms.DataGridView();
            this.frmStart_dgw_nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmStart_dgw_rezyser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmStart_dgw_ocena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frmStart_dgw_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frm_Start_txtb_nazwa = new System.Windows.Forms.TextBox();
            this.frm_Start_txtb_rezyser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frm_Start_chckb_rezyser = new System.Windows.Forms.CheckBox();
            this.frm_Start_but_find = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.frm_Start_combob_genre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rfm_Start_but_losuj = new System.Windows.Forms.Button();
            this.frm_Start_btn_dodaj = new System.Windows.Forms.Button();
            this.frm_Start_btn_czyscBaze = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frm_Start_dgw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_Start_dgw
            // 
            this.frm_Start_dgw.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.frm_Start_dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.frm_Start_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frm_Start_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frmStart_dgw_nazwa,
            this.frmStart_dgw_rezyser,
            this.frmStart_dgw_ocena,
            this.frmStart_dgw_data});
            this.frm_Start_dgw.Enabled = false;
            this.frm_Start_dgw.Location = new System.Drawing.Point(395, 60);
            this.frm_Start_dgw.Name = "frm_Start_dgw";
            this.frm_Start_dgw.ReadOnly = true;
            this.frm_Start_dgw.Size = new System.Drawing.Size(414, 274);
            this.frm_Start_dgw.TabIndex = 0;
            this.frm_Start_dgw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.frm_Start_dgw_CellContentClick);
            // 
            // frmStart_dgw_nazwa
            // 
            this.frmStart_dgw_nazwa.HeaderText = "Nazwa";
            this.frmStart_dgw_nazwa.Name = "frmStart_dgw_nazwa";
            this.frmStart_dgw_nazwa.ReadOnly = true;
            this.frmStart_dgw_nazwa.Width = 120;
            // 
            // frmStart_dgw_rezyser
            // 
            this.frmStart_dgw_rezyser.HeaderText = "Reżyser";
            this.frmStart_dgw_rezyser.Name = "frmStart_dgw_rezyser";
            this.frmStart_dgw_rezyser.ReadOnly = true;
            this.frmStart_dgw_rezyser.Width = 120;
            // 
            // frmStart_dgw_ocena
            // 
            this.frmStart_dgw_ocena.HeaderText = "Ocena";
            this.frmStart_dgw_ocena.Name = "frmStart_dgw_ocena";
            this.frmStart_dgw_ocena.ReadOnly = true;
            this.frmStart_dgw_ocena.Width = 50;
            // 
            // frmStart_dgw_data
            // 
            this.frmStart_dgw_data.HeaderText = "Obejrzany";
            this.frmStart_dgw_data.Name = "frmStart_dgw_data";
            this.frmStart_dgw_data.ReadOnly = true;
            this.frmStart_dgw_data.Width = 80;
            // 
            // frm_Start_txtb_nazwa
            // 
            this.frm_Start_txtb_nazwa.Location = new System.Drawing.Point(10, 35);
            this.frm_Start_txtb_nazwa.Name = "frm_Start_txtb_nazwa";
            this.frm_Start_txtb_nazwa.Size = new System.Drawing.Size(330, 20);
            this.frm_Start_txtb_nazwa.TabIndex = 1;
            this.frm_Start_txtb_nazwa.Tag = "halo";
            this.frm_Start_txtb_nazwa.Text = "Tytuł filmu";
            this.frm_Start_txtb_nazwa.TextChanged += new System.EventHandler(this.frm_Start_txtb_nazwa_TextChanged);
            // 
            // frm_Start_txtb_rezyser
            // 
            this.frm_Start_txtb_rezyser.Location = new System.Drawing.Point(10, 74);
            this.frm_Start_txtb_rezyser.Name = "frm_Start_txtb_rezyser";
            this.frm_Start_txtb_rezyser.Size = new System.Drawing.Size(330, 20);
            this.frm_Start_txtb_rezyser.TabIndex = 2;
            this.frm_Start_txtb_rezyser.Tag = "";
            this.frm_Start_txtb_rezyser.Text = "Reżyser filmu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frm_Start_chckb_rezyser);
            this.groupBox1.Controls.Add(this.frm_Start_but_find);
            this.groupBox1.Controls.Add(this.frm_Start_txtb_rezyser);
            this.groupBox1.Controls.Add(this.frm_Start_txtb_nazwa);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyszukaj film";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frm_Start_chckb_rezyser
            // 
            this.frm_Start_chckb_rezyser.AutoSize = true;
            this.frm_Start_chckb_rezyser.Location = new System.Drawing.Point(10, 112);
            this.frm_Start_chckb_rezyser.Name = "frm_Start_chckb_rezyser";
            this.frm_Start_chckb_rezyser.Size = new System.Drawing.Size(236, 18);
            this.frm_Start_chckb_rezyser.TabIndex = 3;
            this.frm_Start_chckb_rezyser.Text = "Znajdź wszystkie filmy tego reżysera";
            this.frm_Start_chckb_rezyser.UseVisualStyleBackColor = true;
            // 
            // frm_Start_but_find
            // 
            this.frm_Start_but_find.Location = new System.Drawing.Point(218, 136);
            this.frm_Start_but_find.Name = "frm_Start_but_find";
            this.frm_Start_but_find.Size = new System.Drawing.Size(122, 23);
            this.frm_Start_but_find.TabIndex = 4;
            this.frm_Start_but_find.Text = "Znajdź";
            this.frm_Start_but_find.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(375, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 323);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ostatnio oglądane";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rfm_Start_but_losuj);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.frm_Start_combob_genre);
            this.groupBox3.Location = new System.Drawing.Point(23, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wybierz losowy film";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // frm_Start_combob_genre
            // 
            this.frm_Start_combob_genre.FormattingEnabled = true;
            this.frm_Start_combob_genre.Location = new System.Drawing.Point(202, 66);
            this.frm_Start_combob_genre.Name = "frm_Start_combob_genre";
            this.frm_Start_combob_genre.Size = new System.Drawing.Size(138, 22);
            this.frm_Start_combob_genre.TabIndex = 0;
            this.frm_Start_combob_genre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wybierz losowy film z gatunku:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rfm_Start_but_losuj
            // 
            this.rfm_Start_but_losuj.Location = new System.Drawing.Point(68, 29);
            this.rfm_Start_but_losuj.Name = "rfm_Start_but_losuj";
            this.rfm_Start_but_losuj.Size = new System.Drawing.Size(193, 23);
            this.rfm_Start_but_losuj.TabIndex = 7;
            this.rfm_Start_but_losuj.Text = "Losuj";
            this.rfm_Start_but_losuj.UseVisualStyleBackColor = true;
            // 
            // frm_Start_btn_dodaj
            // 
            this.frm_Start_btn_dodaj.Location = new System.Drawing.Point(23, 325);
            this.frm_Start_btn_dodaj.Name = "frm_Start_btn_dodaj";
            this.frm_Start_btn_dodaj.Size = new System.Drawing.Size(156, 23);
            this.frm_Start_btn_dodaj.TabIndex = 6;
            this.frm_Start_btn_dodaj.Text = "Dodaj nowy film";
            this.frm_Start_btn_dodaj.UseVisualStyleBackColor = true;
            this.frm_Start_btn_dodaj.Click += new System.EventHandler(this.frm_Start_btn_dodaj_Click);
            // 
            // frm_Start_btn_czyscBaze
            // 
            this.frm_Start_btn_czyscBaze.Location = new System.Drawing.Point(209, 325);
            this.frm_Start_btn_czyscBaze.Name = "frm_Start_btn_czyscBaze";
            this.frm_Start_btn_czyscBaze.Size = new System.Drawing.Size(154, 23);
            this.frm_Start_btn_czyscBaze.TabIndex = 7;
            this.frm_Start_btn_czyscBaze.Text = "Wyczyść bazę";
            this.frm_Start_btn_czyscBaze.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 374);
            this.Controls.Add(this.frm_Start_btn_czyscBaze);
            this.Controls.Add(this.frm_Start_btn_dodaj);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.frm_Start_dgw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmStart";
            this.Text = "Moje Filmy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm_Start_dgw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView frm_Start_dgw;
        private System.Windows.Forms.DataGridViewTextBoxColumn frmStart_dgw_nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn frmStart_dgw_rezyser;
        private System.Windows.Forms.DataGridViewTextBoxColumn frmStart_dgw_ocena;
        private System.Windows.Forms.DataGridViewTextBoxColumn frmStart_dgw_data;
        private System.Windows.Forms.TextBox frm_Start_txtb_nazwa;
        private System.Windows.Forms.TextBox frm_Start_txtb_rezyser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button frm_Start_but_find;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox frm_Start_chckb_rezyser;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox frm_Start_combob_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rfm_Start_but_losuj;
        private System.Windows.Forms.Button frm_Start_btn_dodaj;
        private System.Windows.Forms.Button frm_Start_btn_czyscBaze;
    }
}

