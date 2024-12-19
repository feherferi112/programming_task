using prog_tasks.Tasks.Task1;
using prog_tasks.Tasks.Task2;

namespace prog_tasks
{
    internal class Program
    {
               
        static void Main(string[] args)
        {            
            //Test for Task 1: 
            //Test 2D array interfaces
            var ob2 = new SeisTrcArray(5, 5);

            Console.WriteLine(" ");

            for (var row = 0; row < 5; row++)
            {
                Console.WriteLine("");
                for (var col = 0; col < 5; col++)
                {
                    if (col <= 4)
                    {
                        ob2.SetTraceSample(row, col, row * col);
                        Console.Write($"{ob2.GetTraceSample(row, col)} ");
                    }

                }
            }

            Console.WriteLine("\n\nTest 3D Cube interfaces:");
            //Test for Task 2: 
            //Test 3D cube interfaces
            var cube = new SeisCube3D(5, 5, 5);
            for (var row = 0; row < 5; row++)
            {
                Console.WriteLine($"\n\n{row}-th 2D array of the cube:");
                for (var col = 0; col < 5; col++)
                {
                    for(var depth = 0; depth < 5; depth++)
                    {
                        if (col <= 4)
                        {
                            cube.SetTrcSample(row, col, depth, row);
                            Console.Write($"{cube.GetTrcSample(row, col, depth)} ");
                        }
                    }
                    Console.WriteLine(" ");

                }
            }
        }
    }
}
