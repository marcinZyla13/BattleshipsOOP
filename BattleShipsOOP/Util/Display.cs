﻿using System;
using System.Collections.Generic;


namespace BattleShipsOOP
{
    internal static class Display
    {
        public static string _alphabet => MatchAlphabet();
        public static string _horizontalBorderLine => GenerateHorizontalBorderLine();




        public static void Display_Defence(List<Cell> cells) 
        {
            Console.WriteLine(_alphabet);
            Console.Write(_horizontalBorderLine);
            Console.WriteLine("");
            int counter = 0;
            int counter2 = 1;
            Console.Write(" 1 |");
            foreach (var item in cells)
            {
                if (item.ShowDefenceStatus() == CellStatus.destroyed)
                {
                    Console.Write("X");
                    Console.Write(' ');
                }
                else if (item.ShowDefenceStatus() == CellStatus.missed)
                {
                    Console.Write("*");
                    Console.Write(' ');
                }
                else if (item.HasAShip())
                {
                    Console.Write("#");
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(" "); 
                    Console.Write(' ');
                }
                counter+=1;
                
                if (counter >= Board.Instance._boardLength)
                {
                    counter2+=1;
                    Console.WriteLine("");
                    if(counter2 <= Board.Instance._boardLength)
                    {
                        if (counter2 < 10)
                            Console.Write(" {0} |", counter2);
                        else
                            Console.Write("{0} |", counter2);
                    }
                    
                    counter = 0;
                    
                }

            }
        }


        public static void Display_Attack(List<Cell> cells)
        {
            Console.WriteLine(_alphabet);
            Console.Write(_horizontalBorderLine);
            Console.WriteLine("");
            int counter = 0;
            int counter2 = 1;
            Console.Write(" 1 |");
            foreach (var item in cells)
            {
                if (item.ShowAttackStatus() == CellStatus.destroyed)
                {
                    Console.Write("X");
                    Console.Write(' ');
                }
                else if (item.ShowAttackStatus() == CellStatus.missed)
                {
                    Console.Write("*");
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(' ');
                }
                counter+=1;

                if (counter >= Board.Instance._boardLength)
                {
                    counter2+=1;
                    Console.WriteLine("");
                    if (counter2 <= Board.Instance._boardLength)
                    {
                        if (counter2 < 10)
                            Console.Write(" {0} |", counter2);
                        else
                            Console.Write("{0} |", counter2);
                    }

                    counter = 0;

                }

            }
        }



        private static string MatchAlphabet()
        {
            string alphabet = "ABCDEFGHIJKLMNO";
            string alph = default;
            alph+="    ";
            for(int x= 0;x<Board.Instance._boardLength;x++)
            {
                alph += alphabet[x];
                alph +=" ";
            }
            return alph;

        }

        private static string GenerateHorizontalBorderLine()
        {
            string borderLine = "    ";
            for(int x = 0;x <(Board.Instance._boardLength*2)-1;x++)
            {
                borderLine+="_";
            }
            return borderLine;
        }


     

    }
}
