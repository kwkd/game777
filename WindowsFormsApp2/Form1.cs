using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int opened_counter;
        int[] pairs;
        int[] opened;
        int[] game_pairs;
        PictureBox[] array_picbox;
        public Form1()
        {
            opened_counter = 0;
            InitializeComponent();
            pairs = new int[8];
            opened = new int[2];
            game_pairs = new int[16];
            array_picbox = new PictureBox[16];
            array_picbox[0] = pictureBox1;
            array_picbox[1] = pictureBox2;
            array_picbox[2] = pictureBox3;
            array_picbox[3] = pictureBox4;
            array_picbox[4] = pictureBox5;
            array_picbox[5] = pictureBox6;
            array_picbox[6] = pictureBox7;
            array_picbox[7] = pictureBox8;
            array_picbox[8] = pictureBox9;
            array_picbox[9] = pictureBox10;
            array_picbox[10] = pictureBox11;
            array_picbox[11] = pictureBox12;
            array_picbox[12] = pictureBox13;
            array_picbox[13] = pictureBox14;
            array_picbox[14] = pictureBox15;
            array_picbox[15] = pictureBox16;


        }
        public void hide()
        {
            pictureBox1.BackgroundImage = imageList1.Images[6];
            pictureBox2.BackgroundImage = imageList1.Images[6];
            pictureBox3.BackgroundImage = imageList1.Images[6];
            pictureBox4.BackgroundImage = imageList1.Images[6];
            pictureBox5.BackgroundImage = imageList1.Images[6];
            pictureBox6.BackgroundImage = imageList1.Images[6];
            pictureBox7.BackgroundImage = imageList1.Images[6];
            pictureBox8.BackgroundImage = imageList1.Images[6];
            pictureBox9.BackgroundImage = imageList1.Images[6];
            pictureBox10.BackgroundImage = imageList1.Images[6];
            pictureBox11.BackgroundImage = imageList1.Images[6];
            pictureBox12.BackgroundImage = imageList1.Images[6];
            pictureBox13.BackgroundImage = imageList1.Images[6];
            pictureBox14.BackgroundImage = imageList1.Images[6];
            pictureBox15.BackgroundImage = imageList1.Images[6];
            pictureBox16.BackgroundImage = imageList1.Images[6];
        }
        
        private void Form1_Load(object sender, EventArgs e)
            
        {
            hide();
            //1-----------------------------------------------------
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = panel1.Width/ 4; 
            pictureBox1.Height = panel1.Height / 4;

            pictureBox2.Top = 0;
            pictureBox2.Left = panel1.Width / 4;
            pictureBox2.Width = panel1.Width / 4; 
            pictureBox3.Height = panel1.Height / 4;

            pictureBox3.Top = 0;
            pictureBox3.Left = panel1.Width / 2;
            pictureBox3.Width = panel1.Width / 4; 
            pictureBox3.Height = panel1.Height / 4;

            pictureBox4.Top = 0;
            pictureBox4.Left = panel1.Width *3/ 4;
            pictureBox4.Width = panel1.Width / 4; 
            pictureBox4.Height = panel1.Height / 4;
            //2-----------------------------------------------------
            pictureBox5.Top = panel1.Height / 4;
            pictureBox5.Left = 0;
            pictureBox5.Width = panel1.Width / 4;
            pictureBox5.Height = panel1.Height / 4;

            pictureBox6.Top = panel1.Height / 4;
            pictureBox6.Left = panel1.Width / 4;
            pictureBox6.Width = panel1.Width / 4;
            pictureBox6.Height = panel1.Height / 4;

            pictureBox7.Top = panel1.Height / 4;
            pictureBox7.Left = panel1.Width / 2;
            pictureBox7.Width = panel1.Width / 4;
            pictureBox7.Height = panel1.Height / 4;

            pictureBox8.Top = panel1.Height / 4;
            pictureBox8.Left = panel1.Width * 3 / 4;
            pictureBox8.Width = panel1.Width / 4;
            pictureBox8.Height = panel1.Height / 4;
            //3-----------------------------------------------------
            pictureBox9.Top = panel1.Height / 2;
            pictureBox9.Left = 0;
            pictureBox9.Width = panel1.Width / 4;
            pictureBox9.Height = panel1.Height / 4;

            pictureBox10.Top = panel1.Height / 2;
            pictureBox10.Left = panel1.Width / 4;
            pictureBox10.Width = panel1.Width / 4;
            pictureBox10.Height = panel1.Height / 4;

            pictureBox11.Top = panel1.Height / 2;
            pictureBox11.Left = panel1.Width / 2;
            pictureBox11.Width = panel1.Width / 4;
            pictureBox11.Height = panel1.Height / 4;

            pictureBox12.Top = panel1.Height / 2;
            pictureBox12.Left = panel1.Width * 3 / 4;
            pictureBox12.Width = panel1.Width / 4;
            pictureBox12.Height = panel1.Height / 4;
            //4-----------------------------------------------------
            pictureBox13.Top = panel1.Height *3/ 4;
            pictureBox13.Left = 0;
            pictureBox13.Width = panel1.Width / 4;
            pictureBox13.Height = panel1.Height / 4;

            pictureBox14.Top = panel1.Height * 3 / 4;
            pictureBox14.Left = panel1.Width / 4;
            pictureBox14.Width = panel1.Width / 4;
            pictureBox14.Height = panel1.Height / 4;

            pictureBox15.Top = panel1.Height * 3 / 4;
            pictureBox15.Left = panel1.Width / 2;
            pictureBox15.Width = panel1.Width / 4;
            pictureBox15.Height = panel1.Height / 4;

            pictureBox16.Top = panel1.Height * 3 / 4;
            pictureBox16.Left = panel1.Width * 3 / 4;
            pictureBox16.Width = panel1.Width / 4;
            pictureBox16.Height = panel1.Height / 4;

            новаяToolStripMenuItem_Click(null, null);
        }

        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opened_counter = 0;
            Random R;
            R = new Random();
            for (int i = 0; i < 8; i++)
            {
                pairs[i] = R.Next(6);
            }
            for (int i = 0; i < 16; i++)
            {
                array_picbox[i].Visible = true;
                game_pairs[i] = -1;
            }
            int used = 0;
            while (used!= 8)
            {
                int n1 = R.Next(16);
                int n2 = R.Next(16);
                if (n2 == n1) continue;
                if (game_pairs[n1] == -1 && game_pairs[n2] == -1)
                {
                    game_pairs[n1] = game_pairs[n2] = pairs[used];
                    used++;
                }
            }
            hide();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);
            if (opened_counter ==1)
            {
                if (opened[0] == index) return;
            }
            if (opened_counter == 2)
            {
                opened_counter = 0;
                hide();
            }
            opened[opened_counter] = index;
            opened_counter++;
            if (opened_counter == 2)
            {
                if (game_pairs[opened[0]] == game_pairs[opened[1]])
                    {
                    array_picbox[opened[0]].Visible = false;
                    array_picbox[opened[1]].Visible = false;
                    opened_counter = 0;
                    hide();
                }
            }
            p.BackgroundImage = imageList1.Images[game_pairs[index]];

        }
    }
}
