using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn2_AlbyBaby.Controllers
{
    public class J3ProblemController : ApiController
    {
        /// GET api/j3problem/hiddenpalindrome/{string}
        /// The longest palindrome that is contained in the word? That is, what is the
        /// longest palindrome that we can obtain, if we are allowed to delete characters from the beginning
        /// and/or the end of the string
        /// <summary>
        /// To find the longest palindrome hidden in the string if we delete the rest 
        /// of the characters from the beginning and the end
        /// </summary>
        /// <input>
        /// all the characters should be lowercase
        /// the number of characters should be between 1 and 40
        /// </input>
        /// <param name="inmsg"></param> Input message 
        /// <returns>The number of the largest palindrome in the given string</returns>
        /// <example>
        /// GET api/j3problem/hiddenpalindrome/anna ======>4
        /// GET api/j3problem/hiddenpalindrome/banana ======>5
        /// GET api/j3problem/hiddenpalindrome/annam ======>4(didn't get)
        /// GET api/j3problem/hiddenpalindrome/abracadabra ======>3(didn't get)
        /// </example>
        [HttpGet]
        [Route("api/j3problem/hiddenpalindrome/{inmsg}")]
        public string HiddenPalindrome(string inmsg)
        {
            int length = inmsg.Length;
            bool ispositive = length >= 1 && length <= 40;
            bool lowercase = false;
            bool ispalindrome;
            string revmsg;
            foreach (char c in inmsg)
            {
                Console.WriteLine(c);
                if (c >= 'a' && c <= 'z')
                {
                    lowercase = true;
                }
            }
            if (ispositive && lowercase)
            {
                //calling the reverse function
                revmsg = Reverse(inmsg);//without cutting the characters
                Console.WriteLine(revmsg);
                while (revmsg != inmsg)
                {
                    inmsg = inmsg.TrimStart(inmsg[0]);//cutting from the beginning
                    Console.WriteLine(inmsg);
                    revmsg = Reverse(inmsg);
                    length = inmsg.Length;
                }
                ispalindrome = true;
                if (ispalindrome)
                {
                    return length.ToString();
                }

            }
            return "invalid data";
        }
        /// <summary>
        /// method to calculate the reverse of a string
        /// </summary>
        /// <param name="msg"> the input message</param>
        /// <returns>the reverse message</returns>
        public string Reverse(string msg)
        {
            int length = msg.Length;
            string revmsg = "";
            for (int j = length - 1; j >= 0; j--)
            {
                Console.WriteLine(msg[j]);
                revmsg += msg[j];
            }
            return revmsg;
        }
    }
}