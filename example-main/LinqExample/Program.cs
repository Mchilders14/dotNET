using System;
using System.Linq;
using SqlServerLibrary;


namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new
            {
                Id = 1,
                UserId = 1,
                Description = "Request 1"
            };

            var sqlLib = new SqlServerLib();

            sqlLib.Connect("localhost", "PRS");
            var user = sqlLib.UserGetAll();
            sqlLib.Disconnect();

            //var sortedUsers = users.OrderBy(u => u.Username).ToList();

            var sortedUsers = from u in user
                              join r in request
                              on u.Id equals r.userId
                              orderby u.Username descending
                              select new
                              {
                                  PK = u.Id,
                                  Login = u.Username
                              };



            foreach (var users in sortedUsers)
            {
                Console.WriteLine($"{users.PK} | {users.Login}");
            }
        }

        static void Linq()
        {

            int[] ints2 = new int[]
            {
                9879,5134,4662,6558,6951
            };

            var smallestSum = ints2.Sum() - ints2.Max();
            var largestSum = ints2.Sum() - ints2.Min();

            var smallestSum2 = ints2.OrderBy(i => i).Take(4).Sum();   // Takes the first four numbers in sorted array.
            var largestSum2 = ints2.OrderByDescending(i => i).Take(4).Sum();    // Takes the first four numbers in 


            Console.WriteLine($"Smallest Sum: {smallestSum}");
            Console.WriteLine($"Largest Sum: {largestSum}");
            Console.WriteLine($"Largest Sum V2: {smallestSum2}");
            Console.WriteLine($"Smallest Sum V2: {largestSum2}");

            int[] ints = new int[]
            {
                9879,5134,4662,6558,6951,6997,4634,9757,1691,8777,
                3996,4444,2508,8223,2205,5722,1026,6355,5487,6506,
                8748,5575,4434,3178,9094,6040,1669,5188,8927,3687,
                3767,2294,8467,4892,8657,2279,5424,9410,3492,4042,
                4919,5716,5858,2387,4218,7600,6063,9734,5282,1235,
                5527,8661,2139,5867,9729,4593,8522,5246,4329,8429,
                6919,5212,7215,3049,6722,2566,1834,2946,8306,6154,
                9542,7389,3825,3985,2385,5367,1393,7362,8701,5754,
                7453,5542,7657,6706,7116,4781,7050,3668,3812,6168,
                5035,1380,1164,4120,4146,7290,3518,7581,6727,5657
            };

            var countOfEven = ints.Where(i => i % 2 == 0).Count();
            var sum = ints.Where(i => i % 2 == 0).Sum();
            var max = ints.Max();
            var min = ints.Min();
            var divFiveOrSeven = ints.Where(i => i % 5 == 0 || i % 7 == 0).Average();



            Console.WriteLine($"There are {countOfEven} even numbers!");
            Console.WriteLine($"Sum of numbers is {sum}");
            Console.WriteLine($"Max is: {max}");
            Console.WriteLine($"Min is: {min}");
            Console.WriteLine($"Divisible by 5 or 7 Average: {divFiveOrSeven}");


        }
    }
}
