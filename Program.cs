using static System.Net.Mime.MediaTypeNames;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int size;

            //gets int input from user

            while (true)
            {
                Console.WriteLine("Write in a number to decide how large the chessboard will be:");

                dynamic number = Console.ReadLine();

                bool success = (int.TryParse(number, out size));
                if(success)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("failed must input must be an integer");
                }
            }

            //creates the chessboard
            
            for (int i = 0; i <size; i++)
            {
                Console.WriteLine();
               
                if (i % 2 == 0)
                {
                    for (int ii = 0; ii < size; ii++)
                    {
                        if (ii % 2 == 0)
                        {
                            Console.Write("◼︎ ");

                        }
                        else
                        {
                            Console.Write("◻︎ ");
                        }
                    }
                }
                else
                {
                    for (int iii = 0; iii < size; iii++)
                    {
                        if (iii % 2 != 0)
                        {
                            Console.Write("◼︎ ");

                        }
                        else
                        {
                            Console.Write("◻︎ ");
                        }


                    }

                }
            }
        }
    }
}
