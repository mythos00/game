
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private bool systemOn = false;
        private bool isMoving = false;
        private int originalX;
        private int originalY;
        private int lightOriginalX;
        private int lightOriginalY;

        private SoundPlayer currentPlayer;

        private string enisSound = @"C:\Users\Nuran\Downloads\inishazirliklari.wav";
        private string turbulenceSound = @"C:\Users\Nuran\Downloads\turbulans.wav";
        private string beltsSound = @"C:\Users\Nuran\Downloads\kemerler.wav";
        private string thanksSound = @"C:\Users\Nuran\Downloads\tesekkurler.wav";
        private string beepSound = @"C:\Users\Nuran\Downloads\beep.wav";

        public Form1()
        {
            InitializeComponent();

            originalX = pictureBox1.Location.X;
            originalY = pictureBox1.Location.Y;

            lightOriginalX = pictureBox2.Location.X;
            lightOriginalY = pictureBox2.Location.Y;

            timer1.Interval = 20;
            timer1.Stop();

            button5.Text = "ON";
            pictureBox2.Visible = false;
        }

        // Ses faylini oxutmaq
        private void PlaySound(string path, bool loop = false)
        {
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show(
                        "Ses fayli tapilmadi:\n" + path,
                        "Xeta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (currentPlayer != null)
                {
                    currentPlayer.Stop();
                    currentPlayer.Dispose();
                    currentPlayer = null;
                }

                currentPlayer = new SoundPlayer(path);

                if (loop)
                    currentPlayer.PlayLooping();
                else
                    currentPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ses xetasi: " + ex.Message);
            }
        }

        // ON / OFF
        private void button5_Click(object sender, EventArgs e)
        {
            systemOn = !systemOn;

            if (systemOn)
            {
                button5.Text = "OFF";
                pictureBox2.Visible = true;
            }
            else
            {
                button5.Text = "ON";

                timer1.Stop();
                isMoving = false;

                pictureBox1.Location = new Point(originalX, originalY);

                // Isigi sondur ve ilkin yerine qaytar
                pictureBox2.Visible = false;
                pictureBox2.Location = new Point(
                    lightOriginalX,
                    lightOriginalY
                );

                if (currentPlayer != null)
                {
                    currentPlayer.Stop();
                    currentPlayer.Dispose();
                    currentPlayer = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Turbulans - yalniz ses
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!systemOn) return;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!systemOn) return;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!systemOn) return;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!systemOn) return;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!systemOn) return;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!systemOn || !isMoving)
            {
                timer1.Stop();
                return;
            }

            int newY = pictureBox1.Location.Y - 2;

            if (newY <= 0)
            {
                newY = 0;
                isMoving = false;
                timer1.Stop();
            }

            // Teyyarenin yeni koordinati
            pictureBox1.Location = new Point(
                pictureBox1.Location.X,
                newY
            );

            // Isiq da teyyare ile birlikde hereket edir
            if (pictureBox2.Visible)
            {
                pictureBox2.Location = new Point(
                    pictureBox2.Location.X,
                    pictureBox2.Location.Y - 2
                );
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                PlaySound(enisSound);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                PlaySound(turbulenceSound);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                PlaySound(beltsSound);
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                PlaySound(thanksSound);
            }
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                PlaySound(beepSound);
            }
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Əvvəlcə ON düyməsinə bas!");
                return;
            }

            isMoving = true;
            timer1.Start();
        }
        

        private void button7_Click_2(object sender, EventArgs e)
        {
            if (!systemOn)
            {
                MessageBox.Show("Sistemi on edin ve yeniden deneyin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                isMoving = false;
                timer1.Stop();

                if (currentPlayer != null)
                {
                    currentPlayer.Stop();
                    currentPlayer.Dispose();
                    currentPlayer = null;
                }
            }
        }
    }
}

