using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomSoundBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileLocation = null; //must be initialized or SoundPlayer freaks out

            //button context (put in separate function later)
            switch (((Control)sender).Name)
            {
                case "button1":
                    FileLocation = AudioData.AudioLocation;
                    break;

                case "button2":
                    FileLocation = AudioData.AudioLocation2;
                    break;

                case "button3":
                    FileLocation = AudioData.AudioLocation3;
                    break;

                case "button4":
                    FileLocation = AudioData.AudioLocation4;
                    break;

                case "button5":
                    FileLocation = AudioData.AudioLocation5;
                    break;

                case "button6":
                    FileLocation = AudioData.AudioLocation6;
                    break;

                case "button7":
                    FileLocation = AudioData.AudioLocation7;
                    break;

                case "button8":
                    FileLocation = AudioData.AudioLocation8;
                    break;

                case "button9":
                    FileLocation = AudioData.AudioLocation9;
                    break;

                case "button10":
                    FileLocation = AudioData.AudioLocation10;
                    break;

                case "button11":
                    FileLocation = AudioData.AudioLocation11;
                    break;

                case "button12":
                    FileLocation = AudioData.AudioLocation12;
                    break;

                case "button13":
                    FileLocation = AudioData.AudioLocation13;
                    break;

                case "button14":
                    FileLocation = AudioData.AudioLocation14;
                    break;

                case "button15":
                    FileLocation = AudioData.AudioLocation15;
                    break;

                case "button16":
                    FileLocation = AudioData.AudioLocation16;
                    break;
            }

            //executes if valid file type
            try
            {
                //create a new instances of the sound player
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer(FileLocation);
                Player.Play();
                
            }
            catch
            {
                //MessageBox.Show("No audiofile selected or not valid file type", "opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
  
        //row 1 column 1
        private void column1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation = Assign.FileName;
            }
        }

        //row 1 column 2
        private void column2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation2 = Assign.FileName;
            }
        }

        //row 1 column 3
        private void column3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation3 = Assign.FileName;
            }
        }

        //row 1 column 4
        private void column4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation4 = Assign.FileName;
            }
        }

        //row 2 column 1
        private void column1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation5 = Assign.FileName;
            }
        }

        //row 2 column 2
        private void column2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation6 = Assign.FileName;
            }
        }

        //row 2 column 3
        private void column3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation7 = Assign.FileName;
            }
        }

        //row 2 column 4
        private void column4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation8 = Assign.FileName;
            }
        }

        //row 3 column 1
        private void column1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation9 = Assign.FileName;
            }
        }

        //row 3 column 2
        private void column2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation10 = Assign.FileName;
            }
        }

        //row 3 column 3
        private void column3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation11 = Assign.FileName;
            }
        }

        //row 3 column 4
        private void column4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation12 = Assign.FileName;
            }
        }

        //row 4 column 1
        private void column1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation13 = Assign.FileName;
            }
        }

        //row 4 column 2
        private void column2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation14 = Assign.FileName;
            }
        }

        //row 4 column 3
        private void column3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation15 = Assign.FileName;
            }
        }

        //row 4 column 4
        private void column4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog Assign = new OpenFileDialog();
            if (Assign.ShowDialog() == DialogResult.OK)
            {
                AudioData.AudioLocation16 = Assign.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //nothing
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            if (load.ShowDialog() == DialogResult.OK)
            {
                string[] loadedAudio  = File.ReadAllLines(load.FileName);

                AudioData.AudioLocation = loadedAudio[0];
                AudioData.AudioLocation2 = loadedAudio[1];
                AudioData.AudioLocation3 = loadedAudio[2];
                AudioData.AudioLocation4 = loadedAudio[3];
                AudioData.AudioLocation5 = loadedAudio[4];
                AudioData.AudioLocation6 = loadedAudio[5];
                AudioData.AudioLocation7 = loadedAudio[6];
                AudioData.AudioLocation8 = loadedAudio[7];
                AudioData.AudioLocation9 = loadedAudio[8];
                AudioData.AudioLocation10 = loadedAudio[9];
                AudioData.AudioLocation11 = loadedAudio[10];
                AudioData.AudioLocation12 = loadedAudio[11];
                AudioData.AudioLocation13 = loadedAudio[12];
                AudioData.AudioLocation14 = loadedAudio[13];
                AudioData.AudioLocation15 = loadedAudio[14];
                AudioData.AudioLocation16 = loadedAudio[15];
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //organize the audio data file locations
            string[] toSave =
            {
                AudioData.AudioLocation, AudioData.AudioLocation2, AudioData.AudioLocation3, AudioData.AudioLocation4,
                AudioData.AudioLocation5, AudioData.AudioLocation6, AudioData.AudioLocation7, AudioData.AudioLocation8,
                AudioData.AudioLocation9, AudioData.AudioLocation10, AudioData.AudioLocation11, AudioData.AudioLocation12,
                AudioData.AudioLocation13, AudioData.AudioLocation14, AudioData.AudioLocation15, AudioData.AudioLocation16
            };

            //create new instance of save file prompt
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)   //if created successfully
            {

                //override the original file
                string path = save.FileName;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                //append each string to a new line
                for (int i=0; i < 16; i++)
                {
                    string appendText = toSave[i] + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                }

            }
        }
    }
}
