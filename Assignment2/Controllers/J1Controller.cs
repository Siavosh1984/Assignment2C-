using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// Write a program that will compute the total Calories of the meal in a Fast Food.
        /// </summary>
        /// <param name="i"> input integer stands for the index of burger in order (Cheeseburger (461 Calories), Fish Burger (431 Calories),
        /// Veggie Burger (420 Calories), no burger)</param>
        /// <param name="ii">input integer stands for the index of drink in order (Soft Drink (130 Calories), Orange Juice (160 Calories),
        /// Milk (118 Calories), no drink</param>
        /// <param name="iii"> input integer stands for the index of side dish in order (Fries (100 Calories), Baked Potato (57 Calories),
        /// Chef Salad (70 Calories), no side order</param>
        /// <param name="iv">input integer stands for the index of dessert in order (Apple Pie (167 Calories), Sundae (266 Calories),
        /// Fruit Cup (75 Calories), No Dessert</param>
        /// <returns>the total Calories of the meal</returns>
        /// Example 1 HTTP request: GET ../api/J1/Menu/4/4/4/4 >> Example Response: Your total calorie count is 0
        /// Example 2 HTTP request: GET ../api/J1/Menu/1/2/3/4 >> Example Response: Your total calorie count is 691

        [HttpGet]
        [Route("api/J1/Menu/{i}/{ii}/{iii}/{iv}/")]
        public string Menu(int i, int ii, int iii, int iv)
        {
            int[] Burger = { 461, 431, 420, 0 };
            int[] Drink = { 130, 160, 118, 0 };
            int[] Side = { 100, 57, 70, 0 };
            int[] Dessert = { 167, 266, 75, 0 };

            int TotalCalorie = Burger[i - 1] + Drink[ii - 1] + Side[iii - 1] + Dessert[iv - 1];

            return "Your total calorie count is " + TotalCalorie.ToString();

        }
    }
}
