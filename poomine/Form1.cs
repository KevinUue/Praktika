using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace poomine
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Enne mängimise alustamist vajuta START nuppu, et mäng õigesti töötaks!", "START", MessageBoxButtons.OK);
        }
        

        string word = "";
        List<Label> labels = new List<Label>();
        int amount = 0;
        int guessesLeft = 9;

        enum BodyParts
        {
            Head,
            Left_Eye,
            Right_Eye,
            Mouth,
            Body,
            Right_Arm,
            Left_Arm,
            Right_Leg,
            left_Leg
        }

        void DrawHangPost()
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 10);
            g.DrawLine(p, new Point(198, 321), new Point(198, 5));
            g.DrawLine(p, new Point(203, 5), new Point(80, 5));
            g.DrawLine(p, new Point(80, 0), new Point(80, 70));
            GetRandomWord();
        }

        void DrawBodyParts(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Brown, 2);
            if(bp == BodyParts.Head)
            {
                g.DrawEllipse(p, 55, 70, 55, 55);
            }
            else if(bp == BodyParts.Left_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Brown);
                g.FillEllipse(s, 70, 85, 5, 5);
            }
            else if(bp == BodyParts.Right_Eye)
            {
                SolidBrush s = new SolidBrush(Color.Brown);
                g.FillEllipse(s, 90, 85, 5, 5);
            }
            else if(bp == BodyParts.Mouth)
            {
                g.DrawArc(p, 63, 100, 40, 10, 25, 360);
            }
            else if(bp == BodyParts.Body)
            {
                g.DrawLine(p, new Point(83, 127), new Point(83, 240));
            }
            else if(bp == BodyParts.Left_Arm)
            {
                g.DrawLine(p, new Point(83, 150), new Point(53, 120));
            }
            else if(bp == BodyParts.Right_Arm)
            {
                g.DrawLine(p, new Point(83, 150), new Point(112, 120));
            }
            else if(bp == BodyParts.left_Leg)
            {
                g.DrawLine(p, new Point(83, 240), new Point(62, 275));
            }
            else if(bp == BodyParts.Right_Leg)
            {
                g.DrawLine(p, new Point(83, 240), new Point(105, 275));
            }

        }
        void MakeLabels()
        {
            word = GetRandomWord();
            char[] chars = word.ToCharArray();
            int between = 250 / chars.Length;
            for (int i = 0; i < chars.Length; i++)
            {
                labels.Add(new Label()); 
                labels[i].Location = new Point((i * between) + 55, 150); 
                labels[i].Text = "___"; 
                labels[i].Parent = groupBox2; 
                labels[i].BringToFront(); 
                labels[i].CreateControl(); 
            }
            lbl_Length.Text = "Sõna pikkus: " + (chars.Length).ToString();
            lbl_Guesses.Text = "Arvamisi järgi: " + guessesLeft;

        }
        string GetRandomWord()
        {
            string[] WordList = File.ReadAllLines(@"C:\Users\opilane\Documents\kevin\poomine\Praktika\sõnad.txt");
            string[] words = WordList;
            Random ran = new Random();
            return words[ran.Next(0, words.Length - 1)];
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawHangPost();
            MakeLabels();
        }
        List<string> guessedLetters = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_Word.Text == word)
            {
                MessageBox.Show("Palju õnne! Te võitsite mängu!", "Palju Õnne!", MessageBoxButtons.OK);
                Environment.Exit(1);
            }
            else
            {
                MessageBox.Show("Sõna mille valisite on vale!");
                DrawBodyParts((BodyParts)amount);
                amount++;
                guessesLeft--;
                lbl_Guesses.Text = "Arvamisi järgi: " + guessesLeft;
                if(amount == 9)
                {
                    MessageBox.Show("Teie valikud said otsa! Sõna oli " + word, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }

        }
        void ResetGame()
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
            GetRandomWord();
            MakeLabels();
            DrawHangPost();
            lbl_Missed.Text = "Valesti arvatud tähed:  ";
            txt_Letter.Text = "";
            txt_Word.Text = "";
            guessesLeft = 9;
            amount = 0;
            lbl_Guesses.Text = "Arvamisi järgi: ";

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Missed_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Oled kindel, et tahad lahkuda?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btn_Letter_Click_Click_1(object sender, EventArgs e)
        {
            Convert.ToChar(txt_Letter.Text);
            char userletter = txt_Letter.Text.ToLower().ToCharArray()[0];
            bool letCheck = false;
            bool multCheck = false;
            string convUsrLet;
            if (!char.IsLetter(userletter))
            {
                MessageBox.Show("Sisestada tuleb ainult tähti!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                letCheck = true;
            }
            else
            {
                convUsrLet = userletter.ToString();
                if (guessedLetters.Contains(convUsrLet))
                {
                    multCheck = true;
                }

                if (multCheck == true)
                {
                    MessageBox.Show("Te olete selle tähe juba ära arvanud!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    multCheck = false;
                }
                else if (letCheck == true)
                {
                    MessageBox.Show("Palun sisestage mingi täht!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    guessedLetters.Add(convUsrLet);
                    if (word.Contains(userletter))
                    {
                        char[] letters = word.ToCharArray();
                        for (int i = 0; i < letters.Length; i++)
                        {
                            if (letters[i] == userletter)
                                labels[i].Text = userletter.ToString();
                        }
                        foreach (Label l in labels)
                            if (l.Text == "___") return;
                        MessageBox.Show("Palju õnne! Te võitsite mängu!", "Palju Õnne", MessageBoxButtons.OK);
                        Environment.Exit(1);
                    }
                    else
                    {
                        MessageBox.Show("Täht mille valisite ei ole sõnas sees!");
                        lbl_Missed.Text += " " + userletter.ToString() + ",";
                        DrawBodyParts((BodyParts)amount);
                        amount++;
                        guessesLeft--;
                        lbl_Guesses.Text = "Arvamisi järgi: " + guessesLeft;
                        if (amount == 9)
                        {
                            MessageBox.Show("Tegite liiga palju valesid valikuid! Sõna oli: " + word, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(1);
                        }

                    }
                }
            }

        }
    }
}
