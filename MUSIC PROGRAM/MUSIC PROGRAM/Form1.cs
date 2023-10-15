using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace MUSIC_PROGRAM
{
    public partial class Form1 : Form
    {
        #region NOTES FOR FUTURE FUNCTIONALITY

        /*  C 261.6
        *  C# 277.2
        *  D 293.7
        *  D# 311.1
        *  E 329.6
        *  F 349.2
        *  F# 370.0
        *  G 392.0
        *  G# 415.3
        *  A 440.0
        *  A# 466.2
        *  B 493.9
        *  C 523.2
        *
        *   TODO:  Change the system beeps to actual notes with SoundPlayer
        *   TODO:  Create a timer to keep beep going based on the length of the button selection (be able to stop the beep as well).
        *   TODO:  Find another way for button events to work that doesn't depend on their backcolor.
        *
        *  "The closest you could come is the SoundPlayer, and all that will do is
        *   play a fixed WAV file.  You can create the WAV format file in memory as a
        *   MemoryStream, but you have to have the complete data ahead of time so that
        *   the header of the WAV data is properly initialized."
        */
        
        #endregion

        #region GLOBAL VARIABLES

        bool[] notes = new bool[24];    //  Array for all 24 notes
             
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region FIRST OCTAVE WHITE KEYS

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter in the Beep function.
                button1.BackColor = Color.Gold;
                richTextBox1.AppendText("C1 ");
                notes[0] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button1.BackColor = Color.White;
                if (richTextBox1.Text.Contains("C1 "))
                {
                    string temp = richTextBox1.Text.Replace("C1 ", "");
                    richTextBox1.Text = temp;
                    notes[0] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button2.BackColor = Color.Gold;
                richTextBox1.AppendText("D1 ");
                notes[2] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button2.BackColor = Color.White;
                if (richTextBox1.Text.Contains("D1 "))
                {
                    string temp = richTextBox1.Text.Replace("D1 ", "");
                    richTextBox1.Text = temp;
                    notes[2] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button3.BackColor = Color.Gold;
                richTextBox1.AppendText("E1 ");
                notes[4] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button3.BackColor = Color.White;
                if (richTextBox1.Text.Contains("E1 "))
                {
                    string temp = richTextBox1.Text.Replace("E1 ", "");
                    richTextBox1.Text = temp;
                    notes[4] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button4.BackColor = Color.Gold;
                richTextBox1.AppendText("F1 ");
                notes[5] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button4.BackColor = Color.White;
                if (richTextBox1.Text.Contains("F1 "))
                {
                    string temp = richTextBox1.Text.Replace("F1 ", "");
                    richTextBox1.Text = temp;
                    notes[5] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button5.BackColor = Color.Gold;
                richTextBox1.AppendText("G1 ");
                notes[7] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button5.BackColor = Color.White;
                if (richTextBox1.Text.Contains("G1 "))
                {
                    string temp = richTextBox1.Text.Replace("G1 ", "");
                    richTextBox1.Text = temp;
                    notes[7] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button6.BackColor = Color.Gold;
                richTextBox1.AppendText("A1 ");
                notes[9] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button6.BackColor = Color.White;
                if (richTextBox1.Text.Contains("A1 "))
                {
                    string temp = richTextBox1.Text.Replace("A1 ", "");
                    richTextBox1.Text = temp;
                    notes[9] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button7.BackColor = Color.Gold;
                richTextBox1.AppendText("B1 ");
                notes[11] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button7.BackColor = Color.White;
                if (richTextBox1.Text.Contains("B1 "))
                {
                    string temp = richTextBox1.Text.Replace("B1 ", "");
                    richTextBox1.Text = temp;
                    notes[11] = false;
                    ActiveNotes(notes);
                }
            }
        }

        #endregion

        #region SECOND OCTAVE WHITE KEYS

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button8.BackColor = Color.Gold;
                richTextBox1.AppendText("C2 ");
                notes[12] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button8.BackColor = Color.White;
                if (richTextBox1.Text.Contains("C2 "))
                {
                    string temp = richTextBox1.Text.Replace("C2 ", "");
                    richTextBox1.Text = temp;
                    notes[12] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button9.BackColor = Color.Gold;
                richTextBox1.AppendText("D2 ");
                notes[14] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button9.BackColor = Color.White;
                if (richTextBox1.Text.Contains("D2 "))
                {
                    string temp = richTextBox1.Text.Replace("D2 ", "");
                    richTextBox1.Text = temp;
                    notes[14] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button10.BackColor = Color.Gold;
                richTextBox1.AppendText("E2 ");
                notes[16] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button10.BackColor = Color.White;
                if (richTextBox1.Text.Contains("E2 "))
                {
                    string temp = richTextBox1.Text.Replace("E2 ", "");
                    richTextBox1.Text = temp;
                    notes[16] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button11.BackColor = Color.Gold;
                richTextBox1.AppendText("F2 ");
                notes[17] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button11.BackColor = Color.White;
                if (richTextBox1.Text.Contains("F2 "))
                {
                    string temp = richTextBox1.Text.Replace("F2 ", "");
                    richTextBox1.Text = temp;
                    notes[17] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button12.BackColor = Color.Gold;
                richTextBox1.AppendText("G2 ");
                notes[19] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button12.BackColor = Color.White;
                if (richTextBox1.Text.Contains("G2 "))
                {
                    string temp = richTextBox1.Text.Replace("G2 ", "");
                    richTextBox1.Text = temp;
                    notes[19] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button13.BackColor = Color.Gold;
                richTextBox1.AppendText("A2 ");
                notes[21] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button13.BackColor = Color.White;
                if (richTextBox1.Text.Contains("A2 "))
                {
                    string temp = richTextBox1.Text.Replace("A2 ", "");
                    richTextBox1.Text = temp;
                    notes[21] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.White)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button14.BackColor = Color.Gold;
                richTextBox1.AppendText("B2 ");
                notes[23] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button14.BackColor = Color.White;
                if (richTextBox1.Text.Contains("B2 "))
                {
                    string temp = richTextBox1.Text.Replace("B2 ", "");
                    richTextBox1.Text = temp;
                    notes[23] = false;
                    ActiveNotes(notes);
                }
            }
        }

        #endregion

        #region FIRST OCTAVE BLACK KEYS

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button15.BackColor = Color.Gold;
                button15.ForeColor = Color.Black;
                richTextBox1.AppendText("C#/Db1 ");
                notes[1] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button15.BackColor = Color.Black;
                button15.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("C#/Db1 "))
                {
                    string temp = richTextBox1.Text.Replace("C#/Db1 ", "");
                    richTextBox1.Text = temp;
                    notes[1] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button16.BackColor = Color.Gold;
                button16.ForeColor = Color.Black;
                richTextBox1.AppendText("D#/Eb1 ");
                notes[3] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button16.BackColor = Color.Black;
                button16.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("D#/Eb1 "))
                {
                    string temp = richTextBox1.Text.Replace("D#/Eb1 ", "");
                    richTextBox1.Text = temp;
                    notes[3] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button17.BackColor = Color.Gold;
                button17.ForeColor = Color.Black;
                richTextBox1.AppendText("F#/Gb1 ");
                notes[6] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button17.BackColor = Color.Black;
                button17.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("F#/Gb1 "))
                {
                    string temp = richTextBox1.Text.Replace("F#/Gb1 ", "");
                    richTextBox1.Text = temp;
                    notes[6] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button18.BackColor = Color.Gold;
                button18.ForeColor = Color.Black;
                richTextBox1.AppendText("G#/Ab1 ");
                notes[8] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button18.BackColor = Color.Black;
                button18.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("G#/Ab1 "))
                {
                    string temp = richTextBox1.Text.Replace("G#/Ab1 ", "");
                    richTextBox1.Text = temp;
                    notes[8] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button19.BackColor = Color.Gold;
                button19.ForeColor = Color.Black;
                richTextBox1.AppendText("A#/Bb1 ");
                notes[10] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button19.BackColor = Color.Black;
                button19.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("A#/Bb1 "))
                {
                    string temp = richTextBox1.Text.Replace("A#/Bb1 ", "");
                    richTextBox1.Text = temp; 
                    notes[10] = false;
                    ActiveNotes(notes);
                }
            }
        }

        #endregion

        #region SECOND OCTAVE BLACK KEYS

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button20.BackColor = Color.Gold;
                button20.ForeColor = Color.Black;
                richTextBox1.AppendText("C#/Db2 ");
                notes[13] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button20.BackColor = Color.Black;
                button20.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("C#/Db2 "))
                {
                    string temp = richTextBox1.Text.Replace("C#/Db2 ", "");
                    richTextBox1.Text = temp;
                    notes[13] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button21.BackColor = Color.Gold;
                button21.ForeColor = Color.Black;
                richTextBox1.AppendText("D#/Eb2 ");
                notes[15] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button21.BackColor = Color.Black;
                button21.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("D#/Eb2 "))
                {
                    string temp = richTextBox1.Text.Replace("D#/Eb2 ", "");
                    richTextBox1.Text = temp;
                    notes[15] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button22.BackColor = Color.Gold;
                button22.ForeColor = Color.Black;
                richTextBox1.AppendText("F#/Gb2 ");
                notes[18] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button22.BackColor = Color.Black;
                button22.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("F#/Gb2 "))
                {
                    string temp = richTextBox1.Text.Replace("F#/Gb2 ", "");
                    richTextBox1.Text = temp;
                    notes[18] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button23.BackColor = Color.Gold;
                button23.ForeColor = Color.Black;
                richTextBox1.AppendText("G#/Ab2 ");
                notes[20] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button23.BackColor = Color.Black;
                button23.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("G#/Ab2 "))
                {
                    string temp = richTextBox1.Text.Replace("G#/Ab2 ", "");
                    richTextBox1.Text = temp;
                    notes[20] = false;
                    ActiveNotes(notes);
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Black)
            {
                // Button is selected and is true
                //  Console.Beep(262, 500);
                //  TODO:  Feed timer into an int variable and assign as the second parameter 
                button24.BackColor = Color.Gold;
                button24.ForeColor = Color.Black;
                richTextBox1.AppendText("A#/Bb2 ");
                notes[22] = true;
                ActiveNotes(notes);
            }
            else
            {
                //  Button is de-selected and is false
                button24.BackColor = Color.Black;
                button24.ForeColor = Color.White;
                if (richTextBox1.Text.Contains("A#/Bb2 "))
                {
                    string temp = richTextBox1.Text.Replace("A#/Bb2 ", "");
                    richTextBox1.Text = temp;
                    notes[22] = false;
                    ActiveNotes(notes);
                }
            }
        }

        #endregion

        #region  METHODS THAT NEED TO BE CALLED ON EVERY BUTTON PUSH (MOSTLY IN THIS ORDER)

        // WORKING METHOD. CONSIDER MOVING INTERVAL CODE OUT OF METHOD.
        public int[] ActiveNotes(bool[] pressedNotes)
        {
            bool root = false;
            int rootNote = 0;
            int j = 0;
            int[] workingIntervals = new int[24];
           
            // This loop captures the root note as the first true value from the left and continues capturing true value notes, assigning them values
            for (int i = 0; i < pressedNotes.Length; i++)
            {                
                //  Root note captured
                if (pressedNotes[i] && !root)
                {
                    rootNote = i;
                    root = true;       
                }
                //  Other active notes
                else if (pressedNotes[i] && root)
                {
                    workingIntervals[j] = (i - rootNote);
                    j++;
                }
            }

            //TO DO:  This Section just outputs the raw semitones to the richtextbox and should be moved to another method completely.
            richTextBox2.Clear();
            foreach (int k in workingIntervals)
            {
                if (k == 10 || k == 20)
                    richTextBox2.AppendText(k.ToString() + ' ');
                else
                    richTextBox2.AppendText(k.ToString().TrimEnd('0',' ')+ ' ');
            }
            return workingIntervals;
        }

        // This should be called only if there are two notes being played.  Otherwise, the chord calculation should be called.
        public void ForIntervalsOnly(int[] forComparison)
        {
            string interval = "";
            richTextBox2.Clear();

            foreach (int i in forComparison)
            {
                switch (i)
                {       
                    case 1:
                        interval = "Min. 2nd";
                        richTextBox2.AppendText(interval + ' ');
                        break;

                    case 2:
                        interval = "Maj. 2nd";
                        break;

                    case 3:
                        interval = "Min. 3rd";
                        break;

                    case 4:
                        interval = "Maj. 3rd";
                        break;

                    case 5:
                        interval = "Perfect 4th";
                        break;

                    case 6:
                        interval = "Aug. 4th / Dim. 5th / Tritone";
                        break;

                    case 7:
                        interval = "Perfect 5th";
                        break;

                    case 8:
                        interval = "Aug. 5th / Min. 6th";
                        break;

                    case 9:
                        interval = "Maj. 6th";
                        break;

                    case 10:
                        interval = "Min. 7th";
                        break;

                    case 11:
                        interval = "Maj. 7th";
                        break;

                    case 12:
                        interval = "Perfect Octave";
                        break;

                    case 13:
                        interval = "Min. 9th";
                        break;

                    case 14:
                        interval = "Maj. 9th";
                        break;

                    case 15:
                        interval = "Min. 10th";
                        break;

                    case 16:
                        interval = "Maj. 10th";
                        break;

                    case 17:
                        interval = "Perfect 11th";
                        break;

                    case 18:
                        interval = "Aug. 11th / Dim. 12th";
                        break;

                    case 19:
                        interval = "Perfect 12th";
                        break;

                    case 20:
                        interval = "Aug. 12th / Min. 13th";
                        break;

                    case 21:
                        interval = "Maj. 13th";
                        break;

                    case 22:
                        interval = "Min. 14th";
                        break;

                    case 23:
                        interval = "Maj. 14th";
                        break;

                        default:
                        break;
                }
            }
        }

        public void CountNotesForSorting()  //  Will go through the array to count all true values and will then call the correct method depending on the number of notes.
        {
            /*  Condition for no notes selected (display nothing)
             *  Condition for 1 notes selected (display only the single note)
             *  Condition for 2 notes selected (interval and its inversion)
             *  Condition for 3 or more notes selected (chord and its inversions)
             *  Condition for 5 or more notes selected (scale and its modes)             
            */
        }   
        
        public void CalculateScale(bool[] notes)
        {
            /*  1) Should examine the 3rd of the scale and determine major or minor.
             *  2) If major 3rd, examine the 4ths and 7ths.
             *  3) If minor 3rd, examine the 2nd of the scale.
             *  4) If minor 2nd, examine 5th.  If major 2nd, examine 6th.
             *  5) Determine mode and track back to key center (should be one method instead of modes being it's own?)
             * 
             *  When keys are pressed, should the array be shuffled to lock in a root-3rd and build from there???
             *
            */
        }

        public void CalculateInversions()
        {


        }

        public void CalculateModes()
        {


        }

        public void ChordCompare()   //  Contains a list of all the chords I can think of to compare
        {


        }

        public void ScaleCompare()   //  Contains a list of all the scales I can think of to compare
        {


        }

        //  TODO:  Need a select statement that compares by 3rds then 2nds in order to sort into families quickly

        #endregion

    }  //  End of class
}   //  End of namespace