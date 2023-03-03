namespace OscarChessApi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_box_chessboard = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_chessboard)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box_chessboard
            // 
            this.picture_box_chessboard.BackgroundImage = global::OscarChessApi.Properties.Resources.Chessboard_green_squares_svg;
            this.picture_box_chessboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_box_chessboard.Location = new System.Drawing.Point(127, 22);
            this.picture_box_chessboard.Name = "picture_box_chessboard";
            this.picture_box_chessboard.Size = new System.Drawing.Size(581, 496);
            this.picture_box_chessboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_chessboard.TabIndex = 0;
            this.picture_box_chessboard.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_next.Location = new System.Drawing.Point(435, 533);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 40);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.Location = new System.Drawing.Point(347, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.picture_box_chessboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_chessboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box_chessboard;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button button2;
    }
}

