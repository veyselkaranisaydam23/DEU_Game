using System;

namespace DEU_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[3];
            arr[0] = 'D';
            arr[1] = 'E';
            arr[2] = 'U';

            char[] row1 = new char[15];
            char[] row2 = new char[15];
            char[] row3 = new char[15];

            bool checkParams = true;
            int player1Score = 120;
            int player2Score = 120;
            int turn = 1;
            string winnerName="Winner Name";
            int winnerScore=0;

            
            for (int i = 0; i < row1.Length; i++)
            {
                row1[i] = ' ';
            }

            for (int i = 0; i < row2.Length; i++)
            {
                row2[i] = ' ';
            }

            for (int i = 0; i < row3.Length; i++)
            {
                row3[i] = ' ';
            }

            

            while (checkParams == true)
            {
                Random rowRandom = new Random();
                int findRow = rowRandom.Next(0, 3);

                Random findChar = new Random();
                int generateChar = findChar.Next(0, 3);

                if (findRow == 0)
                {

                    for (int i = 0; i < row1.Length; i++)
                    {
                        if (row1[i] == ' ')
                        {
                            row1[i] = arr[generateChar];

                            break;
                        }

                        
                    }


                }

                if (findRow == 1)
                {
                    for (int i = 0; i < row1.Length; i++)
                    {
                        if (row2[i] == ' ')
                        {
                            row2[i] = arr[generateChar];

                            break;
                        }

                        
                    }


                }

                if (findRow == 2)
                {

                    for (int i = 0; i < row1.Length; i++)
                    {
                        if (row3[i] == ' ')
                        {
                            row3[i] = arr[generateChar];
 
                            break;

                        }

                    }

                }

                



                Console.Write("A1");
                for (int i = 0; i < row1.Length; i++)
                {
                    Console.Write(row1[i]);
                }

                Console.WriteLine();

                Console.Write("A2");
                for (int i = 0; i < row2.Length; i++)
                {
                    Console.Write(row2[i]);
                }

                Console.WriteLine();

                Console.Write("A3");
                for (int i = 0; i < row3.Length; i++)
                {
                    Console.Write(row3[i]);
                }

                Console.WriteLine();

                for (int x = 0; x < 13; x++)
                {
                    if (row1[x] == 'D' && row1[x + 1] == 'E' && row1[x + 2] == 'U')
                    {
                        checkParams = false;
                    }

                    else if (row2[x] == 'D' && row2[x + 1] == 'E' && row2[x + 2] == 'U')
                    {
                        checkParams = false;
                    }

                    else if (row3[x] == 'D' && row3[x + 1] == 'E' && row3[x + 2] == 'U')
                    {
                        checkParams = false;
                    }

                    else if (row1[x] == 'U' && row1[x + 1] == 'E' && row1[x + 2] == 'D')
                    {
                        checkParams = false;
                    }

                    else if (row2[x] == 'U' && row2[x + 1] == 'E' && row2[x + 2] == 'D')
                    {
                        checkParams = false;
                    }

                    else if (row3[x] == 'U' && row3[x + 1] == 'E' && row3[x + 2] == 'D')
                    {
                        checkParams = false;
                    }

                    else if(row1[x]=='D' && row2[x+1]=='E' && row3[x+2]=='U')
                    {
                        checkParams = false;
                    }

                    else if (row1[x+2] == 'D' && row2[x + 1] == 'E' && row3[x] == 'U')
                    {
                        checkParams = false;
                    }

                    else if (row1[x] == 'U' && row2[x + 1] == 'E' && row3[x + 2] == 'D')
                    {
                        checkParams = false;
                    }

                    else if (row1[x + 2] == 'U' && row2[x + 1] == 'E' && row3[x] == 'D')
                    {
                        checkParams = false;
                    }

                    else if (row1[x] == 'D' && row2[x] == 'E' && row3[x] == 'U')
                    {
                        checkParams = false;
                    }

                    else if (row1[x] == 'U' && row2[x] == 'E' && row3[x] == 'D')
                    {
                        checkParams = false;
                    }
                }

                while(checkParams==true)
                {
                    
                    if (turn % 2 == 1)
                    {
                        player1Score -= 5;
                    }

                    else if (turn % 2 == 0)
                    {
                        player2Score -= 5;
                    }

                    Console.WriteLine("Player 1 Score: " + player1Score);
                    Console.WriteLine("Player 2 Score: " + player2Score);

                    turn += 1;

                    break;
                }

                

                Console.ReadLine();
                Console.Clear();


            }

            if(turn%2==1)
            {
                winnerName = "Player 1";
                winnerScore = player1Score;
            }

            else if (turn % 2 == 0)
            {
                winnerName = "Player 2";
                winnerScore = player2Score;
            }

            if(winnerScore>100)
            {
                string[] names = { winnerName,"Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                
            }

            while (checkParams == false)
            {
                Console.Write("A1");
                for (int i = 0; i < row1.Length; i++)
                {
                    Console.Write(row1[i]);
                }

                Console.WriteLine();

                Console.Write("A2");
                for (int i = 0; i < row2.Length; i++)
                {
                    Console.Write(row2[i]);
                }

                Console.WriteLine();

                Console.Write("A3");
                for (int i = 0; i < row3.Length; i++)
                {
                    Console.Write(row3[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Player 1 Score: " + player1Score);
                Console.WriteLine("Player 2 Score: " + player2Score);

                Console.WriteLine();
                Console.WriteLine("Game Over!");
                Console.WriteLine("Winner: " + winnerName);
                Console.WriteLine("Winner Score: " + winnerScore);
                break;
            }

            Console.WriteLine("HIGH SCORE TABLE");
            Console.WriteLine();

            if (winnerScore > 100)
            {
                string[] names = { winnerName, "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = {winnerScore, 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 };

                for(int i=0; i<names.Length;i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 95)
            {
                string[] names = {"Derya", "Elife", winnerName, "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan"};
                int[] scores = {100, 100, winnerScore, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30};

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 90)
            {
                string[] names = { "Derya", "Elife", "Fatih", winnerName, "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100,  95, winnerScore, 90, 85, 80, 80, 70, 55, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 85)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", winnerName, "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100, 95,  90, winnerScore, 85, 80, 80, 70, 55, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 80)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali",  "Azra", winnerName, "Sibel", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100, 95, 90,  85, winnerScore, 80, 80, 70, 55, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 70)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", winnerName, "Nazan", "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100, 95, 90, 85,  80, 80, winnerScore, 70, 55, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 55)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem",  "Nazan", winnerName, "Mehmet", "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100, 95, 90, 85, 80, 80,  70, winnerScore, 55, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 50)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", winnerName, "Nil", "Can", "Tarkan" };
                int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70,  55, winnerScore, 50, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore > 30)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet",  "Nil", winnerName, "Can", "Tarkan" };
                int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55,  50, winnerScore, 30, 30 };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }

            else if (winnerScore <= 30)
            {
                string[] names = { "Derya", "Elife", "Fatih", "Ali", "Azra", "Sibel", "Cem", "Nazan", "Mehmet", "Nil",  "Can", "Tarkan" ,winnerName};
                int[] scores = { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50,  30, 30, winnerScore };

                for (int i = 0; i < names.Length; i++)
                {
                    Console.Write(names[i]);
                    Console.SetCursorPosition(15, Console.CursorTop);
                    Console.WriteLine(scores[i]);
                }

            }



        }
    }
}
