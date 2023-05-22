using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._6DataStructures
{
    internal class Program
    {
        //Use records(or equivalent) in the design of
        //solutions to simple problems.
        struct Town
        {

            //Town properties
            public string townName;
            public string county;
            public int population;
            public double area;

            //constructor for creating a new town
            public Town(string tName,string tCounty,int tPopulation,double tArea)
            {
                
                this.townName = tName;
                this.county = tCounty;
                this.population = tPopulation;
                this.area = tArea;
            }
        }
        static void Main(string[] args)
        {
            //Use arrays (or equivalent) in the design of
            //solutions to simple problems.

            // One dimensional arrays
            string[] names = { "Bob", "Betty", "Steve" };
            int[] scores = new int[4]; // array with 4 index locations
            scores[0] = 12;
            scores[1] = 30;
            scores[2] = 11;
            scores[3] = 19;
            //  scores[4] = 77; outside bounds - 4 is the length not the last index

            double[] scores2 = new double[] { 3.13, 22.23, 15.88, 17 };

            Console.WriteLine(names.Length); // length of names
            Console.WriteLine(scores[0]); // first value in scores
            Console.WriteLine(scores2[scores2.Length - 1]); // last value in scores 2

            // Two dimensional array
            int[,] tableData = { { 1, 2, 3, 4, 5, 6, 7 }, { 10,11,12,13,14,15,16 } };
            Console.WriteLine(tableData[0,0]); // 1
            Console.WriteLine(tableData[1,0]); // 10
            Console.WriteLine(tableData[tableData.GetLength(0)-1,tableData.GetLength(1)-1]); // 16

            string[,] UserPwd = new string[4, 4];
            UserPwd[0, 0] = "Bob";
            UserPwd[0, 1] = "letmein";
            UserPwd[1, 0] = "Ben";
            UserPwd[1, 1] = "12345";

            Console.WriteLine(UserPwd.GetLength(0));
            Console.WriteLine(UserPwd.GetLength(1));

            // looping through arrays

            foreach (int number in scores) // goes through each item in the array
            {
                Console.WriteLine(number); 
            }

            for(int i = 0; i < scores.Length; i++) // uses index referencing in the array
            {
                Console.WriteLine(scores[i]);
            }

            foreach(string unPw in UserPwd) // for each works on 2D array, does sequence [0,0], [0,1], ..., [0,n], [1,0], [1,1], ...., [n,n] 
            {
                Console.WriteLine(unPw);
            }

            //Using structures (records)
            Town heckmondwike = new Town("Hecky", "W Yorks", 350, 120.5); // creates a new town with all properties allocated
            Console.WriteLine(heckmondwike.townName);

            
            Town batley; // creates a town with no properties
            batley.townName = "Batley";
            batley.population = 100;
            batley.county = "W Yorks";
            batley.area = 66.4;
            Console.WriteLine(batley.population);

        }
    }
}
