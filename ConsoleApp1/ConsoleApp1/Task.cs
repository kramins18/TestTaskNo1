using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Task
    {
        private int[,] array;
        public Task()
        {
            array = new int[20, 20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }
        public void PrintArray()
        {
            Console.WriteLine("\t\t Printing Array");
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void PrintSmallestLargestValues()
        {
            int maxVal = Int32.MinValue;
            int minVal = Int32.MaxValue;
            string minValueString;
            string maxValueString;
            List<int[]> maxAdresses = new List<int[]>();
            List<int[]> minAddreses = new List<int[]>();

            // LOOKING FOR SMALLEST AND LARGEST VALUES IN ARRAY
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (array[i, j] > maxVal)
                    {
                        maxVal = array[i, j];
                    }
                    if (array[i, j] < minVal)
                    {
                        minVal = array[i, j];
                    }
                }
            }

            minValueString = "SMALLEST VALUE IS: " + minVal + " It's located at : ";
            maxValueString = "LARGEST VALUE IS: " + maxVal + " It's located at : ";

            //WHEN VALUES ARE FOUND, LOOKING FOR ADRESSES THAT MATHCES MAX AND MIN VALUE
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (array[i, j] == maxVal)
                    {
                        maxAdresses.Add(new int[2] { i, j });
                    }
                    if (array[i, j] == minVal)
                    {
                        minAddreses.Add(new int[2] { i, j });
                    }
                }
            }      
            //PREPEARING STRING
            foreach (var item in minAddreses)
            {
                minValueString += "\n\tRow: " + (item[0]+1) + "\t Col: " + (item[1]+1);
            }
            foreach (var item in maxAdresses)
            {
                maxValueString += "\n\tRow: " + (item[0]+1) + "\t Col: " + (item[1]+1);
            }
            Console.WriteLine(maxValueString);
            Console.WriteLine(minValueString);
        }
        public void PrintArrayAscending() 
        {
            //HERE IS THE PLAN : CHANGE ARRAY TO ONE DIMENSION 400 ITEMS, THEN ORDER ASCENDING THEN CHANGE BACK!
            int[] oneDimensonalArray = new int[400];
            int[,] twoDimensionalsorted = new int[20, 20];


            //TWO DIMENSION -> ONE DIMENSION
            int oneDimLocation = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    oneDimensonalArray[oneDimLocation] = array[i, j];
                    oneDimLocation++;
                }
            }

            Array.Sort(oneDimensonalArray);
            
            //One Dimension -> TWO DImension
            int row = -1;  //-1 becouse 0/20 = 0;
            int col = 0;          
            //HERE COMES MESSY PART =] // 
            for (int i = 0; i < 400; i++)
            {
                if ((i) % 20 == 0)
                {
                    row++;
                    col = 0;
                }
                else
                {
                    col++;
                }
                twoDimensionalsorted[row, col] = oneDimensonalArray[i];
            }
            //PRINTING
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(twoDimensionalsorted[i,j] + "\t");
                }
                Console.WriteLine();          
            }                  
        }     
    }
}
