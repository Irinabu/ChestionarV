namespace ChestionarV
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
            this.labelNrIntrebare = new System.Windows.Forms.Label();
            this.labelNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEnunt = new System.Windows.Forms.Label();
            this.groupBoxRaspunsuri = new System.Windows.Forms.GroupBox();
            this.buttonUrmatoarea = new System.Windows.Forms.Button();
            this.buttonRezultat = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.listBoxAfisare = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInterese = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNrIntrebare
            // 
            this.labelNrIntrebare.Location = new System.Drawing.Point(0, 0);
            this.labelNrIntrebare.Name = "labelNrIntrebare";
            this.labelNrIntrebare.Size = new System.Drawing.Size(100, 23);
            this.labelNrIntrebare.TabIndex = 4;
            // 
            // labelNr
            // 
            this.labelNr.AutoSize = true;
            this.labelNr.BackColor = System.Drawing.Color.MistyRose;
            this.labelNr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNr.Location = new System.Drawing.Point(1070, 89);
            this.labelNr.Name = "labelNr";
            this.labelNr.Size = new System.Drawing.Size(64, 25);
            this.labelNr.TabIndex = 1;
            this.labelNr.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(1092, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "/5";
            // 
            // labelEnunt
            // 
            this.labelEnunt.AutoSize = true;
            this.labelEnunt.BackColor = System.Drawing.Color.MistyRose;
            this.labelEnunt.Location = new System.Drawing.Point(39, 68);
            this.labelEnunt.Name = "labelEnunt";
            this.labelEnunt.Size = new System.Drawing.Size(156, 25);
            this.labelEnunt.TabIndex = 3;
            this.labelEnunt.Text = "Enuntul intrebarii";
            // 
            // groupBoxRaspunsuri
            // 
            this.groupBoxRaspunsuri.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxRaspunsuri.Location = new System.Drawing.Point(44, 139);
            this.groupBoxRaspunsuri.Name = "groupBoxRaspunsuri";
            this.groupBoxRaspunsuri.Size = new System.Drawing.Size(1090, 420);
            this.groupBoxRaspunsuri.TabIndex = 5;
            this.groupBoxRaspunsuri.TabStop = false;
            // 
            // buttonUrmatoarea
            // 
            this.buttonUrmatoarea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUrmatoarea.Location = new System.Drawing.Point(877, 583);
            this.buttonUrmatoarea.Name = "buttonUrmatoarea";
            this.buttonUrmatoarea.Size = new System.Drawing.Size(257, 63);
            this.buttonUrmatoarea.TabIndex = 6;
            this.buttonUrmatoarea.Text = "Urmatoarea intrebare";
            this.buttonUrmatoarea.UseVisualStyleBackColor = false;
            this.buttonUrmatoarea.Click += new System.EventHandler(this.buttonUrmatoarea_Click);
            // 
            // buttonRezultat
            // 
            this.buttonRezultat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRezultat.Location = new System.Drawing.Point(1357, 583);
            this.buttonRezultat.Name = "buttonRezultat";
            this.buttonRezultat.Size = new System.Drawing.Size(158, 63);
            this.buttonRezultat.TabIndex = 7;
            this.buttonRezultat.Text = "Vezi rezultatul";
            this.buttonRezultat.UseVisualStyleBackColor = false;
            this.buttonRezultat.Click += new System.EventHandler(this.buttonRezultat_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonIesire.Location = new System.Drawing.Point(44, 642);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(159, 63);
            this.buttonIesire.TabIndex = 8;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = false;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // listBoxAfisare
            // 
            this.listBoxAfisare.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxAfisare.FormattingEnabled = true;
            this.listBoxAfisare.ItemHeight = 24;
            this.listBoxAfisare.Location = new System.Drawing.Point(1186, 376);
            this.listBoxAfisare.Name = "listBoxAfisare";
            this.listBoxAfisare.Size = new System.Drawing.Size(477, 172);
            this.listBoxAfisare.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(1260, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Facultățile potrivite tipurilor de interese";
            // 
            // groupBoxInterese
            // 
            this.groupBoxInterese.Location = new System.Drawing.Point(1186, 139);
            this.groupBoxInterese.Name = "groupBoxInterese";
            this.groupBoxInterese.Size = new System.Drawing.Size(475, 164);
            this.groupBoxInterese.TabIndex = 11;
            this.groupBoxInterese.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(1369, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interese";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1697, 801);
            this.Controls.Add(this.groupBoxInterese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAfisare);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonRezultat);
            this.Controls.Add(this.buttonUrmatoarea);
            this.Controls.Add(this.groupBoxRaspunsuri);
            this.Controls.Add(this.labelEnunt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNr);
            this.Controls.Add(this.labelNrIntrebare);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chestionar HOLLAND";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNrIntrebare;
        private System.Windows.Forms.Label labelNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEnunt;
        private System.Windows.Forms.GroupBox groupBoxRaspunsuri;
        private System.Windows.Forms.Button buttonUrmatoarea;
        private System.Windows.Forms.Button buttonRezultat;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.ListBox listBoxAfisare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInterese;
        private System.Windows.Forms.Label label3;
    }
}

