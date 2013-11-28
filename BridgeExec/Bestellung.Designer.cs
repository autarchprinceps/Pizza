namespace BridgeExec
{
    partial class Bestellung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.numMar = new System.Windows.Forms.NumericUpDown();
            this.numNap = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raTo = new System.Windows.Forms.RadioButton();
            this.raAm = new System.Windows.Forms.RadioButton();
            this.doit = new System.Windows.Forms.Button();
            this.Quittung = new System.Windows.Forms.TextBox();
            this.Rezept = new System.Windows.Forms.TextBox();
            this.doRezept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numMar
            // 
            this.numMar.Location = new System.Drawing.Point(12, 12);
            this.numMar.Name = "numMar";
            this.numMar.Size = new System.Drawing.Size(120, 20);
            this.numMar.TabIndex = 0;
            // 
            // numNap
            // 
            this.numNap.Location = new System.Drawing.Point(12, 38);
            this.numNap.Name = "numNap";
            this.numNap.Size = new System.Drawing.Size(120, 20);
            this.numNap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Margherita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Napoli";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raAm);
            this.groupBox1.Controls.Add(this.raTo);
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizzeria";
            // 
            // raTo
            // 
            this.raTo.AutoSize = true;
            this.raTo.Location = new System.Drawing.Point(7, 20);
            this.raTo.Name = "raTo";
            this.raTo.Size = new System.Drawing.Size(53, 17);
            this.raTo.TabIndex = 0;
            this.raTo.TabStop = true;
            this.raTo.Text = "Toni\'s";
            this.raTo.UseVisualStyleBackColor = true;
            // 
            // raAm
            // 
            this.raAm.AutoSize = true;
            this.raAm.Location = new System.Drawing.Point(7, 44);
            this.raAm.Name = "raAm";
            this.raAm.Size = new System.Drawing.Size(102, 17);
            this.raAm.TabIndex = 1;
            this.raAm.TabStop = true;
            this.raAm.Text = "American Pizzas";
            this.raAm.UseVisualStyleBackColor = true;
            // 
            // doit
            // 
            this.doit.Location = new System.Drawing.Point(325, 12);
            this.doit.Name = "doit";
            this.doit.Size = new System.Drawing.Size(72, 23);
            this.doit.TabIndex = 5;
            this.doit.Text = "Bestellung";
            this.doit.UseVisualStyleBackColor = true;
            this.doit.Click += new System.EventHandler(this.doit_Click);
            // 
            // Quittung
            // 
            this.Quittung.Location = new System.Drawing.Point(214, 88);
            this.Quittung.Multiline = true;
            this.Quittung.Name = "Quittung";
            this.Quittung.Size = new System.Drawing.Size(183, 340);
            this.Quittung.TabIndex = 6;
            // 
            // Rezept
            // 
            this.Rezept.Location = new System.Drawing.Point(12, 88);
            this.Rezept.Multiline = true;
            this.Rezept.Name = "Rezept";
            this.Rezept.Size = new System.Drawing.Size(196, 340);
            this.Rezept.TabIndex = 7;
            // 
            // doRezept
            // 
            this.doRezept.Location = new System.Drawing.Point(325, 42);
            this.doRezept.Name = "doRezept";
            this.doRezept.Size = new System.Drawing.Size(72, 23);
            this.doRezept.TabIndex = 8;
            this.doRezept.Text = "Rezept";
            this.doRezept.UseVisualStyleBackColor = true;
            this.doRezept.Click += new System.EventHandler(this.doRezept_Click);
            // 
            // Bestellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 440);
            this.Controls.Add(this.doRezept);
            this.Controls.Add(this.Rezept);
            this.Controls.Add(this.Quittung);
            this.Controls.Add(this.doit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNap);
            this.Controls.Add(this.numMar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bestellung";
            this.Text = "Bestellung";
            ((System.ComponentModel.ISupportInitialize)(this.numMar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMar;
        private System.Windows.Forms.NumericUpDown numNap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton raAm;
        private System.Windows.Forms.RadioButton raTo;
        private System.Windows.Forms.Button doit;
        private System.Windows.Forms.TextBox Quittung;
        private System.Windows.Forms.TextBox Rezept;
        private System.Windows.Forms.Button doRezept;
    }
}

