namespace Chess
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private const int tileSize = 60;
        private const int gridSize = 8;
        private Button[,] boardButtons = new Button[gridSize, gridSize];
        private string[,] boardState = new string[gridSize, gridSize]; // Speichert den Zustand der Figuren

        public Form1()
        {
            this.Text = "Schachbrett";
            this.ClientSize = new Size(gridSize * tileSize, gridSize * tileSize);
            InitializeBoard();
            InitializePieces();
        }

        
        private void InitializeBoard()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button button = new Button
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(col * tileSize, row * tileSize),
                        BackColor = (row + col) % 2 == 0 ? Color.White : Color.Brown,
                        Tag = new Point(row, col) 
                    };

                    
                    button.Click += BoardButton_Click;

                    boardButtons[row, col] = button;
                    this.Controls.Add(button);
                }
            }
        }

        private void InitializePieces()
        {
            for (int col = 0; col < gridSize; col++)
            {
                boardState[1, col] = "♙"; // Weiße Bauern 
                boardState[6, col] = "♟"; // Schwarze Bauern 
            }

            boardState[0, 0] = boardState[0, 7] = "♖"; // Weiße Türme
            boardState[0, 1] = boardState[0, 6] = "♘"; // Weiße Springer
            boardState[0, 2] = boardState[0, 5] = "♗"; // Weiße Läufer
            boardState[0, 3] = "♕"; // Weiße Dame
            boardState[0, 4] = "♔"; // Weißer König

            boardState[7, 0] = boardState[7, 7] = "♜"; // Schwarze Türme
            boardState[7, 1] = boardState[7, 6] = "♞"; // Schwarze Springer
            boardState[7, 2] = boardState[7, 5] = "♝"; // Schwarze Läufer
            boardState[7, 3] = "♛"; // Schwarze Dame
            boardState[7, 4] = "♚"; // Schwarzer König

            UpdateBoard();
        }

      
        private void UpdateBoard()
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Button button = boardButtons[row, col];
                    string piece = boardState[row, col];

                    if (!string.IsNullOrEmpty(piece))
                    {
                        button.Text = piece; // Setze das Symbol auf das Button
                        button.ForeColor = char.IsUpper(piece[0]) ? Color.White : Color.Black; // Bestimme die Farbe der Schrift
                    }
                    else
                    {
                        button.Text = string.Empty; // Kein Symbol auf dem Feld
                    }
                }
            }
        }

      
        private void BoardButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Point position = (Point)clickedButton.Tag;

           
            MessageBox.Show($"Feld: {position.X}, {position.Y}, Figur: {boardState[position.X, position.Y]}");
        }

    
    }
}
