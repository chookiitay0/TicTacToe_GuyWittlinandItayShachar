using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_GuyWittlinandItayShachar.Properties;

namespace TicTacToe_GuyWittlinandItayShachar
{
    public partial class Form1 : Form
    {
        private bool m_IsFirstPlayer = true;
        private int tick;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public bool IsImagesMatch(Image image1, Image image2)
        {
            try
            {
                //create instance or System.Drawing.ImageConverter to convert
                //each image to a byte array
                ImageConverter converter = new ImageConverter();
                //create 2 byte arrays, one for each image
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];

                //convert images to byte array
                imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

                //now compute a hash for each image from the byte arrays
                System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
                byte[] imgHash1 = sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);

                //now let's compare the hashes
                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
                {
                    //whoops, found a non-match, exit the loop
                    //with a false value
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //we made it this far so the images must match
            return true;
        }
        public string[,] FormToMatrix()
        {
            //המטריצה המוחזרת
            string[,] picturesMatrix = new string[3, 3];
            int row, col;
            PictureBox curPicture;

            //עוברים על כלל הפקדים בטופס - נעזרים בלולאת foreach
            foreach (Control ctrl in this.Controls)
                if (ctrl is PictureBox && ctrl.Name != "BackPictureBox")
                {
                    curPicture = ctrl as PictureBox;

                    //מציאת מספר השורה והעמודה מתוך שם הפקד
                    row = int.Parse(curPicture.Name[curPicture.Name.Length - 2].ToString());
                    col = int.Parse(curPicture.Name[curPicture.Name.Length - 1].ToString());
                    picturesMatrix[row, col] = ImgToXO(curPicture.Image);
                }
            return picturesMatrix;
        }
        public string ImgToXO(Image img)
        {
            if (IsImagesMatch(img, Resources.X_Button))
                return "X";
            if (IsImagesMatch(img, Resources.O_Button))
                return "0";
            return "";
        }
        public bool CheckMatrix(string[,] S_Matrix, string s)
        {
            int countR = 0, countH = 0, countRD = 0, countSD = 0;
            for (int i = 0; i < S_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < S_Matrix.GetLength(1); j++)
                {
                    if (S_Matrix[i, j] == s)
                    {
                        countR++;
                    }
                    if (countR == 3)
                    {
                        return true;
                    }
                }
                countR = 0;
            }
            for (int i = 0; i < S_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < S_Matrix.GetLength(1); j++)
                {
                    if (S_Matrix[j, i] == s)
                    {
                        countH++;
                    }
                    if (countH == 3)
                    {
                        return true;
                    }
                }
                countH = 0;
            }
            for (int i = 0; i < S_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < S_Matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (S_Matrix[i, j] == s)
                        {
                            countRD++;
                        }
                        if (countRD == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            for (int i = 0; i < S_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < S_Matrix.GetLength(1); j++)
                {
                    if ((i + j) == (S_Matrix.GetLength(0) - 1))
                    {
                        if (S_Matrix[i, j] == s)
                        {
                            countSD++;
                        }
                    }
                    if (countSD == 3)
                    {
                        return true;
                    }
                }
            }
            return false;         
        }
        private void sign_Click(object sender, EventArgs e)
        {
            int drawcount = 0;
            PictureBox sign = sender as PictureBox;

            if (m_IsFirstPlayer)
            {
                Turns.Text = "0, Your Turn";
                sign.Image = Resources.X_Button;
                m_IsFirstPlayer = false;
                sign.Enabled = false;
                if (CheckMatrix(FormToMatrix(), "X"))
                {
                    MessageBox.Show("X, You Win");
                    timer1.Stop();
                }
            }
            else
            {
                Turns.Text = "X, Your Turn";
                sign.Image = Resources.O_Button;
                m_IsFirstPlayer = true;
                sign.Enabled = false;
                if (CheckMatrix(FormToMatrix(), "0"))
                {
                    MessageBox.Show("0, You Win");
                    timer1.Stop();
                }
            }
        }
        private void Restat_Click(object sender, EventArgs e)
        {
            m_IsFirstPlayer = true;
            Turns.Text = "X, Your Turn";
            pictureBox00.Image = Resources.None;
            pictureBox00.Enabled = true;
            pictureBox01.Image = Resources.None;
            pictureBox01.Enabled = true;
            pictureBox02.Image = Resources.None;
            pictureBox02.Enabled = true;

            pictureBox10.Image = Resources.None;
            pictureBox10.Enabled = true; 
            pictureBox11.Image = Resources.None;
            pictureBox11.Enabled = true; 
            pictureBox12.Image = Resources.None;
            pictureBox12.Enabled = true;

            pictureBox20.Image = Resources.None;
            pictureBox20.Enabled = true;
            pictureBox21.Image = Resources.None;
            pictureBox21.Enabled = true;
            pictureBox22.Image = Resources.None;
            pictureBox22.Enabled = true;

            tick = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            TheSeconds.Text = tick.ToString() + " Seconds";
        }
    }
}
