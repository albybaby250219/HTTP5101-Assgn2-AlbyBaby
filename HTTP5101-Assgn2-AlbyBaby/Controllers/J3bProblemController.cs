using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assgn2_AlbyBaby.Controllers
{
    public class J3bProblemController : ApiController
    {
        /*every consonant is replaced by three letters, in the following ˚
          order:
          • the consonant itself;
          • the vowel closest to the consonant in the alphabet(e.g., if the consonant is d, then the closest
            vowel is e), with the rule that if the consonant falls exactly between two vowels, then the
            vowel closer to the start of the alphabet will be chosen(e.g., if the consonant is c, then the
            closest vowel is a);
          • the next consonant in the alphabet following the original consonant(e.g., if the consonant is
            d, then the next consonant is f) except if the original consonant is z, in which case the next
            consonant is z as well.
          Vowels in the word remain the same. (Vowels are a, e, i, o, u and all other letters are consonants.)*/
        /// <summary>
        ///  to change the word into a code using a specified format
        /// </summary>
        /// <param name="input">input word within 30 letters and lowercase</param>
        /// <returns> the coded word </returns>
        /// <example>
        /// GET  api/j3bproblem/robberslang/joy ========>jokoyuz
        /// GET api/j3bproblem/robberslang/ham =========>hijamon
        /// GET api/j3bproblem/robberslang/banana =========>bacanopanopa
        /// </example>
        [HttpGet]
        [Route ("api/j3bproblem/robberslang/{input}")]
        public string Robberslang(string input)
        {   
            ///validating the input to whether lowercase and within 30 characters 
            int strlength = input.Length;
            bool ispositive = strlength >= 1 && strlength <= 30;
            bool lowercase = false;
            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                {
                    lowercase = true;
                }
            }
            if (ispositive && lowercase)
            {
                string output = "";
                foreach(char c in input)
                {        
                    bool checkvowel = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
                    if (checkvowel)
                    {
                        output += c;
                    }
                    else
                    {
                        char nextchar = (char)((int)c + 1);
                        if (nextchar == 'a' || nextchar == 'e' || nextchar == 'i' || nextchar =='o' || nextchar == 'u')
                        {
                            nextchar = (char)((int)nextchar + 1);
                        }
                        if (c =='b'|| c== 'c')
                        { 
                            output = output + c + 'a' + nextchar;
                        } 
                        if(c == 'd' ||c == 'f'|| c== 'g')
                        {
                            output = output + c + 'e' + nextchar;
                        }
                        if (c == 'h' || c == 'j' || c == 'k'|| c == 'l')
                        {
                            output = output + c + 'i' + nextchar;
                        }
                        if (c == 'm' || c == 'n' || c == 'p' || c == 'q'||c =='r')
                        {
                            output = output + c + 'o' + nextchar;
                        }
                        if (c == 's' || c == 't' || c == 'v' || c == 'w' || c == 'x'|| c== 'y')
                        {
                            output = output + c + 'u' + nextchar;
                        }
                        if(c == 'z')
                        {
                            output = output + c + 'u' + c;
                        }
                    }

                }
                return output;
            }
            return "Invalid input";
        }
       
    }
}
