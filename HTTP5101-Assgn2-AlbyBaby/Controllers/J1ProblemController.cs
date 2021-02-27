using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn2_AlbyBaby.Controllers
{
    public class J1ProblemController : ApiController
    {
        ///You know a family with three children. Their ages form an arithmetic sequence: the difference in
        ///ages between the middle child and youngest child is the same as the difference in ages between
        ///the oldest child and the middle child.For example, their ages could be 5, 10 and 15, since both
        ///adjacent pairs have a difference of 5 years.
        ///Given the ages of the youngest and middle children, what is the age of the oldest child?
        /// <summary>
        /// To find out the age of the oldest child from the ages of middle and younger child as they follow a pattern as the 
        /// difference between the oldest and middle is equal to difference between the middle and youngest
        /// we also have to validate  the input data  ie  (0 ≤ Youngest ≤ 50) and (Youngest ≤ Middle ≤ 50).
        /// </summary>
        /// <param name="youngest"></param>
        /// <param name="middle"></param>
        /// <returns>
        /// the age of the oldest child
        /// </returns>
        /// <example>
        /// GET api/j1problem/agesequence/12/15 ====> 18
        /// GET api/j1problem/agesequence/10/10 ====> 10
        /// GET api/j1problem/agesequence/3/10 =====> 17
        /// GET api/j1problem/agesequence/15/12 ====> "please enter a valid input"
        /// GET api/j1problem/agesequence/-10/10 ====> "please enter a valid input"
        /// GET api/j1problem/agesequence/3/60 =====> "please enter a valid input"
        /// </example>
        [HttpGet]
        [Route ("api/J1Problem/agesequence/{youngest}/{middle}")]
        public string Agesequence(int youngest ,int middle)
        {
            ///condition to validate the input data
            bool Ispositive = youngest >= 0 && youngest <= 50;
            bool positive = middle >= youngest && middle <= 50;
            if (Ispositive && positive )
            {
                int oldest = (2 * middle) - youngest;
                return oldest.ToString();
            }
            else
            {
                return "Please enter a valid input ";
            }
        }
    }
}
