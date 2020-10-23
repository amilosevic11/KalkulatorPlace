namespace KalkulatorPlace_zavrsni
{
    partial class Form1
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
            this.btn_NoviRadnik = new System.Windows.Forms.Button();
            this.btn_PostojeciRadnik = new System.Windows.Forms.Button();
            this.btn_Izlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NoviRadnik
            // 
            this.btn_NoviRadnik.Location = new System.Drawing.Point(95, 121);
            this.btn_NoviRadnik.Name = "btn_NoviRadnik";
            this.btn_NoviRadnik.Size = new System.Drawing.Size(159, 117);
            this.btn_NoviRadnik.TabIndex = 0;
            this.btn_NoviRadnik.Text = "Novi radnik";
            this.btn_NoviRadnik.UseVisualStyleBackColor = true;
            this.btn_NoviRadnik.Click += new System.EventHandler(this.btn_NoviRadnik_Click);
            // 
            // btn_PostojeciRadnik
            // 
            this.btn_PostojeciRadnik.Location = new System.Drawing.Point(370, 121);
            this.btn_PostojeciRadnik.Name = "btn_PostojeciRadnik";
            this.btn_PostojeciRadnik.Size = new System.Drawing.Size(159, 117);
            this.btn_PostojeciRadnik.TabIndex = 1;
            this.btn_PostojeciRadnik.Text = "Postojeći radnik";
            this.btn_PostojeciRadnik.UseVisualStyleBackColor = true;
            this.btn_PostojeciRadnik.Click += new System.EventHandler(this.btn_PostojeciRadnik_Click);
            // 
            // btn_Izlaz
            // 
            this.btn_Izlaz.Location = new System.Drawing.Point(540, 382);
            this.btn_Izlaz.Name = "btn_Izlaz";
            this.btn_Izlaz.Size = new System.Drawing.Size(75, 23);
            this.btn_Izlaz.TabIndex = 2;
            this.btn_Izlaz.Text = "Izlaz";
            this.btn_Izlaz.UseVisualStyleBackColor = true;
            this.btn_Izlaz.Click += new System.EventHandler(this.btn_Izlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 417);
            this.Controls.Add(this.btn_Izlaz);
            this.Controls.Add(this.btn_PostojeciRadnik);
            this.Controls.Add(this.btn_NoviRadnik);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator plaće";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NoviRadnik;
        private System.Windows.Forms.Button btn_PostojeciRadnik;
        private System.Windows.Forms.Button btn_Izlaz;
    }
}

