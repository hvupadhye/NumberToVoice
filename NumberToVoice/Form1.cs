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
using System.Threading;

namespace NumberToVoice
{
    public partial class frmNumberToVoice : Form
    {
        SoundPlayer player;
        public frmNumberToVoice()
        {
            InitializeComponent();
        }

        private void frmNumberToVoice_Load(object sender, EventArgs e)
        {
            player = new System.Media.SoundPlayer();
        }

        public int NumberToWords(int number)
        {
            int words = 0;
            if (number == 0)
                PlaySoundNumber(0);

            //if (number < 0)
            //    return "minus " + NumberToWords(Math.Abs(number));

            if ((number / 1000000) > 0)
            {
                words = NumberToWords(number / 1000000);//+ " million ";
                player.Stream = Properties.Resources.million;
                player.Play();
                Thread.Sleep(1500);
                number %= 1000000;

            }

            if ((number / 1000) > 0)
            {
                words = NumberToWords(number / 1000);// +" thousand ";
                player.Stream = Properties.Resources.thousand;
                player.Play();
                Thread.Sleep(1500);
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words = NumberToWords(number / 100);//+ " hundred ";
                player.Stream = Properties.Resources.hundred;
                player.Play();
                Thread.Sleep(1500);
                number %= 100;
            }

            if (number > 0)
            {
                //if (words != "")
                //    words += "and ";

                int[] unitsMap =  {0,1,2,3,4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19};
                int[] tensMap =  {0,10,20,30,40,50,60,70,80,90};

                if (number < 20)
                {
                    words = unitsMap[number];
                    PlaySoundNumber(words);
                }
                else
                {
                    words = tensMap[number / 10];
                    PlaySoundNumber(words);
                    if ((number % 10) >= 0)
                        words = unitsMap[number % 10];
                    if(words!=0)
                    PlaySoundNumber(words);
                }
            }

            return words;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);

            NumberToWords(number);
        }

        private void PlaySoundNumber(int number)
        {
            switch (number)
            {
                case 0: player.Stream = Properties.Resources._0;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 1: player.Stream = Properties.Resources._1;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 2: player.Stream = Properties.Resources._2;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 3: player.Stream = Properties.Resources._3;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 4: player.Stream = Properties.Resources._4;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 5: player.Stream = Properties.Resources._5;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 6: player.Stream = Properties.Resources._6;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 7: player.Stream = Properties.Resources._7;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 8: player.Stream = Properties.Resources._8;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 9: player.Stream = Properties.Resources._9;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 10: player.Stream = Properties.Resources._10;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 11: player.Stream = Properties.Resources._11;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 12: player.Stream = Properties.Resources._12;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 13: player.Stream = Properties.Resources._13;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 14: player.Stream = Properties.Resources._14;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 15: player.Stream = Properties.Resources._15;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 16: player.Stream = Properties.Resources._16;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 17: player.Stream = Properties.Resources._17;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 18: player.Stream = Properties.Resources._18;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 19: player.Stream = Properties.Resources._19;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 20: player.Stream = Properties.Resources._20;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 30: player.Stream = Properties.Resources._30;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 40: player.Stream = Properties.Resources._40;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 50: player.Stream = Properties.Resources._50;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 60: player.Stream = Properties.Resources._60;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 70: player.Stream = Properties.Resources._70;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 80: player.Stream = Properties.Resources._80;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 90: player.Stream = Properties.Resources._90;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
                case 100: player.Stream = Properties.Resources._100;
                    player.Play();
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
