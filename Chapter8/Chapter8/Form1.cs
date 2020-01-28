using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int MAXLETTERS = 26; // Symbolic constants
        private const int MAXCHARS = MAXLETTERS - 1;
        private const int LETTERA = 65;
        private void Button1_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;
            length = txtInput.Text.Length;
            if (length == 0) // Anything to count??
            {
                MessageBox.Show("You need to enter some text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();
            for (i = 0; i < input.Length; i++) // Examine all letters.
            {
                oneLetter = input[i]; // Get a character
                index = oneLetter - LETTERA; // Make into an index
                if (index < 0 || index > MAXCHARS) // A letter??
                    continue; // Nope.
                count[index]++; // Yep.
            }
            for (i = 0; i < MAXLETTERS; i++)
            {
                buff = string.Format("{0, 4} {1,20}[{2}]", (char)(i + LETTERA),
                " ", count[i]);
                lstOutput.Items.Add(buff);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void LstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

