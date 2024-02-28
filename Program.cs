using System.Security.Cryptography.X509Certificates;

namespace Method_Demo
{
    internal class Program
    {
        public string art;
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER for a joke!");
            Console.ReadLine();
            Joke();
            Console.WriteLine("Press ENTER for another joke!");
            Joke(50);
            //Part A
            Console.WriteLine();
            Menu();
            DrawArt();

        }
        public static void JokeDen()
        {
            Console.WriteLine("Behold a performance that will make you laugh your life off! MWAHAHAHA.");
            Thread.Sleep(1500);
            Console.WriteLine("")
        }
        public static void DrawArt()
        {
            String art = "e";
            Console.WriteLine("Time for some art!");
            Console.WriteLine("What would you like to see first?");

            while (art != "x" && art != null)
            {
                Console.WriteLine("A) Robot \nB) The Beach \nC) A little treat \nX) No more art");
                art = Console.ReadLine().ToLower();
                if (art == "a")
                {
                   DrawRobot();
                    Console.WriteLine();
                    Console.WriteLine("Another?");
                }
             else if (art == "b")
                {
                    DrawBeach();
                   Console.WriteLine();
                    Console.WriteLine("Another?");
                }
            else if (art == "c")
                {
                    DrawTreat();
                    Console.WriteLine();
                    Console.WriteLine("Another?");
                }
            else if (art == "x")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for stopping by!");
                }
            else 
             {
                    Console.WriteLine();
                    Console.WriteLine("Looks like you've entered an invalid value try either a,b,c or x");
             }
            }




        }
        public static void Menu()
        {
            bool directory = true;
            string paths;
            Console.WriteLine("The count welcomes you, scared are you? \nToday he feels generous so you'll be entertained by his deathly servants");
            while (directory == true)
            {
                Console.WriteLine("To see reginald the renowned our A class painter type 'G' \nTo see Worchester the wraith, our castle jester type 'w' \nTo leave if you dare type 'LEAVE'");
                paths = Console.ReadLine().ToLower().Trim();
                if (paths == "g")
                {
                    DrawArt();
                }
                else if (paths == "w")
                {

                }
                else if (paths == "leave")
                {
                    directory = false;
                }
                else
                {
                    Console.WriteLine("That value is whack yo, TRY AGAIN");
                }
            }
            
        }
        public static void DrawRobot()
        {
            Console.WriteLine("  _______\r\n     _/       \\_\r\n    / |       | \\\r\n   /  |__   __|  \\\r\n  |__/((o| |o))\\__|\r\n  |      | |      |\r\n  |\\     |_|     /|\r\n  | \\           / |\r\n   \\| /  ___  \\ |/\r\n    \\ | / _ \\ | /\r\n     \\_________/\r\n      _|_____|_\r\n ____|_________|____\r\n/                   \\");
        }
        public static void DrawBeach()
        {
            Console.WriteLine("                   \\       /            _\\/_\r\n                     .-'-.              //o\\  _\\/_\r\n  _  ___  __  _ --_ /     \\ _--_ __  __ _ | __/o\\\\ _\r\n=-=-_=-=-_=-=_=-_= -=======- = =-=_=-=_,-'|\"'\"\"-|-,_ \r\n =- _=-=-_=- _=-= _--=====- _=-=_-_,-\"          |\r\njgs=- =- =-= =- = -  -===- -= - .\"");

        }
        public static void DrawTreat()
        {
            Console.WriteLine("                                 ,'', \r\n                              .a@a. \r\n                              `@@@' \r\n                         .,:::::::::::,. \r\n                     .,%%::::%%:::%:::%%%%,. \r\n                   .%%%%%%::%%%%:%%%:::%%%%%%. \r\n              .a@@@@@@@@a%%:%%%%%%%%::%%%%%%%% \r\n  .%%%,.     a@;@@@;@@@;@@;;%%%%%%%%%:mm:::::::::mm,.    .,%%%, \r\n %%%%%%%%,;;;@;;;@@;;@@;;;@;;;%%%%mmmmm::mm:::mm:::mmmm,%%%%%%%% \r\n`%%%%%%%%%%;;;;;;@;;;;@;;;;;;;;;mmmmmm::mmmm::mmmm::mm%%%%%%%%%%' \r\n `%%%%%%%%%%%%:::@::::::::::::::mmmmmmm:mmmmmmmmmmm:%%%%%%%%%%%' \r\n.\\\\\\\\,\\\\\\\\,\\\\\\\\,\\\\\\\\,\\\\\\\\,\\\\\\\\,\\|/,////,////,////,/::/,////,////. \r\n \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|//////////////////://////////// \r\n   `\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|/////////////////://////////' \r\n        `\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|/////////////////://///' \r\n             `\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\|///////////////////' \r\n                   `\\\\\\\\\\\\\\\\\\\\\\\\|////////////' \r\n                          `\\\\\\\\\\|/////'          ; \r\n                            `\\\\\\|///'           .:. \r\n                              \\\\|//            ::::: \r\n                           .,///|\\\\\\,.         `:::' \r\n                        .///////|\\\\\\\\\\\\\\.");

        }
        public static void Joke()
        {
            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs");
            Thread.Sleep(500);
            Console.WriteLine("fix a bug and run it again,");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code");

        }
        public static void Joke( int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine( numBugs + " little bugs");
            Thread.Sleep(500);
            Console.WriteLine(" Fix a bug, run it again,");
            Thread.Sleep(500);
            Console.WriteLine((numBugs++) + " little bugs in the code.");

        }
    }  
    

}