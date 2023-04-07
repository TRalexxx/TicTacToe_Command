using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe_Command
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Text = "Form1";
            this.BackColor = Color.FromArgb(255, 75, 0, 200);



            // Кнопка для запуска игры
            start_btn = new Button();
            start_btn.Text = "Start";
            start_btn.Font = new Font("Ubuntu", 20, FontStyle.Bold);
            start_btn.ForeColor = Color.White;
            start_btn.Location = new Point(600, 280);
            start_btn.BackColor = Color.FromArgb(200, 184, 0, 0);
            start_btn.Size = new Size(180, 70);
            start_btn.Click += NewGame;

            

            //Поле для вывода результата игры. Будет создаватся в результате победы одного из игроков
            info = new Label();

            info.Location = new Point(500, 50);
            info.Font = new Font("Ubuntu", 18, FontStyle.Bold);
            info.ForeColor = Color.White;
            info.Size = new Size(300, 100);


            panel = new Panel();
            panel.Location = new Point(30, 30);
            panel.BackColor = Color.FromArgb(255, 150, 150, 150);
            panel.Size = new Size(340, 340);


            this.Controls.Add(start_btn);
            this.Controls.Add(info);
            this.Controls.Add(panel);
           
        }
        Button start_btn;
        Label info;
        Panel panel;
        #endregion
    }
}

