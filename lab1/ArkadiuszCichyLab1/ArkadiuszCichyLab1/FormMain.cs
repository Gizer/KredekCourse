using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCichyLab1
{
    public partial class FormMain : Form
    {
        //How many times number was provided
        int couter = 0;
        //New windowx3
        FormAbout formAbout1;
        FormAbout formAbout2;
        FormAbout formAbout3;
        //Seconds passed since buttonStart Pressed
        int seconds = 0;
        public FormMain()
        {
            InitializeComponent();
            BackColor = Color.PapayaWhip;
        }

        /// <summary>
        /// button_Close causing program close procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Closing window
            Close();
        }

        /// <summary>
        /// Change of color and other elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            buttonChange.BackColor = Color.Aqua;
            buttonClose.BackColor = Color.Orchid;
            BackColor = Color.Orange;
        }


        /// <summary>
        /// Button that changes window title and texts for other window components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeAll_Click(object sender, EventArgs e)
        {
            Text = "HackerSOS 3.0";
            labelName.Text = "Otrzymano wpis do indeksu: AK2    3.0";
            buttonClose.Text = "DONE!!!";
            buttonChange.Text = "DONE!!!";
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Taking number from one texbox to another and limiting number of inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (couter > 5) //if more than 6 inputs
            {
                MessageBox.Show("Nie możesz wpisać więcej niż 5 liczb");
            }
            else
            {
                int newNumber = Int32.Parse(textBoxInput.Text);
                textBoxOutput.Text = newNumber.ToString();
                ++couter;
                labelName.Text = couter.ToString();
            }
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            ++seconds;
            textBoxOutput.Text = seconds.ToString();
            buttonChangeAll.Width += seconds;
            //buttonChangeAll.Location.Offset(seconds, seconds);
        }

        /// <summary>
        /// Start the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerCounter.Start();
        }

        /// <summary>
        /// Create and show new windows (i would do an array but this was faster and time was short)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            formAbout1 = new FormAbout();
            formAbout2 = new FormAbout();
            formAbout3 = new FormAbout();
            formAbout1.Show();
            formAbout2.Show();
            formAbout3.Show();
        }

        /*
         * Zad
         * Na podstawie licznika zmieniały się dane które zarządzają programem (gra albo symulacja przedsiębiorstwa)
         * Losowe i nie losowe zdarzenie które niszczą nasze kupione obiekty
         * Musi zawierać .exe
         * 
         * 
         * - wykorzystanie timera
         * - wykorzystanie pictureBox
         * */
    }
}
