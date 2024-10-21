///////////////////////////////////////////////////////
// TINFO 200 A, Winter 2024
// UWTacoma SET, Manuel Rosales and Michael Tran
// 2024-02-09 - Cs1Tic - C# programming project - Tic Tac Toe game
// This application uses Win form format using the .NET framework.
// It makes use of a pseudo random feature for the computer to
// mimic random choices on the game board for TicTacToe games.
//
// The user player will be randomly assigned X's or O's to determine
// the turn order. The player can start a new game or exit the app
// with buttons.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
