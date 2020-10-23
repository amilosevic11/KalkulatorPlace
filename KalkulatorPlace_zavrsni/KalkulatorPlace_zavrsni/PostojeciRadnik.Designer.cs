namespace KalkulatorPlace_zavrsni
{
    partial class PostojeciRadnik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostojeciRadnik));
            this.DataGridViewPodaci = new System.Windows.Forms.DataGridView();
            this.btn_Nazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.ButtonPrintPreview = new System.Windows.Forms.Button();
            this.ButtonIspis = new System.Windows.Forms.Button();
            this.btn_Obrisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_IzracunajPlacu = new System.Windows.Forms.Button();
            this.BrutoIznos_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPodaci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPodaci
            // 
            this.DataGridViewPodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPodaci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPodaci.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewPodaci.Location = new System.Drawing.Point(12, 320);
            this.DataGridViewPodaci.Name = "DataGridViewPodaci";
            this.DataGridViewPodaci.Size = new System.Drawing.Size(826, 205);
            this.DataGridViewPodaci.TabIndex = 0;
            this.DataGridViewPodaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPodaci_CellClick);
            // 
            // btn_Nazad
            // 
            this.btn_Nazad.Location = new System.Drawing.Point(763, 593);
            this.btn_Nazad.Name = "btn_Nazad";
            this.btn_Nazad.Size = new System.Drawing.Size(75, 23);
            this.btn_Nazad.TabIndex = 1;
            this.btn_Nazad.Text = "Nazad";
            this.btn_Nazad.UseVisualStyleBackColor = true;
            this.btn_Nazad.Click += new System.EventHandler(this.btn_Nazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OIB:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(98, 10);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(211, 20);
            this.txtOIB.TabIndex = 3;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(98, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(211, 20);
            this.txtIme.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(98, 62);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(211, 20);
            this.txtPrezime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(387, 8);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 8;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(387, 34);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziSve.TabIndex = 9;
            this.btnPrikaziSve.Text = "Prikaži sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // ButtonPrintPreview
            // 
            this.ButtonPrintPreview.Location = new System.Drawing.Point(655, 593);
            this.ButtonPrintPreview.Name = "ButtonPrintPreview";
            this.ButtonPrintPreview.Size = new System.Drawing.Size(102, 23);
            this.ButtonPrintPreview.TabIndex = 10;
            this.ButtonPrintPreview.Text = "Pregled ispisa";
            this.ButtonPrintPreview.UseVisualStyleBackColor = true;
            this.ButtonPrintPreview.Click += new System.EventHandler(this.ButtonPrintPreview_Click);
            // 
            // ButtonIspis
            // 
            this.ButtonIspis.Location = new System.Drawing.Point(574, 593);
            this.ButtonIspis.Name = "ButtonIspis";
            this.ButtonIspis.Size = new System.Drawing.Size(75, 23);
            this.ButtonIspis.TabIndex = 11;
            this.ButtonIspis.Text = "Ispis";
            this.ButtonIspis.UseVisualStyleBackColor = true;
            this.ButtonIspis.Click += new System.EventHandler(this.ButtonIspis_Click);
            // 
            // btn_Obrisi
            // 
            this.btn_Obrisi.BackColor = System.Drawing.Color.Red;
            this.btn_Obrisi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Obrisi.Location = new System.Drawing.Point(734, 532);
            this.btn_Obrisi.Name = "btn_Obrisi";
            this.btn_Obrisi.Size = new System.Drawing.Size(103, 23);
            this.btn_Obrisi.TabIndex = 12;
            this.btn_Obrisi.Text = "Obriši radnika";
            this.btn_Obrisi.UseVisualStyleBackColor = false;
            this.btn_Obrisi.Click += new System.EventHandler(this.btn_Obrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Btn_IzracunajPlacu);
            this.groupBox1.Controls.Add(this.BrutoIznos_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 226);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos plaće";
            // 
            // Btn_IzracunajPlacu
            // 
            this.Btn_IzracunajPlacu.Location = new System.Drawing.Point(381, 197);
            this.Btn_IzracunajPlacu.Name = "Btn_IzracunajPlacu";
            this.Btn_IzracunajPlacu.Size = new System.Drawing.Size(64, 23);
            this.Btn_IzracunajPlacu.TabIndex = 18;
            this.Btn_IzracunajPlacu.Text = "Izračunaj";
            this.Btn_IzracunajPlacu.UseVisualStyleBackColor = true;
            this.Btn_IzracunajPlacu.Click += new System.EventHandler(this.Btn_IzracunajPlacu_Click);
            // 
            // BrutoIznos_textBox
            // 
            this.BrutoIznos_textBox.Location = new System.Drawing.Point(86, 46);
            this.BrutoIznos_textBox.Name = "BrutoIznos_textBox";
            this.BrutoIznos_textBox.Size = new System.Drawing.Size(211, 20);
            this.BrutoIznos_textBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bruto:";
            // 
            // PostojeciRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Obrisi);
            this.Controls.Add(this.ButtonIspis);
            this.Controls.Add(this.ButtonPrintPreview);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Nazad);
            this.Controls.Add(this.DataGridViewPodaci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PostojeciRadnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostojeciRadnik";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPodaci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPodaci;
        private System.Windows.Forms.Button btn_Nazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.Button ButtonPrintPreview;
        private System.Windows.Forms.Button ButtonIspis;
        private System.Windows.Forms.Button btn_Obrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BrutoIznos_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_IzracunajPlacu;
    }
}