using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheFinalChess
{
    public partial class Form1 : Form
    {
        private Button selectedButton = null;
        private Image whitePawnImage, blackPawnImage;
        private Image whiteRookImage, blackRookImage;

        public Form1()
        {
            InitializeComponent();
            whitePawnImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\pawn-white-chess-piece-11532856224alv1lwm9ml.png");
            blackPawnImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\awn-chess-piece-pawn-chess-piece-transparent-11563391176oxnhiiocwr.png");
            whiteRookImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\rook-white-chess-piece-11532860352fgkrs0cewb.png");
            blackRookImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\rook-black-chess-piece-11532860333ghjtvpbqyh.png");

            PlacePawns();
            PlaceRooks();

            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Click += Button_Click;
                }
            }
        }

        private void PlacePawns()
        {
            char[] columns = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            foreach (char col in columns)
            {
                string whiteButtonName = $"btn{col}2";
                string blackButtonName = $"btn{col}7";

                Button whiteBtn = this.Controls.Find(whiteButtonName, true)[0] as Button;
                Button blackBtn = this.Controls.Find(blackButtonName, true)[0] as Button;

                whiteBtn.BackgroundImage = whitePawnImage;
                whiteBtn.Tag = "whitePawn";
                whiteBtn.BackgroundImageLayout = ImageLayout.Stretch;

                blackBtn.BackgroundImage = blackPawnImage;
                blackBtn.Tag = "blackPawn";
                blackBtn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void PlaceRooks()
        {
            string[] whiteRookPositions = { "btnA1", "btnH1" };
            string[] blackRookPositions = { "btnA8", "btnH8" };

            foreach (string pos in whiteRookPositions)
            {
                Button btn = this.Controls.Find(pos, true)[0] as Button;
                btn.BackgroundImage = whiteRookImage;
                btn.Tag = "whiteRook";
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }

            foreach (string pos in blackRookPositions)
            {
                Button btn = this.Controls.Find(pos, true)[0] as Button;
                btn.BackgroundImage = blackRookImage;
                btn.Tag = "blackRook";
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackgroundImage != null)
            {
                selectedButton = clickedButton;
            }
            else if (selectedButton != null)
            {
                MovePiece(selectedButton, clickedButton);
                selectedButton = null;
            }
        }

        private void MovePiece(Button from, Button to)
        {
            string fromTag = from.Tag?.ToString();
            string toTag = to.Tag?.ToString();

            if (fromTag.Contains("Pawn") && IsValidPawnMove(from, to))
            {
                MoveFigure(from, to);
            }
            else if (fromTag.Contains("Rook") && IsValidRookMove(from, to))
            {
                MoveFigure(from, to);
            }
        }

        private bool IsValidPawnMove(Button from, Button to)
        {
            string fromName = from.Name;
            string toName = to.Name;

            int colFrom = fromName[3] - 'A';
            int rowFrom = int.Parse(fromName[4].ToString());
            int colTo = toName[3] - 'A';
            int rowTo = int.Parse(toName[4].ToString());

            string pawnColor = from.Tag.ToString();
            bool isCapture = to.BackgroundImage != null;

            if (pawnColor == "whitePawn")
            {
                if (colFrom == colTo && !isCapture)
                {
                    if (rowFrom == 2 && rowTo == 4)
                    {
                        return true;
                    }
                    else if (rowTo == rowFrom + 1)
                    {
                        return true;
                    }
                }
                else if (isCapture && Math.Abs(colFrom - colTo) == 1 && rowTo == rowFrom + 1)
                {
                    return true;
                }
            }
            else if (pawnColor == "blackPawn")
            {
                if (colFrom == colTo && !isCapture)
                {
                    if (rowFrom == 7 && rowTo == 5)
                    {
                        return true;
                    }
                    else if (rowTo == rowFrom - 1)
                    {
                        return true;
                    }
                }
                else if (isCapture && Math.Abs(colFrom - colTo) == 1 && rowTo == rowFrom - 1)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsValidRookMove(Button from, Button to)
        {
            string fromName = from.Name;
            string toName = to.Name;

            int colFrom = fromName[3] - 'A';
            int rowFrom = int.Parse(fromName[4].ToString());
            int colTo = toName[3] - 'A';
            int rowTo = int.Parse(toName[4].ToString());

            return colFrom == colTo || rowFrom == rowTo;
        }

        private void MoveFigure(Button from, Button to)
        {
            to.BackgroundImage = from.BackgroundImage;
            to.BackgroundImageLayout = ImageLayout.Stretch;
            to.Tag = from.Tag;
            from.BackgroundImage = null;
            from.Tag = null;
        }
    }
}
