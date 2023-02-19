namespace cipherText
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chosenFileLabel = new System.Windows.Forms.Label();
            this.savedFileLabel = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.cipher1 = new System.Windows.Forms.Button();
            this.decipher1 = new System.Windows.Forms.Button();
            this.cipher2 = new System.Windows.Forms.Button();
            this.decipher2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 323);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 323);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            // 
            // chosenFileLabel
            // 
            this.chosenFileLabel.AutoSize = true;
            this.chosenFileLabel.Location = new System.Drawing.Point(12, 416);
            this.chosenFileLabel.Name = "chosenFileLabel";
            this.chosenFileLabel.Size = new System.Drawing.Size(14, 16);
            this.chosenFileLabel.TabIndex = 5;
            this.chosenFileLabel.Text = "?";
            // 
            // savedFileLabel
            // 
            this.savedFileLabel.AutoSize = true;
            this.savedFileLabel.Location = new System.Drawing.Point(533, 416);
            this.savedFileLabel.Name = "savedFileLabel";
            this.savedFileLabel.Size = new System.Drawing.Size(14, 16);
            this.savedFileLabel.TabIndex = 6;
            this.savedFileLabel.Text = "?";
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(12, 387);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(96, 26);
            this.chooseFile.TabIndex = 7;
            this.chooseFile.Text = "Choose File";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(536, 390);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(96, 26);
            this.saveFile.TabIndex = 8;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // cipher1
            // 
            this.cipher1.Location = new System.Drawing.Point(353, 99);
            this.cipher1.Name = "cipher1";
            this.cipher1.Size = new System.Drawing.Size(98, 28);
            this.cipher1.TabIndex = 9;
            this.cipher1.Text = "Cipher 1";
            this.cipher1.UseVisualStyleBackColor = true;
            this.cipher1.Click += new System.EventHandler(this.cipher1_Click);
            // 
            // decipher1
            // 
            this.decipher1.Location = new System.Drawing.Point(353, 133);
            this.decipher1.Name = "decipher1";
            this.decipher1.Size = new System.Drawing.Size(98, 28);
            this.decipher1.TabIndex = 10;
            this.decipher1.Text = "Decipher 1";
            this.decipher1.UseVisualStyleBackColor = true;
            this.decipher1.Click += new System.EventHandler(this.decipher1_Click);
            // 
            // cipher2
            // 
            this.cipher2.Location = new System.Drawing.Point(353, 256);
            this.cipher2.Name = "cipher2";
            this.cipher2.Size = new System.Drawing.Size(98, 31);
            this.cipher2.TabIndex = 11;
            this.cipher2.Text = "Cipher 2";
            this.cipher2.UseVisualStyleBackColor = true;
            this.cipher2.Click += new System.EventHandler(this.cipher2_Click);
            // 
            // decipher2
            // 
            this.decipher2.Location = new System.Drawing.Point(353, 293);
            this.decipher2.Name = "decipher2";
            this.decipher2.Size = new System.Drawing.Size(98, 31);
            this.decipher2.TabIndex = 12;
            this.decipher2.Text = "Decipher 2";
            this.decipher2.UseVisualStyleBackColor = true;
            this.decipher2.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decipher2);
            this.Controls.Add(this.cipher2);
            this.Controls.Add(this.decipher1);
            this.Controls.Add(this.cipher1);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.savedFileLabel);
            this.Controls.Add(this.chosenFileLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cipher your text";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chosenFileLabel;
        private System.Windows.Forms.Label savedFileLabel;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button cipher1;
        private System.Windows.Forms.Button decipher1;
        private System.Windows.Forms.Button cipher2;
        private System.Windows.Forms.Button decipher2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

