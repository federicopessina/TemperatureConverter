using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void convertFromFahrenheit()
        {
            // Fahrenheight input
            float fahrenheitDegrees = 0;

            try
            {
                fahrenheitDegrees = float.Parse(textBoxFahrenheit.Text);
            }
            catch (Exception)
            {
                textBoxFahrenheit.Text = fahrenheitDegrees.ToString();
                MessageBox.Show("Try only numbers");
            }

            // Celsius converter
            float celsiusDegrees = 5f / 9f * (fahrenheitDegrees - 32);
            textBoxCelsius.Text = celsiusDegrees.ToString();

            // Kelvin converter
            float kelvinDegrees = celsiusDegrees - 273;
            textBoxKelvin.Text = kelvinDegrees.ToString();
        }

        private void buttonCelsius_Click(object sender, EventArgs e)
        {
            convevertFromCelsius();
        }

        private void convevertFromCelsius()
        {
            // Celsius input
            float celsiusDegrees = 0;

            try
            {
                celsiusDegrees = float.Parse(textBoxCelsius.Text);
            }
            catch (Exception)
            {
                textBoxCelsius.Text = celsiusDegrees.ToString();
                MessageBox.Show("Try only numbers");
            }

            // Fahrenheiht converter
            float fahrenheitDegrees = (celsiusDegrees * 1.8f) + 32f;
            textBoxFahrenheit.Text = fahrenheitDegrees.ToString();

            // Kelvin converter
            float kelvinDegrees = celsiusDegrees + 273.15f;
            textBoxKelvin.Text = kelvinDegrees.ToString();
        }

        private void buttonKelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromKelvin()
        {
            // Kelvin input
            float kelvinDegrees = 0;

            try
            {
                kelvinDegrees = float.Parse(textBoxKelvin.Text);
            }
            catch (Exception)
            {
                textBoxKelvin.Text = kelvinDegrees.ToString();
                MessageBox.Show("Try only numbers");
            }

            // Fahrenheiht converter
            float fahrenheitDegrees = kelvinDegrees * 1.8f - 459.67f;
            textBoxFahrenheit.Text = fahrenheitDegrees.ToString();

            // Celsius converter
            float celsiusDegrees = kelvinDegrees - 273.15f;
            textBoxCelsius.Text = celsiusDegrees.ToString();
        }
    }
}
