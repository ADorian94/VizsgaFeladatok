using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizsgaFeladatok
{
    public partial class Szamkitalalo : Form
    {
        private Random _randomGenerator;
        private int _randomNumber;

        public Szamkitalalo()
        {
            InitializeComponent();
            InitializeButtons();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            _randomGenerator = new Random();
            _randomNumber = _randomGenerator.Next(1000000, 10000000);
        }

        private void InitializeButtons()
        {
            for (int i = 0; i < 10; ++i)
            {
                var numberButton = new Button()
                {
                    Text = i.ToString(),
                    Width = 40,
                    Height = 40,
                    BackColor = Color.White,
                };

                numberButton.Click += NumberButtonClick;

                ButtonPanel.Controls.Add(numberButton);
            }
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            var stringNumber = _randomNumber.ToString();

            stringNumber.Contains(((Button)sender).Text);
        }
    }
}
