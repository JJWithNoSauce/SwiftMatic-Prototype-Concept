using System;

namespace SwiftMatic_Prototype
{
    class Valuable
    {
        public int highscore = 0;
        public string highname = "none";

        public int ExceptAns = 2546;
        public int ExitCode = 205;


        public int gain = 100;
        public int life = 3;
    }

    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("SwiftMatic's concept Prototype\nJJWithNoSauce\n-------------------------------------\n");
            Intro();
            Menu();
        }



        static void Intro() 
        {
            //Title
            Console.WriteLine("  123456789123       123456                           123456       123456    1234567891234567      1234567891234567891234");
            Console.WriteLine("12345678912345        123456                         123456         1234     1234567891234567        12345678912345678");
            Console.WriteLine("1234                   123456        123456         123456                   1234                           1234");
            Console.WriteLine(" 123456789123           123456     1234  1234      123456           1234     1234567891                     1234");
            Console.WriteLine("           1234          123456   12345   12345   123456            1234     1234567                        1234");
            Console.WriteLine("12345678912345            123456 12345    12345 123456              1234     1234                           1234");
            Console.WriteLine("  123456789123              123456           123456                 1234     1234                           1234\n\n");

            Console.WriteLine("            1234567891234      1234567891234                       123456789123456    1234567891234567891234    123456            12345678912345678912345");
            Console.WriteLine("           123456     123456   123456  123456                   12345678912345678        12345678912345678       1234           123456789123456789123456");
            Console.WriteLine("          123456        123456789123    123456                123456       123456              1234                             1234567");
            Console.WriteLine("         123456           1234567        123456             12345678912345678912               1234              1234           1234567");
            Console.WriteLine("        123456                            123456           123456123456789123456               1234              1234           1234567");
            Console.WriteLine("       123456                              123456         123456          123456               1234              1234           123456789123456789123456");
            Console.WriteLine("      123456                                123456       123456           123456               1234              1234             12345678912345678912345");

            Console.WriteLine("\n\nThis is a prototype or concept of the game called SwiftMatic. SwiftMatic is a math game. This version's gameplay will progress endlessly.");
            Console.WriteLine("As the game progress you will gain combo. The more combo you get the more score you will get. try to make the best of your scores.");
            Console.WriteLine("The purpose is to strenghthen your calculation and have fun at the same time. Made using visual studio with C# computer language\n\n---Display best in fullscreen---");
            Console.WriteLine("\nThank you for playing! -JJWithNoSauce 2021");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();

            Console.Clear();

        }
        static void Menu()
        {
            //surface
            int option1 = 1;
            int option2 = 2;
            int option = 0;

            int loop = 1;
            int loopaccess = 1;
            
            
            while (loop == loopaccess) 
            {
                Console.WriteLine("              #  #### #                    #     #       ");
                Console.WriteLine("                #     #                    #             ");
                Console.WriteLine(" ##### #  # # # #     #####  ## ##   ##### ##### #  #####");
                Console.WriteLine("#      #  # # # ##### #      # #  # #    # #     # #     ");
                Console.WriteLine(" ####  #  # # # #     #      # #  # #    # #     # #     ");
                Console.WriteLine("     # #  # # # #     #      # #  # #    # #     # #     ");
                Console.WriteLine("#####   ## ## # #      ####  # #  #  ##  #  #### #  #####");

                Console.WriteLine("\nCreated by JJWithNoSauce");
                
                Console.WriteLine("\n1.Start the Matic!");
                Console.WriteLine("2.Exit\n\n>>>");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input : " + error.Message);
                }
                
                if (option == option1)
                {
                    Gameplay();
                }
                else if (option == option2)
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error : Incorrect input.");
                }
            }
            

            
            

            Console.ReadLine();
        }

        static void Gameplay()
        {
            Console.Clear();
            var all = new Valuable();
            
            int active = 1;
            int inactive = 1;
            
            string PlayersName = "";

            int AnsReply = 0;


            //Collect Name
            Console.WriteLine("   .------ / ------.");
            Console.WriteLine("   | -             |");
            Console.WriteLine("   |               |");
            Console.WriteLine("   |               |");
            Console.WriteLine("   |               |");
            Console.WriteLine("_______________________");
            Console.WriteLine("===========.===========");
            Console.WriteLine("   ~~~~~     ~~~~~  ");
            Console.WriteLine("      0         0     ");
            Console.WriteLine(" W   ---    ---   W");
            Console.WriteLine(" .      |o o|      .");
            Console.WriteLine("                   ");
            Console.WriteLine("      #########    ");
            Console.WriteLine("     ## ----- ##  ");
            Console.WriteLine("    ##         ##");
            Console.WriteLine("     _____v_____");


            Console.WriteLine("\n\nWalter : What's your name mister professor?\nYour name :");
            PlayersName = Console.ReadLine();

            Console.Clear();

            Random generate = new Random();

            int Score = 0;
            int Combo = 0;
            int Bonus = 1;
            int BonusBoost = 0;

            int ingamelife = all.life;
            
          

            while (active == inactive) 
            {
                //count answer
                int attempt = 0;
                
                
                string plus = "+";
                string minus = "-";

                //qualificating and generating
                int first = generate.Next(1,12);
                int second = generate.Next(1,12);
                int third = generate.Next(1, 12);

                int solu = generate.Next(1, 7);
                string question = "";

                int correct = 0;

                switch (solu)
                {
                    case 1:
                        question = first + " " + plus + " " + second + "?";
                        correct = first + second;
                        break;
                    case 2:
                        question = first + " " + minus + " " + second + "?";
                        correct = first - second;
                        break;
                    case 3:
                        question = first + " " + plus + " " + second + " " + plus + " " + third + "?";
                        correct = first + second + third;
                        break;
                    case 4:
                        question = first + " " + plus + " " + second + " " + minus + " " + third + "?";
                        correct = first + second - third;
                        break;
                    case 5:
                        question = first + " " + minus + " " + second + " " + minus + " " + third + "?";
                        correct = first - second - third;
                        break;
                    case 6:
                        question = first + " " + minus + " " + second + " " + plus + " " + third + "?";
                        correct = first - second + third;
                        break;
                }
                

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("-----                                             -----");
                Console.WriteLine("---                                                 ");
                Console.WriteLine("--  Combo : "+ Combo +"!                             ");
                Console.WriteLine("--  Score : "+ Score +"                              ");
                Console.WriteLine("--  Bonus : X"+ Bonus +"                             ");
                Console.WriteLine("--  Life : " + ingamelife + " Heart(s)!                             ");
                Console.WriteLine("--                                                   --");
                Console.WriteLine("--                   "+ question +"                  ");
                Console.WriteLine("--                                                   --");
                Console.WriteLine("--                                                   --");
                Console.WriteLine("--                                                   --");
                Console.WriteLine("---                                                 ---");
                Console.WriteLine("-----                                             -----");
                Console.WriteLine("-------------------------------------------------------");

                Console.WriteLine("Answer :");
                try
                {
                    AnsReply = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception error)
                {
                    Console.WriteLine("\nError : " + error);
                }

                //Ans Check
                if(AnsReply == correct)
                {
                    Combo++;
                    attempt++;
                    BonusBoost++;
                    Score = Score + (all.gain*Bonus);
                    
                    
                    switch(BonusBoost)
                    {
                        case 5:
                            Bonus = Bonus + 2;
                            BonusBoost = 0;
                            break;
                    }
                }
                else if(AnsReply == all.ExceptAns) 
                {
                    Combo++;
                    attempt++;
                    BonusBoost++;
                    Score = Score + (all.gain * Bonus);

                    switch (BonusBoost)
                    {
                        case 7:
                            Bonus = Bonus + 2;
                            BonusBoost = 0;
                            break;
                    }
                }
                else if (AnsReply == all.ExitCode)
                {
                    ingamelife = 0;
                }
                else
                {
                    Combo = 0;
                    BonusBoost = 0;
                    Bonus = 1;
                    ingamelife = ingamelife - 1;
                }

                //Life Check
                if(ingamelife < 1)
                {
                    Console.Clear();
                    Console.WriteLine("  GGGG    AAA   MM    MM EEEEEEE   OOOOO  VV     VV EEEEEEE RRRRRR  !!!");
                    Console.WriteLine(" GG  GG  AAAAA  MMM  MMM EE       OO   OO VV     VV EE      RR   RR !!!");
                    Console.WriteLine("GG      AA   AA MM MM MM EEEEE    OO   OO  VV   VV  EEEEE   RRRRRR  !!!");
                    Console.WriteLine("GG   GG AAAAAAA MM    MM EE       OO   OO   VV VV   EE      RR  RR     ");
                    Console.WriteLine(" GGGGGG AA   AA MM    MM EEEEEEE   OOOO0     VVV    EEEEEEE RR   RR !!!");

                    Console.WriteLine("\n\nYour Result Was :");
                    Console.WriteLine("--Combo : " + Combo + "!");
                    Console.WriteLine("--Score : " + Score);
                    Console.WriteLine("--Bonus : X" + Bonus);

                    if(Score < 700)
                    {
                        Console.WriteLine("\nComment : The more step you take the better you become! Keep it up friend!");
                    }
                    else if(Score > 1400)
                    {
                        Console.WriteLine("\nComment : A good progress! Well done!");
                    }

                    Console.WriteLine("--Press Enter--");
                    Console.ReadKey();
                    Console.Clear();


                    //HighScore Applier
                    Console.WriteLine("   .------ / ------.");
                    Console.WriteLine("   | -             |");
                    Console.WriteLine("   |               |");
                    Console.WriteLine("   |               |");
                    Console.WriteLine("   |               |");
                    Console.WriteLine("_______________________");
                    Console.WriteLine("===========.===========");
                    Console.WriteLine("   ~~~~~     ~~~~~             Your score : " + Score);
                    Console.WriteLine("      0         0              Name : " + PlayersName);
                    Console.WriteLine(" W   ---    ---   W");
                    Console.WriteLine(" .      |o o|      .           High score : " + all.highscore);
                    Console.WriteLine("                               Record holder : " + all.highname);
                    Console.WriteLine("      #########    ");
                    Console.WriteLine("     ## ----- ##  ");
                    Console.WriteLine("    ##         ##");
                    Console.WriteLine("     _____v_____");

                    if (Score > all.highscore)
                    {
                        all.highscore = Score;
                        all.highname = PlayersName;


                        Console.WriteLine("\nWalter : Hmm... It seems that you have out done yourself.\nCongratulation on beating the highscore.\n Your name will be remembered.");
                        Console.WriteLine("\n\nThank you for playing! \nPress enter to continue");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\nWalter : You might not have done it this time. But that doesn't mean you have to like it");
                        Console.WriteLine("\n\nThank you for playing! \nPress enter to continue");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    Console.Clear();
                    break;
                }

                Console.Clear();
            }
        }

        
    }
}
