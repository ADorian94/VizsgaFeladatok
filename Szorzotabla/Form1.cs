using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        private Random _randomGenerator;
        private int _firstNumber, _secondNumber, _wrongAnswers, _correctAnswers;
        private List<Button> _answerButtons;
        private List<int> _answers;

        public Form1()
        {
            InitializeComponent();

            _wrongAnswers = 0;
            _correctAnswers = 0;
            _answerButtons = new List<Button>() { AnswerButton1, AnswerButton2, AnswerButton3, AnswerButton4 };
            _answers = new List<int>();

            InitializeNumbers();
            InitializeAnswerButtons();
        }

        private void InitializeAnswerButtons()
        {
            //helyes válasz véletlenszerű elhelyezése
            int correctIndex = _randomGenerator.Next(0, 4);
            _answerButtons[correctIndex].Text = (_firstNumber * _secondNumber).ToString();
            _answers.Add(_firstNumber * _secondNumber);

            //többi gombon egy egy véletlen szám elhelyezése
            foreach (Button button in _answerButtons)
            {
                int randomGeneratedNumber = _randomGenerator.Next(1, 101);

                //addig generálok számot amíg olyat nem generálok amit még nem generáltam
                while (_answers.Contains(randomGeneratedNumber))
                {
                    randomGeneratedNumber = _randomGenerator.Next(1, 101);
                }

                _answers.Add(randomGeneratedNumber);

                if (button.Text == string.Empty || button.Text == null)
                {
                    button.Text = randomGeneratedNumber.ToString();
                }
            }
        }

        private void ClickAnswerButton(object sender, EventArgs e)
        {
            if(((Button)sender).Text != (_firstNumber * _secondNumber).ToString())
            {
                ++_wrongAnswers;
                WrongLabel.Text = $"Helytelen válaszok: {_wrongAnswers}";
                ((Button)sender).Enabled = false;
            }
            else
            {
                ++_correctAnswers;
                CorrectLabel.Text = $"Helyes válaszok: {_correctAnswers}";

                InitializeNumbers();
                ClearAnswerButtons();
                InitializeAnswerButtons();
                this.Invalidate();
            }
        }

        private void ClearAnswerButtons()
        {                          
            foreach (var button in _answerButtons)
            {
                button.Enabled = true;
                button.Text = string.Empty;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grid = e.Graphics;

            for (int i = 0; i < _firstNumber; ++i)
            {
                for (int j = 0; j < _secondNumber; ++j)
                {
                    Rectangle rectangle = new Rectangle(i * 40 + 5, j * 40 + 150, 38, 38);
                    grid.FillRectangle(new SolidBrush(Color.Red), rectangle);
                }
            }
        }

        private void InitializeNumbers()
        {
            _randomGenerator = new Random();
            _firstNumber = _randomGenerator.Next(1, 11);
            Thread.Sleep(50);
            _secondNumber = _randomGenerator.Next(1, 11);
            //MainLabel.Text = "Mennyi" + _firstNumber + " x " + _secondNumber +" ?";
            MainLabel.Text = $"Mennyi {_firstNumber} x {_secondNumber} ?";
        }
    }
}
