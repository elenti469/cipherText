using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cipherText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Same as the cipher button because Atbash Cipher is symmetrical

            string output = "";

            foreach (char c in textBox1.Text)
            {
                if (char.IsLetter(c))
                {
                    char cUpper = char.ToUpper(c);
                    char encryptedChar = (char)(155 - cUpper);
                    output += encryptedChar;
                }
                else
                {
                    output += c;
                }
            }

            textBox2.Text = output;
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                chosenFileLabel.Text = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    textBox1.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
                savedFileLabel.Text = saveFileDialog1.FileName;
            }
        }

        private void cipher1_Click(object sender, EventArgs e)
        {
            // Ceasar cipher - replaces each letter with letter
            // that's n places down the alphabet

            int shift = 2;
            string output = "";

            foreach (char c in textBox1.Text)
            {
                if (char.IsLetter(c))
                {
                    // shift the letter by the shift value
                    char encryptedChar = (char)(((c - 65 + shift) % 26) + 65);

                    output += encryptedChar;
                }
                else
                {
                    output += c;
                }
            }
            textBox2.Text = output;
        }

        private void decipher1_Click(object sender, EventArgs e)
        {
            // Ceasar decipher

            int shift = 2;
            string output = "";

            foreach (char c in textBox1.Text)
            {
                if (char.IsLetter(c))
                {
                    // shift the letter by the -shift value
                    char encryptedChar = (char)(((c - 65 - shift) % 26) + 65);

                    output += encryptedChar;
                }
                else
                {
                    output += c;
                }
            }
            textBox2.Text = output;
        }

        private void cipher2_Click(object sender, EventArgs e)
        {
            /* Atbash Cipher:
            The Atbash Cipher is a simple substitution cipher that 
            replaces each letter of the alphabet with its corresponding letter 
            counting from the end of the alphabet. */

            string output = "";

            foreach (char c in textBox1.Text)
            {
                if (char.IsLetter(c))
                {
                    char cUpper = char.ToUpper(c);
                    char encryptedChar = (char)(155 - cUpper);
                    output += encryptedChar;
                }
                else
                {
                    output += c;
                }
            }

            textBox2.Text = output;
        }
    }
}
