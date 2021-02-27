using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn2_AlbyBaby.Controllers
{
    public class J2ProblemController : ApiController
    {
        ///Diana is playing a game with two dice.
        ///● One dice has m sides labelled 1, 2, 3 ..., m
        ///● The other dice has n sides labelled 1, 2, 3, …, n
        ///Write a program which determines how many ways she can roll the value of 10.
        /// <summary>
        /// To write a code to calculate the number of ways diane can get 10  value with 2 dice with {m} and {n} sides respectively.
        /// </summary>
        /// <param name="m">{m} - positive integer representing the number of sides on the first die</param>
        /// <param name="n">{n} - positive integer representing the number of sides on the second die</param>
        /// <returns> the ouput " There are {output} ways to get the sum 10"</returns>
        /// <example>
        /// GET api/j2problem/dicegame/6/8 ====>There are 5 total ways to get the sum 10.
        /// GET api/j2problem/dicegame/12/4 ====>There are 4 ways to get the sum 10.
        /// GET api/j2problem/dicegame/3/3 =====> There are 0 ways to get the sum 10.
        /// GET api/j2problem/dicegame/5/5 =====> There is 1 way to get the sum 10.
        /// </example>
        [HttpGet]
        [Route ("api/j2problem/dicegame/{m}/{n}")]
        public string Dicegame(int m,int n)
        {
            ///If it is 0 there is no die for the input  which contradicts the question
            bool mispositive = m > 0;
            bool nispositive = n > 0;
            int counter = 0;
            if (mispositive && nispositive)
            {
                for(int i = 0; i <= m; i++)
                {
                    for(int j =0; j<=n; j++)
                    {
                        int sum = i + j;
                        if (sum == 10)
                        {
                            counter += 1;
                        }
                    }
                }
                return "There are " + counter + " ways to get the sum 10.";
            }
            else
            {
                return "Invalid input data!!!!!!!!!!!!";
            }
        }
    }
}
