using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdust_checksum_solver
{

    public partial class Form1 : Form
    {
        static bool doneUpdatingRanges = true;

        public Form1()
        {
            InitializeComponent();
        }

        private string calcSd(string input)
        {
            string output = "";
            int D0 = 0;
            int D1 = 0;
            int C = 0;

            D0 = (input[C] - 65);
            C = C + 1;
            D0 = D0 + (input[C] - 65);
            C = C + 1;

            while (C < 9)
            {
                D1 = (input[C] - 65);
                D0 = D0 ^ D1;
                C = C + 1;
                D0 = D0 + (input[C] - 65);
                C = C + 1;
            }

            D0 = ~D0;
            output = input;
            output = output + (char)((D0 & 15) + 65); ;
            output = output + (char)(((D0 >> 4) & 15) + 65);

            return output;
        }

        private string calcSdA(string input)
        {
            string output = "";
            int D0 = 0;
            int D1 = 0;
            int C = 0;

            D0 = (input[C] - 65);
            C = C + 1;
            D0 = D0 + (input[C] - 65);
            C = C + 1;

            while (C < 9)
            {
                D1 = (input[C] - 65);
                D0 = D0 ^ D1;
                C = C + 1;
                D0 = D0 + (input[C] - 65);
                C = C + 1;
            }

            D0 = D0 ^ 42;
            output = input;
            output = output + (char)((D0 & 15) + 65); ;
            output = output + (char)(((D0 >> 4) & 15) + 65);

            return output;
        }

        private string calcSsd(string input)
        {
            string output = "";
            int D0 = 0;
            int D1 = 0;
            int C = 0;

            D1 = (input[8] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[1];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[5] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[3];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[4] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[6];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[5] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[7];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[2] - 65);
            D0 = D1 ^ D0;

            while (D0 > 25)
            {
                D0 = D0 - 25;
            }

            output = input;
            output = output + (char)((D0 + 65));

            D0 = D0 + input[4];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[8];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[5];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[3];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[7];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[1];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[6];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[2];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[0];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            while (D0 > 25)
            {
                D0 = D0 - 25;
            }

            output = output + (char)((D0 + 65));

            return output;
        }

        private string calcSsdcd32(string input)
        {
            string output = "";
            int D0 = 0;
            int D1 = 0;
            int C = 0;

            D1 = (input[1] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[8];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[3] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[5];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[6] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[5];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[7] - 65);
            D0 = D1 ^ D0;
            D0 = D0 - input[5];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D1 = (input[2] - 65);
            D0 = D1 ^ D0;

            while (D0 > 25)
            {
                D0 = D0 - 25;
            }

            output = input;
            output = output + (char)((D0 + 65));

            D0 = D0 + input[8];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[4];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[3];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[5];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[1];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[7];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[2];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            D0 = D0 - input[6];
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }
            D0 = D0 + 65;
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }

            D0 = D0 + input[0];
            if (D0 > 255)
            {
                D0 = D0 - 256;
            }
            D0 = D0 - 65;
            if (D0 < 0)
            {
                D0 = 256 - (-D0);
            }

            while (D0 > 25)
            {
                D0 = D0 - 25;
            }

            output = output + (char)((D0 + 65));

            return output;
        }

        private string calcSsd96(string input)
        {
            string output = "";
            string tempstring = "";
            int tempint = 0;

            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            int E = 0;
            int S = 0;
            int CS1 = 0;
            int CS2 = 0;

            for (int n = 0; n <= 8; n++)
            {
                tempint = input[n] - 48;

                if (tempint > 10)
                {
                    tempint = tempint - 8;
                }
                tempstring = tempstring + (char)tempint;
            }

            A = tempstring[7];
            A = A - tempstring[8];
            if (A < 0)
            {
                A = 65536 - (-A);
            }
            S = A;
            A = tempstring[5];
            A = A & tempstring[6];
            B = A;
            A = tempstring[3];
            A = A * tempstring[4];
            C = A;
            A = tempstring[2];
            E = A;
            A = A << 1;
            A = A + E;
            D = A;
            A = tempstring[0];
            A = A + tempstring[1];
            A = A ^ tempstring[7];
            A = A + D;
            A = A + C;
            A = A + B;
            D = S;
            A = A - D;
            if (A < 0)
            {
                A = 65536 - (-A);
            }
            B = A;
            A = tempstring[3];
            A = A * tempstring[1];
            C = A;
            A = tempstring[0];
            A = A * tempstring[2];
            A = A + C;
            A = A + B;
            if (A >= 65536)
            {
                A = A - 65536;
            }
            A = A + tempstring[8];
            if (A >= 65536)
            {
                A = A - 65536;
            }
            CS1 = A & 31;
            CS2 = (A >> 3) & 31;

            if (CS1 >= 9)
            {
                CS1 = CS1 + 8;
            }
            CS1 = CS1 + 48;

            if (CS2 >= 9)
            {
                CS2 = CS2 + 8;
            }
            CS2 = CS2 + 48;

            output = input;
            output = output + (char)CS1;
            output = output + (char)CS2;

            return output;
        }

        private void calcChecksum(string input)
        {
            if (checkedListBox1.GetItemChecked(0) == true)
            {
                if (input.Length == 10)
                {
                    outputBox.Text = calcSd(input);
                }
                else
                {
                    outputBox.Text = "Enter first 10 characters";
                }
            }

            else if (checkedListBox1.GetItemChecked(1) == true)
            {
                if (input.Length == 10)
                {
                    outputBox.Text = calcSdA(input);
                }
                else
                {
                    outputBox.Text = "Enter first 10 characters";
                }
            }
            else if (checkedListBox1.GetItemChecked(2) == true)
            {
                if (input.Length == 9)
                {
                    outputBox.Text = calcSsd(input);
                }
                else
                {
                    outputBox.Text = "Enter first 9 characters";
                }
            }
            else if (checkedListBox1.GetItemChecked(3) == true)
            {
                if (input.Length == 9)
                {
                    outputBox.Text = calcSsdcd32(input);
                }
                else
                {
                    outputBox.Text = "Enter first 9 characters";
                }
            }
            else if (checkedListBox1.GetItemChecked(4) == true)
            {
                if (input.Length == 9)
                {
                    outputBox.Text = calcSsd96(input);
                }
                else
                {
                    outputBox.Text = "Enter first 9 characters";
                }
            }
            else
            {
                outputBox.Text = "Select a game";
            }
        }

        private void focusTextBox(TextBox boxi)
        {
            this.ActiveControl = boxi;
            boxi.DeselectAll();
            boxi.SelectionStart = boxi.Text.Length;
        }

        private void updateRanges(int selection)
        {
            doneUpdatingRanges = false;
            if (selection == 0 || selection == 1 || selection == 2 || selection == 3)
            {
                numWorld.Minimum = 1;
                numWorld.Maximum = 26;
                numLives.Minimum = 1;
                numLives.Maximum = 26;
                num3way.Minimum = 0;
                num3way.Maximum = 25;
                numBouncer.Minimum = 0;
                numBouncer.Maximum = 25;
                numPlasma.Minimum = 0;
                numPlasma.Maximum = 25;
                numFlamer.Minimum = 0;
                numFlamer.Maximum = 25;
                numBurster.Minimum = 0;
                numBurster.Maximum = 25;
                numMissiles.Minimum = 0;
                numMissiles.Maximum = 25;
                numUnknown.Minimum = 0;
                numUnknown.Maximum = 25;
                numEngine.Minimum = 0;
                numEngine.Maximum = 25;
            }
            else if (selection == 4)
            {
                numWorld.Minimum = 2;
                numWorld.Maximum = 36;
                numLives.Minimum = 0;
                numLives.Maximum = 34;
                num3way.Minimum = 0;
                num3way.Maximum = 34;
                numBouncer.Minimum = 0;
                numBouncer.Maximum = 34;
                numPlasma.Minimum = 0;
                numPlasma.Maximum = 34;
                numFlamer.Minimum = 0;
                numFlamer.Maximum = 34;
                numBurster.Minimum = 0;
                numBurster.Maximum = 34;
                numMissiles.Minimum = 0;
                numMissiles.Maximum = 34;
                numUnknown.Minimum = 0;
                numUnknown.Maximum = 25;

                if (numEngine.Value == 0)
                {
                    numHiddenEngineBU.Value = 0;
                }

                numEngine.Minimum = 1;
                numEngine.Maximum = 35;
            }

            doneUpdatingRanges = true;

            return;
        }

        private int ModMinus(int a, int b)
        {
            int c = 0;

            if (b >= 32)
            {
                b = b - 32;
            }

            if (a - b < 0)
            {
                c = ((a - b - 3) % 35);
                if (c < 0)
                {
                    c = c + 35;
                }
            }
            else
            {
                c = ((a - b) % 35);
            }

            return c;
        }

        private int ModSum(int a, int b)
        {
            int c = 0;

            if (b >= 32)
            {
                b = b - 32;
            }

            if (a + b > 34)
            {
                c = ((a + b + 3) % 35);
            }
            else
            {
                c = ((a + b) % 35);
            }

            return c;
        }

        private void updateNumerics()
        {
            if (inputBox.Text.Length >= 1)
            {
                if (numWorld.Minimum <= inputBox.Text[0] - 64 && inputBox.Text[0] - 64 <= numWorld.Maximum)
                {
                    numWorld.Value = inputBox.Text[0] - 64;
                    numWorld.ForeColor = Color.Black;
                }
                else
                {
                    numWorld.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 2)
            {
                if (numLives.Minimum <= inputBox.Text[1] - 64 && inputBox.Text[1] - 64 <= numLives.Maximum)
                {
                    numLives.Value = inputBox.Text[1] - 64;
                    numLives.ForeColor = Color.Black;
                }
                else
                {
                    numLives.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 3)
            {
                if ((num3way.Minimum <= inputBox.Text[2] - 80 && inputBox.Text[2] - 80 <= num3way.Minimum + 10) || (num3way.Minimum + 11 <= inputBox.Text[2] - 54 && inputBox.Text[2] - 54 <= num3way.Maximum))
                {
                    if (inputBox.Text[2] >= 80)
                    {
                        num3way.Value = inputBox.Text[2] - 80;
                    }
                    else if (inputBox.Text[2] < 80)
                    {
                        num3way.Value = inputBox.Text[2] - 54;
                    }
                    num3way.ForeColor = Color.Black;
                }
                else
                {
                    num3way.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 4)
            {
                if ((numBouncer.Minimum <= inputBox.Text[3] - 80 && inputBox.Text[3] - 80 <= numBouncer.Minimum + 10) || (numBouncer.Minimum + 11 <= inputBox.Text[3] - 54 && inputBox.Text[3] - 54 <= numBouncer.Maximum))
                {
                    if (inputBox.Text[3] >= 80)
                    {
                        numBouncer.Value = inputBox.Text[3] - 80;
                    }
                    else if (inputBox.Text[3] < 80)
                    {
                        numBouncer.Value = inputBox.Text[3] - 54;
                    }
                    numBouncer.ForeColor = Color.Black;
                }
                else
                {
                    numBouncer.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 5)
            {
                if ((numPlasma.Minimum <= inputBox.Text[4] - 80 && inputBox.Text[4] - 80 <= numPlasma.Minimum + 10) || (numPlasma.Minimum + 11 <= inputBox.Text[4] - 54 && inputBox.Text[4] - 54 <= numPlasma.Maximum))
                {
                    if (inputBox.Text[4] >= 80)
                    {
                        numPlasma.Value = inputBox.Text[4] - 80;
                    }
                    else if (inputBox.Text[4] < 80)
                    {
                        numPlasma.Value = inputBox.Text[4] - 54;
                    }
                    numPlasma.ForeColor = Color.Black;
                }
                else
                {
                    numPlasma.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 6)
            {
                if ((numFlamer.Minimum <= inputBox.Text[5] - 80 && inputBox.Text[5] - 80 <= numFlamer.Minimum + 10) || (numFlamer.Minimum + 11 <= inputBox.Text[5] - 54 && inputBox.Text[5] - 54 <= numFlamer.Maximum))
                {
                    if (inputBox.Text[5] >= 80)
                    {
                        numFlamer.Value = inputBox.Text[5] - 80;
                    }
                    else if (inputBox.Text[5] < 80)
                    {
                        numFlamer.Value = inputBox.Text[5] - 54;
                    }
                    numFlamer.ForeColor = Color.Black;
                }
                else
                {
                    numFlamer.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 7)
            {
                if ((numBurster.Minimum <= inputBox.Text[6] - 80 && inputBox.Text[6] - 80 <= numBurster.Minimum + 10) || (numBurster.Minimum + 11 <= inputBox.Text[6] - 54 && inputBox.Text[6] - 54 <= numBurster.Maximum))
                {
                    if (inputBox.Text[6] >= 80)
                    {
                        numBurster.Value = inputBox.Text[6] - 80;
                    }
                    else if (inputBox.Text[6] < 80)
                    {
                        numBurster.Value = inputBox.Text[6] - 54;
                    }
                    numBurster.ForeColor = Color.Black;
                }
                else
                {
                    numBurster.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 8)
            {
                if ((numMissiles.Minimum <= inputBox.Text[7] - 81 && inputBox.Text[7] - 81 <= numMissiles.Minimum + 9) || (numMissiles.Minimum + 10 <= inputBox.Text[7] - 55 && inputBox.Text[7] - 55 <= numMissiles.Maximum))
                {
                    if (inputBox.Text[7] >= 81)
                    {
                        numMissiles.Value = inputBox.Text[7] - 81;
                    }
                    else if (inputBox.Text[7] < 81)
                    {
                        numMissiles.Value = inputBox.Text[7] - 55;
                    }
                    numMissiles.ForeColor = Color.Black;
                }
                else
                {
                    numMissiles.ForeColor = Color.Red;
                }
            }
            if (inputBox.Text.Length >= 9)
            {
                if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true)
                {
                    if (numUnknown.Minimum <= inputBox.Text[8] - 65 && inputBox.Text[8] - 65 <= numUnknown.Maximum)
                    {
                        numUnknown.Value = inputBox.Text[8] - 65;
                        numUnknown.ForeColor = Color.Black;
                    }
                    else
                    {
                        numUnknown.ForeColor = Color.Red;
                    }
                }
                else if (checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true || checkedListBox1.GetItemChecked(4) == true)
                {
                    if (numEngine.Minimum <= inputBox.Text[8] - 65 && inputBox.Text[8] - 65 <= numEngine.Maximum)
                    {
                        numEngine.Value = inputBox.Text[8] - 65;
                        numEngine.ForeColor = Color.Black;
                    }
                    else
                    {
                        numEngine.ForeColor = Color.Red;
                    }
                }
            }
            if (inputBox.Text.Length >= 10)
            {
                if (numEngine.Minimum <= inputBox.Text[9] - 65 && inputBox.Text[9] - 65 <= numEngine.Maximum)
                {
                    numEngine.Value = inputBox.Text[9] - 65;
                    numEngine.ForeColor = Color.Black;
                }
                else
                {
                    numEngine.ForeColor = Color.Red;
                }
            }
        }

        private void updateNumericsSsd96()
        {
            if (numHiddenEngineBU.Value == 0)
            {
                if (numEngine.Value != 1 )
                {
                    numHiddenEngineBU.Value = 36;
                }
            }
            else
            {
                numHiddenEngineBU.Value = numEngine.Value;
            }

            if (inputBox.Text.Length >= 1)
            {
                if ((numWorld.Minimum <= inputBox.Text[0] - 46 && inputBox.Text[0] - 46 <= numWorld.Minimum + 9) || (numWorld.Minimum + 9 <= inputBox.Text[0] - 54 && inputBox.Text[0] - 54 <= numWorld.Maximum))
                {
                    if (inputBox.Text[0] < 58)
                    {
                        numWorld.Value = inputBox.Text[0] - 46;
                        numWorld.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[0] >= 65)
                    {
                        numWorld.Value = inputBox.Text[0] - 54;
                        numWorld.ForeColor = Color.Black;
                    }
                    else
                    {
                        numWorld.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numWorld.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 8)
            {

                if ((numEngine.Minimum <= inputBox.Text[7] - 47 && inputBox.Text[7] - 47 <= numEngine.Minimum + 9) || (numEngine.Minimum + 9 <= inputBox.Text[7] - 55 && inputBox.Text[7] - 55 <= numEngine.Maximum))
                {
                    if (inputBox.Text[7] < 58)
                    {
                        numEngine.Value = inputBox.Text[7] - 47;
                        numEngine.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[7] >= 65)
                    {
                        numEngine.Value = inputBox.Text[7] - 55;
                        numEngine.ForeColor = Color.Black;
                    }
                    else
                    {
                        numEngine.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numEngine.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 2)
            {
                if ((num3way.Minimum <= inputBox.Text[1] - 48 && inputBox.Text[1] - 48 <= num3way.Minimum + 9) || (num3way.Minimum + 9 <= inputBox.Text[1] - 56 && inputBox.Text[1] - 56 <= num3way.Maximum))
                {
                    if (inputBox.Text[1] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            num3way.Value = ModMinus(inputBox.Text[1] - 48, (int)numEngine.Value - 1);
                        }
                        else
                        {
                            num3way.Value = inputBox.Text[1] - 48;
                        }
                        num3way.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[1] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            num3way.Value = ModMinus(inputBox.Text[1] - 56, (int)numEngine.Value - 1);
                        }
                        else
                        {
                            num3way.Value = inputBox.Text[1] - 56;
                        }
                        num3way.ForeColor = Color.Black;
                    }
                    else
                    {
                        num3way.ForeColor = Color.Red;
                    }
                }
                else
                {
                    num3way.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 3)
            {
                if ((numBouncer.Minimum <= inputBox.Text[2] - 48 && inputBox.Text[2] - 48 <= numBouncer.Minimum + 9) || (numBouncer.Minimum + 9 <= inputBox.Text[2] - 56 && inputBox.Text[2] - 56 <= numBouncer.Maximum))
                {
                    if (inputBox.Text[2] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numBouncer.Value = ModMinus(inputBox.Text[2] - 48, ((int)numEngine.Value - 1) * 2);
                        }
                        else
                        {
                            numBouncer.Value = inputBox.Text[2] - 48;
                        }
                        numBouncer.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[2] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numBouncer.Value = ModMinus(inputBox.Text[2] - 56, ((int)numEngine.Value - 1) * 2);
                        }
                        else
                        {
                            numBouncer.Value = inputBox.Text[2] - 56;
                        }
                        numBouncer.ForeColor = Color.Black;
                    }
                    else
                    {
                        numBouncer.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numBouncer.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 4)
            {
                if ((numPlasma.Minimum <= inputBox.Text[3] - 48 && inputBox.Text[3] - 48 <= numPlasma.Minimum + 9) || (numPlasma.Minimum + 9 <= inputBox.Text[3] - 56 && inputBox.Text[3] - 56 <= numPlasma.Maximum))
                {
                    if (inputBox.Text[3] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numPlasma.Value = ModMinus(inputBox.Text[3] - 48, ((int)numEngine.Value - 1) * 3);
                        }
                        else
                        {
                            numPlasma.Value = inputBox.Text[3] - 48;
                        }
                        numPlasma.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[3] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numPlasma.Value = ModMinus(inputBox.Text[3] - 56, ((int)numEngine.Value - 1) * 3);
                        }
                        else
                        {
                            numPlasma.Value = inputBox.Text[3] - 56;
                        }
                        numPlasma.ForeColor = Color.Black;
                    }
                    else
                    {
                        numPlasma.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numPlasma.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 5)
            {
                if ((numFlamer.Minimum <= inputBox.Text[4] - 48 && inputBox.Text[4] - 48 <= numFlamer.Minimum + 9) || (numFlamer.Minimum + 9 <= inputBox.Text[4] - 56 && inputBox.Text[4] - 56 <= numFlamer.Maximum))
                {
                    if (inputBox.Text[4] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numFlamer.Value = ModMinus(inputBox.Text[4] - 48, ((int)numEngine.Value - 1) * 4);
                        }
                        else
                        {
                            numFlamer.Value = inputBox.Text[4] - 48;
                        }
                        numFlamer.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[4] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numFlamer.Value = ModMinus(inputBox.Text[4] - 56, ((int)numEngine.Value - 1) * 4);
                        }
                        else
                        {
                            numFlamer.Value = inputBox.Text[4] - 56;
                        }
                        numFlamer.ForeColor = Color.Black;
                    }
                    else
                    {
                        numFlamer.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numFlamer.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 6)
            {
                if ((numBurster.Minimum <= inputBox.Text[5] - 48 && inputBox.Text[5] - 48 <= numBurster.Minimum + 9) || (numBurster.Minimum + 9 <= inputBox.Text[5] - 56 && inputBox.Text[5] - 56 <= numBurster.Maximum))
                {
                    if (inputBox.Text[5] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numBurster.Value = ModMinus(inputBox.Text[5] - 48, ((int)numEngine.Value - 1) * 5);
                        }
                        else
                        {
                            numBurster.Value = inputBox.Text[5] - 48;
                        }
                        numBurster.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[5] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numBurster.Value = ModMinus(inputBox.Text[5] - 56, ((int)numEngine.Value - 1) * 5);
                        }
                        else
                        {
                            numBurster.Value = inputBox.Text[5] - 56;
                        }
                        numBurster.ForeColor = Color.Black;
                    }
                    else
                    {
                        numBurster.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numBurster.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 7)
            {
                if ((numMissiles.Minimum <= inputBox.Text[6] - 48 && inputBox.Text[6] - 48 <= numMissiles.Minimum + 9) || (numMissiles.Minimum + 9 <= inputBox.Text[6] - 56 && inputBox.Text[6] - 56 <= numMissiles.Maximum))
                {
                    if (inputBox.Text[6] < 58)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numMissiles.Value = ModMinus(inputBox.Text[6] - 48, ((int)numEngine.Value - 1) * 6);
                        }
                        else
                        {
                            numMissiles.Value = inputBox.Text[6] - 48;
                        }
                        numMissiles.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[6] >= 65)
                    {
                        if (inputBox.Text.Length >= 8)
                        {
                            numMissiles.Value = ModMinus(inputBox.Text[6] - 56, ((int)numEngine.Value - 1) * 6);
                        }
                        else
                        {
                            numMissiles.Value = inputBox.Text[6] - 56;
                        }
                        numMissiles.ForeColor = Color.Black;
                    }
                    else
                    {
                        numMissiles.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numMissiles.ForeColor = Color.Red;
                }
            }

            if (inputBox.Text.Length >= 9)
            {
                if ((numLives.Minimum <= inputBox.Text[8] - 48 && inputBox.Text[8] - 48 <= numLives.Minimum + 9) || (numLives.Minimum + 9 <= inputBox.Text[8] - 56 && inputBox.Text[8] - 56 <= numLives.Maximum))
                {
                    if (inputBox.Text[8] < 58)
                    {
                        numLives.Value = inputBox.Text[8] - 48;
                        numLives.ForeColor = Color.Black;
                    }
                    else if (inputBox.Text[8] >= 65)
                    {
                        numLives.Value = inputBox.Text[8] - 56;
                        numLives.ForeColor = Color.Black;
                    }
                    else
                    {
                        numLives.ForeColor = Color.Red;
                    }
                }
                else
                {
                    numLives.ForeColor = Color.Red;
                }
            }

            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = checkedListBox1.Items;
            items.Add("sd", true);
            items.Add("sd atari", false);
            items.Add("ssd", false);
            items.Add("ssd cd32", false);
            items.Add("ssd 96", false);
            focusTextBox(inputBox);
            calcChecksum(inputBox.Text);
            this.Text = "Stardust";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cursorplace = inputBox.SelectionStart;

            int selected = checkedListBox1.SelectedIndex;
            if (selected != -1)
            {
                for (int z = 0; z < checkedListBox1.Items.Count; z++)
                {
                    if (z != selected)
                    {
                        checkedListBox1.SetItemCheckState(z, CheckState.Unchecked);
                    }
                }

                if (selected == 0)
                {
                    this.Text = "Stardust";
                }
                else if (selected == 1)
                {
                    this.Text = "Stardust Atari ST";
                }
                else if (selected == 2)
                {
                    this.Text = "Super Stardust";
                }
                else if (selected == 3)
                {
                    this.Text = "Super Stardust cd32";
                }
                else if (selected == 4)
                {
                    this.Text = "Super Stardust '96";
                }
            }

            if (selected == 0 || selected == 1 || selected == 2 || selected == 3)
            {
                updateRanges(selected);
            }
            else if (selected == 4)
            {
                updateRanges(selected);
            }

            if (selected == 2 || selected == 3 || selected == 4)
            {
                if (inputBox.Text.Length >= 10)
                {
                    string tempstringi = inputBox.Text;
                    tempstringi = tempstringi.Remove(8, 1);
                    inputBox.Text = tempstringi;
                    if (cursorplace >= 9)
                    {
                        cursorplace = cursorplace - 1;
                    }
                }

                labelUnknown.Visible = false;
                numUnknown.Visible = false;
            }

            if (selected == 0 || selected == 1)
            {
                if (inputBox.Text.Length == 9)
                {
                    string tempstringi = inputBox.Text, addition = "";
                    addition = addition + (char)(numUnknown.Value + 65);
                    tempstringi = tempstringi.Insert(8, addition);
                    inputBox.Text = tempstringi;
                    if (cursorplace >= 8)
                    {
                        cursorplace = cursorplace + 1;
                    }
                }

                labelUnknown.Visible = true;
                numUnknown.Visible = true;
            }

            this.ActiveControl = inputBox;
            inputBox.DeselectAll();
            inputBox.SelectionStart = cursorplace;
            calcChecksum(inputBox.Text);
            if (selected == 0 || selected == 1 || selected == 2 || selected == 3)
            {
                updateNumerics();
            }
            else if (selected == 4)
            {
                updateNumericsSsd96();
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            int cursorplace = inputBox.SelectionStart;

            if ((checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true) && inputBox.Text.Length > 10)
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.SelectionStart - 1 , 1);
                cursorplace = cursorplace - 1;
            }
            else if ((checkedListBox1.GetItemChecked(0) == false && checkedListBox1.GetItemChecked(1) == false) && inputBox.Text.Length > 9)
            {
                if (inputBox.SelectionStart - 1 != -1)
                {
                    inputBox.Text = inputBox.Text.Remove(inputBox.SelectionStart - 1, 1);
                    cursorplace = cursorplace - 1;
                }
            }

            inputBox.Text = inputBox.Text.ToUpper();
            inputBox.SelectionStart = cursorplace;
            if (doneUpdatingRanges == true)
            {
                if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
                {
                    updateNumerics();
                }
                else if (checkedListBox1.GetItemChecked(4))
                {
                    updateNumericsSsd96();
                }
            }
            calcChecksum(inputBox.Text);
        }

        private void numWorld_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";
                if (inputBox.Text.Length < 1)
                {
                    tempstring = "?";
                }
                else
                {
                    tempstring = inputBox.Text;
                }
                tempstring = tempstring.Remove(0, 1);
                addition = addition + (char)(numWorld.Value + 64);
                tempstring = tempstring.Insert(0, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";
                if (inputBox.Text.Length < 1)
                {
                    tempstring = "?";
                }
                else
                {
                    tempstring = inputBox.Text;
                }
                tempstring = tempstring.Remove(0, 1);
                if (numWorld.Value <= 11)
                {
                    addition = addition + (char)(numWorld.Value + 46);
                }
                else if (numWorld.Value >= 12)
                {
                    addition = addition + (char)(numWorld.Value + 54);
                }
                tempstring = tempstring.Insert(0, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numLives_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";
                
                tempstring = inputBox.Text;
                for (int z = 0; z < 2 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(1, 1);
                addition = addition + (char)(numLives.Value + 64);
                tempstring = tempstring.Insert(1, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";
                tempstring = inputBox.Text;
                for (int z = 0; z < 9 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }
                tempstring = tempstring.Remove(8, 1);
                if (numLives.Value <= 9)
                {
                    addition = addition + (char)(numLives.Value + 48);
                }
                else if (numLives.Value >= 10)
                {
                    addition = addition + (char)(numLives.Value + 56);
                }
                tempstring = tempstring.Insert(8, addition);
                inputBox.Text = tempstring;
            }
        }

        private void num3way_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 3 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(2, 1);
                if (0 <= num3way.Value && num3way.Value <= 10)
                {
                    addition = addition + (char)(num3way.Value + 80);
                }
                else if (num3way.Value >= 11)
                {
                    addition = addition + (char)(num3way.Value + 54);
                }
                tempstring = tempstring.Insert(2, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 2 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(1, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) + 48);
                    }
                    else if (ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) + 56);
                    }
                }
                else
                {
                    if (num3way.Value <= 9)
                    {
                        addition = addition + (char)(num3way.Value + 48);
                    }
                    else if (num3way.Value >= 10)
                    {
                        addition = addition + (char)(num3way.Value + 56);
                    }
                }

                tempstring = tempstring.Insert(1, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numBouncer_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 4 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(3, 1);
                if (0 <= numBouncer.Value && numBouncer.Value <= 10)
                {
                    addition = addition + (char)(numBouncer.Value + 80);
                }
                else if (numBouncer.Value >= 11)
                {
                    addition = addition + (char)(numBouncer.Value + 54);
                }
                tempstring = tempstring.Insert(3, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 3 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(2, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1)) * 2) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1) * 2)) + 48);
                    }
                    else if (ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1)) * 2) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1)) * 2) + 56);
                    }
                }
                else
                {
                    if (numBouncer.Value <= 9)
                    {
                        addition = addition + (char)(numBouncer.Value + 48);
                    }
                    else if (numBouncer.Value >= 10)
                    {
                        addition = addition + (char)(numBouncer.Value + 56);
                    }
                }
                tempstring = tempstring.Insert(2, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numPlasma_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 5 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(4, 1);
                if (0 <= numPlasma.Value && numPlasma.Value <= 10)
                {
                    addition = addition + (char)(numPlasma.Value + 80);
                }
                else if (numPlasma.Value >= 11)
                {
                    addition = addition + (char)(numPlasma.Value + 54);
                }
                tempstring = tempstring.Insert(4, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 4 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(3, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1)) * 3) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1) * 3)) + 48);
                    }
                    else if (ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1)) * 3) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1)) * 3) + 56);
                    }
                }
                else
                {
                    if (numPlasma.Value <= 9)
                    {
                        addition = addition + (char)(numPlasma.Value + 48);
                    }
                    else if (numPlasma.Value >= 10)
                    {
                        addition = addition + (char)(numPlasma.Value + 56);
                    }
                }
                tempstring = tempstring.Insert(3, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numFlamer_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 6 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(5, 1);
                if (0 <= numFlamer.Value && numFlamer.Value <= 10)
                {
                    addition = addition + (char)(numFlamer.Value + 80);
                }
                else if (numFlamer.Value >= 11)
                {
                    addition = addition + (char)(numFlamer.Value + 54);
                }
                tempstring = tempstring.Insert(5, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 5 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(4, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1)) * 4) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1) * 4)) + 48);
                    }
                    else if (ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1)) * 4) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1)) * 4) + 56);
                    }
                }
                else
                {
                    if (numFlamer.Value <= 9)
                    {
                        addition = addition + (char)(numFlamer.Value + 48);
                    }
                    else if (numFlamer.Value >= 10)
                    {
                        addition = addition + (char)(numFlamer.Value + 56);
                    }
                }
                tempstring = tempstring.Insert(4, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numBurster_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 7 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(6, 1);
                if (0 <= numBurster.Value && numBurster.Value <= 10)
                {
                    addition = addition + (char)(numBurster.Value + 80);
                }
                else if (numBurster.Value >= 11)
                {
                    addition = addition + (char)(numBurster.Value + 54);
                }
                tempstring = tempstring.Insert(6, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 6 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(5, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)numBurster.Value, (((int)numEngine.Value - 1)) * 5) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numBurster.Value, (((int)numEngine.Value - 1) * 5)) + 48);
                    }
                    else if (ModSum((int)numBurster.Value, (((int)numEngine.Value - 1)) * 5) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numBurster.Value, (((int)numEngine.Value - 1)) * 5) + 56);
                    }
                }
                else
                {
                    if (numBurster.Value <= 9)
                    {
                        addition = addition + (char)(numBurster.Value + 48);
                    }
                    else if (numBurster.Value >= 10)
                    {
                        addition = addition + (char)(numBurster.Value + 56);
                    }
                }
                tempstring = tempstring.Insert(5, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numMissiles_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 8 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(7, 1);
                if (0 <= numMissiles.Value && numMissiles.Value <= 9)
                {
                    addition = addition + (char)(numMissiles.Value + 81);
                }
                else if (numMissiles.Value >= 10)
                {
                    addition = addition + (char)(numMissiles.Value + 55);
                }
                tempstring = tempstring.Insert(7, addition);
                inputBox.Text = tempstring;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";

                tempstring = inputBox.Text;
                for (int z = 0; z < 7 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(6, 1);
                if (inputBox.Text.Length >= 8)
                {
                    if (ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1)) * 6) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1) * 6)) + 48);
                    }
                    else if (ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1)) * 6) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1)) * 6) + 56);
                    }
                }
                else
                {
                    if (numMissiles.Value <= 9)
                    {
                        addition = addition + (char)(numMissiles.Value + 48);
                    }
                    else if (numMissiles.Value >= 10)
                    {
                        addition = addition + (char)(numMissiles.Value + 56);
                    }
                }
                tempstring = tempstring.Insert(6, addition);
                inputBox.Text = tempstring;
            }
        }

        private void numUnknown_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                string tempstring = "", addition = "";

            tempstring = inputBox.Text;
            for (int z = 0; z < 9 - inputBox.Text.Length; z++)
            {
                tempstring = tempstring + "?";
            }

            tempstring = tempstring.Remove(8, 1);
            addition = addition + (char)(numUnknown.Value + 65);
            tempstring = tempstring.Insert(8, addition);
            inputBox.Text = tempstring;
            }
        }

        private void numEngine_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true || checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
            {
                if (checkedListBox1.GetItemChecked(0) == true || checkedListBox1.GetItemChecked(1) == true)
                {
                    string tempstring = "", addition = "";

                    tempstring = inputBox.Text;
                    for (int z = 0; z < 10 - inputBox.Text.Length; z++)
                    {
                        tempstring = tempstring + "?";
                    }

                    tempstring = tempstring.Remove(9, 1);
                    addition = addition + (char)(numEngine.Value + 65);
                    tempstring = tempstring.Insert(9, addition);
                    inputBox.Text = tempstring;
                }
                else if (checkedListBox1.GetItemChecked(2) == true || checkedListBox1.GetItemChecked(3) == true)
                {
                    string tempstring = "", addition = "";

                    tempstring = inputBox.Text;
                    for (int z = 0; z < 9 - inputBox.Text.Length; z++)
                    {
                        tempstring = tempstring + "?";
                    }

                    tempstring = tempstring.Remove(8, 1);
                    addition = addition + (char)(numEngine.Value + 65);
                    tempstring = tempstring.Insert(8, addition);
                    inputBox.Text = tempstring;
                }
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                string tempstring = "", addition = "";
                bool changeEveryWeapon = false;

                if (inputBox.Text.Length > 2)
                {
                    if (ModSum((int)num3way.Value, (((int)numHiddenEngineBU.Value - 1) * 1)) <= 9)
                    {
                        if (ModSum((int)num3way.Value, (((int)numHiddenEngineBU.Value - 1) * 1)) == (inputBox.Text[1] - 48))
                        {
                            changeEveryWeapon = true;
                        }
                        else
                        {
                            changeEveryWeapon = false;
                        }
                    }
                    else if (ModSum((int)num3way.Value, (((int)numHiddenEngineBU.Value - 1) * 1)) >= 10)
                    {
                        if (ModSum((int)num3way.Value, (((int)numHiddenEngineBU.Value - 1) * 1)) == (inputBox.Text[1] - 56))
                        {
                            changeEveryWeapon = true;
                        }
                        else
                        {
                            changeEveryWeapon = false;
                        }
                    }
                }

                tempstring = inputBox.Text;
                for (int z = 0; z < 8 - inputBox.Text.Length; z++)
                {
                    tempstring = tempstring + "?";
                }

                tempstring = tempstring.Remove(7, 1);
                if (numEngine.Value <= 10)
                {
                    addition = addition + (char)(numEngine.Value + 47);
                }
                else if (numEngine.Value >= 11)
                {
                    addition = addition + (char)(numEngine.Value + 55);
                }
                tempstring = tempstring.Insert(7, addition);

                if (changeEveryWeapon == true)
                {
                    addition = "";
                    tempstring = tempstring.Remove(1, 1);
                    if (ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) + 48);
                    }
                    else if (ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)num3way.Value, ((int)numEngine.Value - 1)) + 56);
                    }
                    tempstring = tempstring.Insert(1, addition);

                    addition = "";
                    tempstring = tempstring.Remove(2, 1);
                    if (ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1) * 2)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1) * 2)) + 48);
                    }
                    else if (ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1) * 2)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numBouncer.Value, (((int)numEngine.Value - 1) * 2)) + 56);
                    }
                    tempstring = tempstring.Insert(2, addition);

                    addition = "";
                    tempstring = tempstring.Remove(3, 1);
                    if (ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1) * 3)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1) * 3)) + 48);
                    }
                    else if (ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1) * 3)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numPlasma.Value, (((int)numEngine.Value - 1) * 3)) + 56);
                    }
                    tempstring = tempstring.Insert(3, addition);

                    addition = "";
                    tempstring = tempstring.Remove(4, 1);
                    if (ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1) * 4)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1) * 4)) + 48);
                    }
                    else if (ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1) * 4)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numFlamer.Value, (((int)numEngine.Value - 1) * 4)) + 56);
                    }
                    tempstring = tempstring.Insert(4, addition);

                    addition = "";
                    tempstring = tempstring.Remove(5, 1);
                    if (ModSum((int)numBurster.Value, (((int)numEngine.Value - 1) * 5)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numBurster.Value, (((int)numEngine.Value - 1) * 5)) + 48);
                    }
                    else if (ModSum((int)numBurster.Value, (((int)numEngine.Value - 1) * 5)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numBurster.Value, (((int)numEngine.Value - 1) * 5)) + 56);
                    }
                    tempstring = tempstring.Insert(5, addition);

                    addition = "";
                    tempstring = tempstring.Remove(6, 1);
                    if (ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1) * 6)) <= 9)
                    {
                        addition = addition + (char)(ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1) * 6)) + 48);
                    }
                    else if (ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1) * 6)) >= 10)
                    {
                        addition = addition + (char)(ModSum((int)numMissiles.Value, (((int)numEngine.Value - 1) * 6)) + 56);
                    }
                    tempstring = tempstring.Insert(6, addition);
                }

                inputBox.Text = tempstring;
                if (numHiddenEngineBU.Value != 0)
                {
                    numHiddenEngineBU.Value = numEngine.Value;
                }
            }
        }
    }
}
