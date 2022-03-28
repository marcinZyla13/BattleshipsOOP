﻿using BattleShipsOOP.Armory;
using System;

namespace BattleShipsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play = new Play();
            play.PrepareGame();
            play.Battle();
        }
    }


    internal class Play
    {
        public Game _game;

        public void PrepareGame()
        {
            
            Menu menu = new Menu();
            Status.AddBoardSize(menu.GiveBoardSize());          
            Util util = new Util();
            
            Player player1 = new Player(PlayerStatus.player_1);
            Fleet fleet_1 = new Fleet(PlayerStatus.player_1);
            var coords_1 = util.CreateCords();
            var cells_1 = util.CreateCells(coords_1);
            util.SetYourFleet(cells_1, fleet_1);
            player1.AddFleet(fleet_1);

            Player player2 = new Player(PlayerStatus.player_2);
            Fleet fleet_2 = new Fleet(PlayerStatus.player_2);
            var coords_2 = util.CreateCords();
            var cells_2 = util.CreateCells(coords_2);
            util.SetYourFleet(cells_2, fleet_2);
            player2.AddFleet(fleet_2);

            Board.AddCells(cells_1, cells_2);

            Game game = new Game(menu,player1 ,player2,util);
            game.CheckIfGameIsReady();
            game.CheckGameStatus();
            _game = game;
                      
        }

        public void Battle()
        {
            Console.Clear();
            WeaponModule weaponSystem = new WeaponModule(_game._util);
            while (true)
            {

                //Under construction
                
                weaponSystem.OpenFire(Board._player_2_cells, Board._player_1_cells);
                _game.IsTheGameFinnished();

                Display.Display_Defence(Board._player_1_cells);
                Display.Display_Attack(Board._player_1_cells);




                weaponSystem.OpenFire(Board._player_1_cells, Board._player_2_cells);
                _game.IsTheGameFinnished();

                Display.Display_Defence(Board._player_2_cells);
                Display.Display_Attack(Board._player_2_cells);


            }

        }

    }
        

}
