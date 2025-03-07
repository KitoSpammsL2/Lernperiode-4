using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheFinalChess
{
    public partial class Form1 : Form
    {
        private Button selectedButton = null; // Speichert den Button mit dem Bauern
        private Image whitePawnImage;
        private Image blackPawnImage;

        public Form1()
        {
            InitializeComponent();
            whitePawnImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\pawn-white-chess-piece-11532856224alv1lwm9ml.png");
            blackPawnImage = Image.FromFile(@"C:\Users\kaito\source\repos\TheFinalChess\TheFinalChess\Resources\awn-chess-piece-pawn-chess-piece-transparent-11563391176oxnhiiocwr.png");

            // Bauern setzen
            PlacePawns();

            // Click-Event für alle Buttons
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

            // Weiße Bauern (2. Reihe)
            foreach (char col in columns)
            {
                string buttonName = $"btn{col}2";
                Button btn = this.Controls.Find(buttonName, true)[0] as Button;
                btn.BackgroundImage = whitePawnImage;
                btn.Tag = "white"; // Markiert als weißer Bauer
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }

            // Schwarze Bauern (7. Reihe)
            foreach (char col in columns)
            {
                string buttonName = $"btn{col}7";
                Button btn = this.Controls.Find(buttonName, true)[0] as Button;
                btn.BackgroundImage = blackPawnImage;
                btn.Tag = "black"; // Markiert als schwarzer Bauer
                btn.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackgroundImage != null)
            {
                selectedButton = clickedButton; // Figur auswählen
            }
            else if (selectedButton != null)
            {
                MovePawn(selectedButton, clickedButton);
                selectedButton = null;
            }
        }

        private void MovePawn(Button from, Button to)
        {
            string fromName = from.Name;
            string toName = to.Name;

            // Konvertiere die Spalte (A, B, C...) in eine Zahl (0, 1, 2...)
            int colFrom = fromName[3] - 'A';
            int rowFrom = int.Parse(fromName[4].ToString());
            int colTo = toName[3] - 'A';
            int rowTo = int.Parse(toName[4].ToString());

            bool isCapture = to.BackgroundImage != null;
            string pawnColor = from.Tag.ToString();

            // Bewegung nach oben für weiße Bauern
            if (pawnColor == "white")
            {
                // Normale Bewegung
                if (IsValidPawnMove(rowFrom, rowTo, colFrom, colTo, isCapture, 2, 1))
                {
                    MovePiece(from, to, pawnColor);
                }
                // Diagonal schlagen
                else if (isCapture && Math.Abs(colFrom - colTo) == 1 && rowTo == rowFrom + 1 && to.Tag.ToString() == "black")
                {
                    MovePiece(from, to, pawnColor);
                }
            }
            // Bewegung nach unten für schwarze Bauern
            else if (pawnColor == "black")
            {
                // Normale Bewegung
                if (IsValidPawnMove(rowFrom, rowTo, colFrom, colTo, isCapture, -2, -1))
                {
                    MovePiece(from, to, pawnColor);
                }
                // Diagonal schlagen
                else if (isCapture && Math.Abs(colFrom - colTo) == 1 && rowTo == rowFrom - 1 && to.Tag.ToString() == "white")
                {
                    MovePiece(from, to, pawnColor);
                }
            }
        }

        private bool IsValidPawnMove(int rowFrom, int rowTo, int colFrom, int colTo, bool isCapture, int firstMoveStep, int normalMoveStep)
        {
            // Gerade nach vorne (kein Schlagen)
            if (colFrom == colTo && !isCapture)
            {
                if (rowTo == rowFrom + normalMoveStep)
                {
                    return true;
                }
                if ((rowFrom == 2 || rowFrom == 7) && rowTo == rowFrom + firstMoveStep)
                {
                    return true;
                }
            }
            // Diagonal schlagen
            else if (Math.Abs(colFrom - colTo) == 1 && rowTo == rowFrom + normalMoveStep && isCapture)
            {
                return true;
            }

            return false;
        }

        private void MovePiece(Button from, Button to, string pawnColor)
        {
            to.BackgroundImage = from.BackgroundImage;
            to.BackgroundImageLayout = ImageLayout.Stretch;
            to.Tag = pawnColor;
            from.BackgroundImage = null;
            from.Tag = null;
        }
    }
}
