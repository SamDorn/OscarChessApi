using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscarChessApi
{
    public partial class Form1 : Form
    {
        private PictureBox[] pictureBoxes;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;
            picture_box_chessboard.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Chessboard_green_squares.svg/1200px-Chessboard_green_squares.svg.png");

            for (int i = 0; i < 8; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Location = new Point(137+x, 27);
                pictureBoxes[i].Size = new Size(50, 50);
                pictureBoxes[i].SizeMode= PictureBoxSizeMode.AutoSize;
                switch (i)
                {
                    case 0:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#fff");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackRook.png");
                        break;
                    case 1:

                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#49a248");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackKnight.png");
                        break;
                    case 2:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#fff");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackBishop.png");
                        break;
                    case 3:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#49a248");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackQueen.png");
                        break;
                    case 4:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#fff");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackKing.png");
                        break;
                    case 5:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#49a248");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackBishop.png");
                        break;
                    case 6:
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#fff");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackKnight.png");
                        break;
                    case 7:
                        pictureBoxes[i].Name = "blackRook2";
                        pictureBoxes[i].BackColor = ColorTranslator.FromHtml("#49a248");
                        pictureBoxes[i].Load("../../chess_pieces_img/blackRook.png");
                        break;

                }
                Controls.Add(pictureBoxes[i]);
                pictureBoxes[i].BringToFront();
                x += 72;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            pictureBoxes[7].Location = new Point(137, 47);
        }
    }
}
