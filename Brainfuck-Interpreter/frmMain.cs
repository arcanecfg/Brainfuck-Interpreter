using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brainfuck_Interpreter
{
    public partial class frmMain : Form
    {
        int[] cells = new int[15];
        int pointer = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() == string.Empty)
                MessageBox.Show("No code to interpret!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                txtOutput.Clear();
                pointer = 0;
                cells = new int[15];
                string input = txtInput.Text.Replace(Environment.NewLine, "").Replace(" ", "");

                var watch = System.Diagnostics.Stopwatch.StartNew();

                for (int i = 0; i < input.Length; i++)
                {
                    ExecuteCommand(ref i, input);
                }
                lblASCII.Text = cells[pointer] + "";

                watch.Stop();
                lblExec.Text = watch.Elapsed.TotalMilliseconds + "ms";
            }
        }

        private void ExecuteCommand(ref int i, string input)
        {
            switch (input[i])
            {
                case '+': cells[pointer]++; break;
                case '-': cells[pointer]--; break;
                case '>': pointer++; break;
                case '<': pointer--; break;
                case '.': txtOutput.AppendText((char)cells[pointer] + ""); break;
                case '[':
                    i++;
                    int iOriginal = i, loopSkip = 0;
                    char c = input[i];
                    while (cells[pointer] > 0)
                    {
                        while (c != ']')
                        {
                            ExecuteCommand(ref i, input);
                            i++;
                            c = input[i];
                        }
                        loopSkip = i;
                        i = iOriginal;
                        c = input[i];
                    }

                    i = loopSkip;
                    break;
                case ',':
                    cells[pointer] = (char) Microsoft.VisualBasic.Interaction.InputBox("Enter value ", "Input", "0")[0];
                    break;
            }
           
     
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)      
            {
                btnRun.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        


    }
}
