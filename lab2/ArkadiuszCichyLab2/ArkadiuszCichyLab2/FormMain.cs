using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCichyLab2
{
    public partial class FormMain : Form
    {
        // Storing chosen shape from list
        private Shape shape;

        public FormMain()
        {
            InitializeComponent();
            Circle circle = new Circle();
            Square square = new Square();
            comboBoxShape.Items.Add(circle);
            comboBoxShape.Items.Add(square);
        }

        /// <summary>
        /// Reaction for buttonArea press. Displaying shape area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonArea_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex != -1)
                textBoxArea.Text = shape.Area().ToString();
            else
                MessageBox.Show("Nie wybrano wartości");
        }

        /// <summary>
        /// Reaction for chosing shape from comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = (Shape)comboBoxShape.SelectedItem;
        }

        /// <summary>
        /// Change size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeSize_Click(object sender, EventArgs e)
        {
            if (shape is IResizable)
            {
                IResizable resizable = (IResizable)shape;
                resizable.ChangeSize();
            }
            else
            {
                MessageBox.Show("Nie da się zmienić rozmiaru tego kształtu");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPermimeter_Click(object sender, EventArgs e)
        {
            textBoxPerimeter.Text = shape.Perimeter();
        }
    }
}