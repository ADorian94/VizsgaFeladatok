using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Safe
{
    public enum SafeColor
    {
        red,
        green,
        white
    }

    public class MatrixButton : Button
    {
        public SafeColor SafeColor { get; set; }
    }

    public partial class MainForm : Form
    {
        private List<List<SafeColor>> _colorMatrix;
        private List<List<MatrixButton>> _colorButtons;
        private Random _randomGenerator = new Random();

        public MainForm()
        {
            InitializeComponent();
            InitColorMatrix();
            InitButtons();
        }

        private void InitColorMatrix()
        {
            _colorMatrix = new List<List<SafeColor>>();
            int randomNuber;

            for (int i = 0; i < 3; i++)
            {
                _colorMatrix.Add(new List<SafeColor>());

                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(50);
                    randomNuber = _randomGenerator.Next(1, 101);
                    _colorMatrix[i].Add(randomNuber % 2 == 0 ? SafeColor.red : SafeColor.green);
                }
            }
        }

        private void InitButtons()
        {
            _colorButtons = new List<List<MatrixButton>>();

            for (int i = 0; i < 3; i++)
            {
                _colorButtons.Add(new List<MatrixButton>());

                for (int j = 0; j < 3; j++)
                {
                    var button = new MatrixButton()
                    {
                        BackColor = Color.White,
                        Location = new Point(i * 70 + 10, j * 70 + 10),
                        Width = 60,
                        Height = 60,
                        SafeColor = SafeColor.white
                    };         

                    button.MouseClick += ButtonClick;

                    Controls.Add(button);
                    _colorButtons[i].Add(button);
                }
            }
        }

        private void ButtonClick(object obj, MouseEventArgs e)
        {
            var button = (MatrixButton)obj;

            switch (button.SafeColor)
            {
                case SafeColor.white:
                    button.SafeColor = SafeColor.red;
                    button.BackColor = Color.Red;
                    break;
                case SafeColor.red:
                    button.SafeColor = SafeColor.green;
                    button.BackColor = Color.Green;
                    break;
                case SafeColor.green:
                    button.SafeColor = SafeColor.red;
                    button.BackColor = Color.Red;
                    break;
            }
        }

        private void OpenButton_Click(object obj, EventArgs e)
        {
            int match = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_colorMatrix[i][j] != _colorButtons[i][j].SafeColor)
                    {
                        _colorButtons[i][j].SafeColor = SafeColor.white;
                        _colorButtons[i][j].BackColor = Color.White;
                    }
                    else
                        ++match;
                }
            }

            if(match == 9)
            {
                MessageBox.Show("Kitaláltad a kódot!", "Gratulálok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReInitialize();
            }
        }

        private void ReInitialize()
        {
            Controls.Clear();
            InitializeComponent();
            InitColorMatrix();
            InitButtons();
        }
    }
}
