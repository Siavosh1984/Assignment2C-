using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// calculate a distance table that indicates the distance between any two of the cities you have encountered
        /// on a very straight road.
        /// </summary>
        /// <param name="i">the  integer represents the distance between first and second city</param>
        /// <param name="ii">the  integer represents the distance between second and second third</param>
        /// <param name="iii">the  integer represents the distance between third and fourth city</param>
        /// <param name="iv">the  integer represents the distance between fourth and second fifth</param>
        /// <returns>Calculating distance between each pair of cities on my very straight road.</returns>
        /// Example HTTP request: GET ..api/J3/DistanceCount/3/10/12/5 >> 
        /// Example Response:
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// Extra Explaination: Unfortunately I could not get return in Matrix form 
        /// as requested, although I tried hard. Sorry for that!


        [HttpGet]
        [Route("api/J3/DistanceCount/{i}/{ii}/{iii}/{iv}/")]
        public int[,] DistanceCount(int i, int ii, int iii, int iv)
        {

            int[,] D1 = {{0, i, (i+ii), (i + ii + iii), (i + ii + iii + iv)}, { i, 0, ii, (ii + iii), (ii + iii + iv) },
                            {(i+ii), ii, 0, iii, (iii + iv)},{(i + ii + iii),(ii + iii),iii, 0, iv},
                            { (i + ii + iii + iv), (ii + iii + iv), ( iii + iv), iv, 0}};


            return D1;



        }

    }
}
