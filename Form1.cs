using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OscarChessApi
{
    public partial class Form1 : Form
    {
        private PictureBox[] whitePieces_WhiteSquare = new PictureBox[16];
        private PictureBox[] whitePieces_GreenSquare = new PictureBox[16];
        private PictureBox[] blackPieces_WhiteSquare = new PictureBox[16];
        private PictureBox[] blackPieces_GreenSquare = new PictureBox[16];
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePictureBoxArray("white", "white");
            PopulatePictureBoxArray("white", "green");
            PopulatePictureBoxArray("black", "white");
            PopulatePictureBoxArray("black", "green");
            table.Controls.Add(blackPieces_WhiteSquare[0], 0, 0);
            table.Controls.Add(blackPieces_GreenSquare[1], 1, 0);
            table.Controls.Add(blackPieces_WhiteSquare[2], 2, 0);
            table.Controls.Add(blackPieces_GreenSquare[3], 3, 0);
            table.Controls.Add(blackPieces_WhiteSquare[4], 4, 0);
            table.Controls.Add(blackPieces_GreenSquare[5], 5, 0);
            table.Controls.Add(blackPieces_WhiteSquare[6], 6, 0);
            table.Controls.Add(blackPieces_GreenSquare[7], 7, 0);
            table.Controls.Add(blackPieces_GreenSquare[8], 0, 1);
            table.Controls.Add(blackPieces_WhiteSquare[9], 1, 1);
            table.Controls.Add(blackPieces_GreenSquare[10], 2, 1);
            table.Controls.Add(blackPieces_WhiteSquare[11], 3, 1);
            table.Controls.Add(blackPieces_GreenSquare[12], 4, 1);
            table.Controls.Add(blackPieces_WhiteSquare[13], 5, 1);
            table.Controls.Add(blackPieces_GreenSquare[14], 6, 1);
            table.Controls.Add(blackPieces_WhiteSquare[15], 7, 1);

            //white pieces
            table.Controls.Add(whitePieces_GreenSquare[0], 0, 7);
            table.Controls.Add(whitePieces_WhiteSquare[1], 1, 7);
            table.Controls.Add(whitePieces_GreenSquare[2], 2, 7);
            table.Controls.Add(whitePieces_WhiteSquare[3], 3, 7);
            table.Controls.Add(whitePieces_GreenSquare[4], 4, 7);
            table.Controls.Add(whitePieces_WhiteSquare[5], 5, 7);
            table.Controls.Add(whitePieces_GreenSquare[6], 6, 7);
            table.Controls.Add(whitePieces_WhiteSquare[7], 7, 7);
            table.Controls.Add(whitePieces_WhiteSquare[8], 0, 6);
            table.Controls.Add(whitePieces_GreenSquare[9], 1, 6);
            table.Controls.Add(whitePieces_WhiteSquare[10], 2, 6);
            table.Controls.Add(whitePieces_GreenSquare[11], 3, 6);
            table.Controls.Add(whitePieces_WhiteSquare[12], 4, 6);
            table.Controls.Add(whitePieces_GreenSquare[13], 5, 6);
            table.Controls.Add(whitePieces_WhiteSquare[14], 6, 6);
            table.Controls.Add(whitePieces_GreenSquare[15], 7, 6);

        }

        /// <summary>
        /// Function that color the table. One cell white, one green
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void table_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.DarkSeaGreen, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }
        /// <summary>
        /// Populate the arrays of the colorPiece and colorSquare
        /// </summary>
        /// <param name="colorPiece">The color of the chess pieces</param>
        /// <param name="colorSquare">The color of the square</param>
        private void PopulatePictureBoxArray(string colorPiece, string colorSquare)
        {
            string[] path = new string[9];
            path[0] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Rook.png";
            path[1] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Knight.png";
            path[2] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Bishop.png";
            path[3] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Queen.png";
            path[4] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}King.png";
            path[5] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Bishop.png";
            path[6] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Knight.png";
            path[7] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Rook.png";
            path[8] = $"../../img/chess_pieces/{colorPiece}/{colorPiece}Pawn.png";

            if (colorPiece == "white" && colorSquare == "white")
            {
                int k = 0;
                for (int i = 0; i < 16; i++)
                {

                    whitePieces_WhiteSquare[i] = new PictureBox();
                    whitePieces_WhiteSquare[i].Size = new Size(100, 100);
                    whitePieces_WhiteSquare[i].Load(path[k]);
                    whitePieces_WhiteSquare[i].BackColor = ColorTranslator.FromHtml("#fff");
                    whitePieces_WhiteSquare[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (k < 8)
                        k++;

                }
                //whitePieces_WhiteSquare[8] = new PictureBox();
                //whitePieces_WhiteSquare[8].Size = new Size(100, 100);
                //whitePieces_WhiteSquare[8].Load(path[8]);
                //whitePieces_WhiteSquare[8].BackColor = ColorTranslator.FromHtml("#fff");
                //whitePieces_WhiteSquare[8].SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (colorPiece == "white" && colorSquare == "green")
            {
                int k = 0;
                for (int i = 0; i < 16; i++)
                {

                    whitePieces_GreenSquare[i] = new PictureBox();
                    whitePieces_GreenSquare[i].Size = new Size(100, 100);
                    whitePieces_GreenSquare[i].Load(path[k]);
                    whitePieces_GreenSquare[i].BackColor = ColorTranslator.FromHtml("#8FBC8B");
                    whitePieces_GreenSquare[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (k < 8)
                        k++;

                }
                //whitePieces_GreenSquare[8] = new PictureBox();
                //whitePieces_GreenSquare[8].Size = new Size(100, 100);
                //whitePieces_GreenSquare[8].Load(path[8]);
                //whitePieces_GreenSquare[8].BackColor = ColorTranslator.FromHtml("#8FBC8B");
                //whitePieces_GreenSquare[8].SizeMode = PictureBoxSizeMode.StretchImage;

            }
            else if (colorPiece == "black" && colorSquare == "white")
            {
                int k = 0;
                for (int i = 0; i < 16; i++)
                {

                    blackPieces_WhiteSquare[i] = new PictureBox();
                    blackPieces_WhiteSquare[i].Size = new Size(100, 100);
                    blackPieces_WhiteSquare[i].Load(path[k]);
                    blackPieces_WhiteSquare[i].BackColor = ColorTranslator.FromHtml("#fff");
                    blackPieces_WhiteSquare[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (k < 8)
                        k++;
                }
                //blackPieces_WhiteSquare[8] = new PictureBox();
                //blackPieces_WhiteSquare[8].Size = new Size(100, 100);
                //blackPieces_WhiteSquare[8].Load(path[8]);
                //blackPieces_WhiteSquare[8].BackColor = ColorTranslator.FromHtml("#fff");
                //blackPieces_WhiteSquare[8].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (colorPiece == "black" && colorSquare == "green")
            {
                int k = 0;
                for (int i = 0; i < 16; i++)
                {

                    blackPieces_GreenSquare[i] = new PictureBox();
                    blackPieces_GreenSquare[i].Size = new Size(100, 100);
                    blackPieces_GreenSquare[i].Load(path[k]);
                    blackPieces_GreenSquare[i].BackColor = ColorTranslator.FromHtml("#8FBC8B");
                    blackPieces_GreenSquare[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (k < 8)
                        k++;
                }
                //blackPieces_GreenSquare[8] = new PictureBox();
                //blackPieces_GreenSquare[8].Size = new Size(100, 100);
                //blackPieces_GreenSquare[8].Load(path[8]);
                //blackPieces_GreenSquare[8].BackColor = ColorTranslator.FromHtml("#8FBC8B");
                //blackPieces_GreenSquare[8].SizeMode = PictureBoxSizeMode.StretchImage;


            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            RotateChessboard();
        }
        private void RotateChessboard()
        {
            // rotate white pieces
            for (int i = 0; i < 16; i++)
            {
                whitePieces_WhiteSquare[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                whitePieces_GreenSquare[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            // rotate black pieces
            for (int i = 0; i < 16; i++)
            {
                blackPieces_WhiteSquare[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                blackPieces_GreenSquare[i].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }

            // rotate chessboard
            table.SuspendLayout();
            table.Size = new Size(table.Height, table.Width);
            table.Location = new Point(table.Location.Y, table.Location.X);
            table.Invalidate();
            table.ResumeLayout();
        }
    }
}
