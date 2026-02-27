namespace AutoKolcsonzesGUI
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
            this.dgvKolcsonzesek = new System.Windows.Forms.DataGridView();
            this.txtUgyfel = new System.Windows.Forms.TextBox();
            this.txtRendszam = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModell = new System.Windows.Forms.TextBox();
            this.txtNapiDij = new System.Windows.Forms.TextBox();
            this.dtpMettol = new System.Windows.Forms.DateTimePicker();
            this.dtpMeddig = new System.Windows.Forms.DateTimePicker();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.txtSzures = new System.Windows.Forms.Label();
            this.btnSzures = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStatisztika = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statisztikákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kölcsönzésekSzámaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legdrágábbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legnépszerűbbMárkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.átlagIdőtartamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összesBevételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzesek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKolcsonzesek
            // 
            this.dgvKolcsonzesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKolcsonzesek.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvKolcsonzesek.Location = new System.Drawing.Point(0, 38);
            this.dgvKolcsonzesek.Name = "dgvKolcsonzesek";
            this.dgvKolcsonzesek.Size = new System.Drawing.Size(416, 412);
            this.dgvKolcsonzesek.TabIndex = 0;
            // 
            // txtUgyfel
            // 
            this.txtUgyfel.Location = new System.Drawing.Point(594, 60);
            this.txtUgyfel.Name = "txtUgyfel";
            this.txtUgyfel.Size = new System.Drawing.Size(100, 20);
            this.txtUgyfel.TabIndex = 1;
            // 
            // txtRendszam
            // 
            this.txtRendszam.Location = new System.Drawing.Point(594, 86);
            this.txtRendszam.Name = "txtRendszam";
            this.txtRendszam.Size = new System.Drawing.Size(100, 20);
            this.txtRendszam.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(594, 112);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 1;
            // 
            // txtModell
            // 
            this.txtModell.Location = new System.Drawing.Point(594, 138);
            this.txtModell.Name = "txtModell";
            this.txtModell.Size = new System.Drawing.Size(100, 20);
            this.txtModell.TabIndex = 1;
            // 
            // txtNapiDij
            // 
            this.txtNapiDij.Location = new System.Drawing.Point(594, 164);
            this.txtNapiDij.Name = "txtNapiDij";
            this.txtNapiDij.Size = new System.Drawing.Size(100, 20);
            this.txtNapiDij.TabIndex = 1;
            // 
            // dtpMettol
            // 
            this.dtpMettol.Location = new System.Drawing.Point(550, 226);
            this.dtpMettol.Name = "dtpMettol";
            this.dtpMettol.Size = new System.Drawing.Size(200, 20);
            this.dtpMettol.TabIndex = 2;
            // 
            // dtpMeddig
            // 
            this.dtpMeddig.Location = new System.Drawing.Point(550, 261);
            this.dtpMeddig.Name = "dtpMeddig";
            this.dtpMeddig.Size = new System.Drawing.Size(200, 20);
            this.dtpMeddig.TabIndex = 2;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(566, 314);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 3;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // txtSzures
            // 
            this.txtSzures.AutoSize = true;
            this.txtSzures.Location = new System.Drawing.Point(715, 364);
            this.txtSzures.Name = "txtSzures";
            this.txtSzures.Size = new System.Drawing.Size(16, 13);
            this.txtSzures.TabIndex = 4;
            this.txtSzures.Text = "...";
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(645, 397);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(75, 23);
            this.btnSzures.TabIndex = 5;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(485, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStatisztika
            // 
            this.lblStatisztika.AutoSize = true;
            this.lblStatisztika.Location = new System.Drawing.Point(545, 364);
            this.lblStatisztika.Name = "lblStatisztika";
            this.lblStatisztika.Size = new System.Drawing.Size(16, 13);
            this.lblStatisztika.TabIndex = 4;
            this.lblStatisztika.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Statisztika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szűrés eredmény:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ügyfél:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rendszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Márka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Modell:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Napi díj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mettől:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Meddig:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisztikákToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statisztikákToolStripMenuItem
            // 
            this.statisztikákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kölcsönzésekSzámaToolStripMenuItem,
            this.legdrágábbToolStripMenuItem,
            this.legnépszerűbbMárkaToolStripMenuItem,
            this.átlagIdőtartamToolStripMenuItem,
            this.összesBevételToolStripMenuItem,
            this.decemberToolStripMenuItem});
            this.statisztikákToolStripMenuItem.Name = "statisztikákToolStripMenuItem";
            this.statisztikákToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.statisztikákToolStripMenuItem.Text = "Statisztikák\n";
            // 
            // kölcsönzésekSzámaToolStripMenuItem
            // 
            this.kölcsönzésekSzámaToolStripMenuItem.Name = "kölcsönzésekSzámaToolStripMenuItem";
            this.kölcsönzésekSzámaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.kölcsönzésekSzámaToolStripMenuItem.Text = "Kölcsönzések száma";
            this.kölcsönzésekSzámaToolStripMenuItem.Click += new System.EventHandler(this.kolcsonzesekSzamaToolStripMenuItem_Click);
            // 
            // legdrágábbToolStripMenuItem
            // 
            this.legdrágábbToolStripMenuItem.Name = "legdrágábbToolStripMenuItem";
            this.legdrágábbToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.legdrágábbToolStripMenuItem.Text = "Legdrágább";
            this.legdrágábbToolStripMenuItem.Click += new System.EventHandler(this.legdragabbToolStripMenuItem_Click);
            // 
            // legnépszerűbbMárkaToolStripMenuItem
            // 
            this.legnépszerűbbMárkaToolStripMenuItem.Name = "legnépszerűbbMárkaToolStripMenuItem";
            this.legnépszerűbbMárkaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.legnépszerűbbMárkaToolStripMenuItem.Text = "Legnépszerűbb márka";
            this.legnépszerűbbMárkaToolStripMenuItem.Click += new System.EventHandler(this.legnepszerubbMarkaToolStripMenuItem_Click);
            // 
            // átlagIdőtartamToolStripMenuItem
            // 
            this.átlagIdőtartamToolStripMenuItem.Name = "átlagIdőtartamToolStripMenuItem";
            this.átlagIdőtartamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.átlagIdőtartamToolStripMenuItem.Text = "Átlag időtartam";
            this.átlagIdőtartamToolStripMenuItem.Click += new System.EventHandler(this.atlagToolStripMenuItem_Click);
            // 
            // összesBevételToolStripMenuItem
            // 
            this.összesBevételToolStripMenuItem.Name = "összesBevételToolStripMenuItem";
            this.összesBevételToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.összesBevételToolStripMenuItem.Text = "Összes bevétel";
            this.összesBevételToolStripMenuItem.Click += new System.EventHandler(this.osszesToolStripMenuItem_Click);
            // 
            // decemberToolStripMenuItem
            // 
            this.decemberToolStripMenuItem.Name = "decemberToolStripMenuItem";
            this.decemberToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.decemberToolStripMenuItem.Text = "2025 december";
            this.decemberToolStripMenuItem.Click += new System.EventHandler(this.decemberToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSzures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatisztika);
            this.Controls.Add(this.txtSzures);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.dtpMeddig);
            this.Controls.Add(this.dtpMettol);
            this.Controls.Add(this.txtNapiDij);
            this.Controls.Add(this.txtModell);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRendszam);
            this.Controls.Add(this.txtUgyfel);
            this.Controls.Add(this.dgvKolcsonzesek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKolcsonzesek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKolcsonzesek;
        private System.Windows.Forms.TextBox txtUgyfel;
        private System.Windows.Forms.TextBox txtRendszam;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModell;
        private System.Windows.Forms.TextBox txtNapiDij;
        private System.Windows.Forms.DateTimePicker dtpMettol;
        private System.Windows.Forms.DateTimePicker dtpMeddig;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Label txtSzures;
        private System.Windows.Forms.Button btnSzures;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatisztika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statisztikákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kölcsönzésekSzámaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legdrágábbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legnépszerűbbMárkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem átlagIdőtartamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összesBevételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decemberToolStripMenuItem;
    }
}

