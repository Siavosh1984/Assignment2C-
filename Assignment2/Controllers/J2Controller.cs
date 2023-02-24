using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// determines how many ways we can roll the value of 10 using two dice with m and n sides
        /// </summary>
        /// <param name="m">positive integer stands for number of sides first die has</param>
        /// <param name="n">positive integer stands for number of sides second die has</param>
        /// <returns>total number of ways to get the sum 10 rolling two dice</returns>
        /// Example 1 Example HTTP request: GET ../api/J2/DiceGame/6/8 >> Example Response: There are 5 total ways to get the sum 10.
        /// Example 2 Example HTTP request: GET ../api/J2/DiceGame/12/4 >> Example Response: There are 4 ways to get the sum 10.
        


        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {

            int counter1 = 1;

            int Total = 0;
            while (counter1 <= m)
            {

                for (int counter2 = 1; counter2 <= n; counter2++)

                {
                    int Tot = counter1 + counter2;
                    if (Tot == 10)
                    {

                        Total = Total + 1;

                    }
                }


                counter1 = counter1 + 1;

            }

            return "There are " + Total.ToString() + " ways to get the sum 10.";
        }
    }
}
