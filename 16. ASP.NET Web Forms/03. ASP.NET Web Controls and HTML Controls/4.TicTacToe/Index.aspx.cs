using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4.TicTacToe
{
    public partial class Index : System.Web.UI.Page
    {
        private static Random rand = new Random();
        private static bool[] used = new bool[10];
        private static StringBuilder field = new StringBuilder();
        private static string gameState = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            field.Append("---------");
        }

        protected void Btn_Command(object sender, CommandEventArgs e)
        {
            if (gameState == "finished")
            {
                Response.Write("You game is over!");
                return;
            }

            switch (e.CommandName)
            {
                case "1":
                    this.b1.Text = "X";
                    this.b1.Enabled = false;
                    used[1] = true;
                    field[0] = 'X';
                    break;
                case "2":
                    this.b2.Text = "X";
                    this.b2.Enabled = false;
                    used[2] = true;
                    field[1] = 'X';
                    break;
                case "3":
                    this.b3.Text = "X";
                    this.b3.Enabled = false;
                    used[3] = true;
                    field[2] = 'X';
                    break;
                case "4":
                    this.b4.Text = "X";
                    this.b4.Enabled = false;
                    used[4] = true;
                    field[3] = 'X';
                    break;
                case "5":
                    this.b5.Text = "X";
                    this.b5.Enabled = false;
                    used[5] = true;
                    field[4] = 'X';
                    break;
                case "6":
                    this.b6.Text = "X";
                    this.b6.Enabled = false;
                    used[6] = true;
                    field[5] = 'X';
                    break;
                case "7":
                    this.b7.Text = "X";
                    this.b7.Enabled = false;
                    used[7] = true;
                    field[6] = 'X';
                    break;
                case "8":
                    this.b8.Text = "X";
                    this.b8.Enabled = false;
                    used[8] = true;
                    field[7] = 'X';
                    break;
                case "9":
                    this.b9.Text = "X";
                    this.b9.Enabled = false;
                    used[9] = true;
                    field[8] = 'X';
                    break;
            }

            if(this.CheckState(1) != "Play")
            {
                gameState = "finished";
                Response.Write("You win!");
                return;
            }

            var index = 0;
            do
            {
                index = rand.Next(1, 10);
            } while (used[index]);

            var computer = index.ToString();
            switch (computer)
            {
                case "1":
                    this.b1.Text = "O";
                    this.b1.Enabled = false;
                    used[1] = true;
                    field[0] = 'O';
                    break;
                case "2":
                    this.b2.Text = "O";
                    this.b2.Enabled = false;
                    used[2] = true;
                    field[1] = 'O';
                    break;
                case "3":
                    this.b3.Text = "O";
                    this.b3.Enabled = false;
                    used[3] = true;
                    field[2] = 'O';
                    break;
                case "4":
                    this.b4.Text = "O";
                    this.b4.Enabled = false;
                    used[4] = true;
                    field[3] = 'O';
                    break;
                case "5":
                    this.b5.Text = "O";
                    this.b5.Enabled = false;
                    used[5] = true;
                    field[4] = 'O';
                    break;
                case "6":
                    this.b6.Text = "O";
                    this.b6.Enabled = false;
                    used[6] = true;
                    field[5] = 'O';
                    break;
                case "7":
                    this.b7.Text = "O";
                    this.b7.Enabled = false;
                    used[7] = true;
                    field[6] = 'O';
                    break;
                case "8":
                    this.b8.Text = "O";
                    this.b8.Enabled = false;
                    used[8] = true;
                    field[7] = 'O';
                    break;
                case "9":
                    this.b9.Text = "O";
                    this.b9.Enabled = false;
                    used[9] = true;
                    field[8] = 'O';
                    break;
            }

            if (this.CheckState(0) != "Play")
            {
                gameState = "finished";
                Response.Write("You lose!");
                return;
            }
        }

        private string CheckState(int win)
        {
            for (var i = 0; i < 8; i += 3)
            {
                var findRow = true;
                for (var j = i + 1; j < i + 3; j++)
                {
                    if (field[i] == '-' || field[i] != field[j])
                    {
                        findRow = false;
                        break;
                    }
                }

                if(findRow && win == 1)
                {
                    return "You win!";
                }
                else if (findRow && win == 0)
                {
                    return "You lose!";
                }
            }

            for (var i = 0; i < 3; i += 1)
            {
                var findRow = true;
                for (var j = i + 3; j < 9; j += 3)
                {
                    if (field[i] == '-' || field[i] != field[j])
                    {
                        findRow = false;
                        break;
                    }
                }

                if (findRow && win == 1)
                {
                    return "You win!";
                }
                else if (findRow && win == 0)
                {
                    return "You lose!";
                }
            }

            if (field[0] != '-' && field[0] == field[4] && field[0] == field[8])
            {
                if(win == 1)
                {
                    return "You win!";
                }
                else 
                {
                    return "You lose!";
                }
            }

            if (field[2] != '-' && field[2] == field[4] && field[2] == field[6])
            {
                if (win == 1)
                {
                    return "You win!";
                }
                else
                {
                    return "You lose!";
                }
            }

            return "Play";
        }
    }
}