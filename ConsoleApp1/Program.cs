using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static string[,] puzzle;
    public static string[,] puzzletrue;
    #region main
    private static void Main(string[] args)
    {
        puzzle = new string[4, 4]
        {   {" 5"," 4","12","10" },
            {" 7"," 9","11"," 8" },
            {"  "," 2","15","13"},
            {" 6","14"," 3"," 1" }
        };
        puzzletrue = new string[4, 4]
        {   {" 1"," 2"," 3"," 4"},
            {" 5"," 6"," 7"," 8"},
            {" 9","10","11","12"},
            {"13","14","15","  "}
        };
        while (true)
        {
            toshow(puzzle);
            var key = Console.ReadKey();
            Console.Clear();

            Console.WriteLine(key.Key);
           
            if (key.Key == ConsoleKey.DownArrow)
            {
                puzzle = Todown(puzzle);
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                puzzle = Toup(puzzle);
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                puzzle = Toright(puzzle);
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                puzzle = Toleft(puzzle);
            }
        }
    }
    #endregion

    #region to up
    public static string[,] Toup(string[,] array) 
    {
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                if (array[i, j] == "  ")
                {
                    if (i + 1 < 4)
                    {
                        array[i, j] = array[i + 1, j];
                        array[i+1, j] = "  ";
                        return array;
                    }
                    return array;
                } 
            }
        }
        return array;
    }
    #endregion

    #region to down
    public static string[,] Todown(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "  ")
                {
                    if (i - 1 > -1)
                    {
                        array[i, j] = array[i - 1, j];
                        array[i - 1, j] = "  ";
                        return array;
                    }
                    return array;
                }
            }
        }
        return array;
    }
    #endregion

    #region to right
    public static string[,] Toright(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "  ")
                {
                    if (j - 1 > -1)
                    {
                        array[i, j] = array[i, j-1];
                        array[i, j-1] = "  ";
                        return array;
                    }
                    return array;
                }
            }
        }
        return array;
    }
    #endregion

    #region to left
    public static string[,] Toleft(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "  ")
                {
                    if (j + 1 < 4)
                    {
                        array[i, j] = array[i , j+1];
                        array[i, j+1] = "  ";
                        return array;
                    }
                    return array;
                }
            }
        }
        return array;
    }
    #endregion

    #region to show
    public static void toshow(string[,] array) 
    {
        for(int i = 0;i < array.GetLength(0);i++) 
        {
            Console.WriteLine("-------------");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("|"+array[i, j]);

                if (array[i, j] == array[i, 3])
                {
                    Console.WriteLine("|");
                }
            }
        }
        Console.WriteLine("-------------");
    }
    #endregion
}
