using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using PyramidWord.Models;

namespace PyramidWord.Controllers
{
    public class PyramidController : ApiController
    {
        // GET: api/Pyramid
        public String Get()
        {
            /**return new Pyramid
            {
                Result = $"You have not entered any word",
            };
    */
            return "You have not entered any word";
        }

        // GET: api/Pyramid/5
        public String Get(String id)
        {
            int result = 0;
            int count = 0;
            int blank = 0;
            int[] res_arr = new int[26];
            String new_id = id.ToLower();
            char[] ch_arr = new_id.ToCharArray();
            for(int i =0;i<ch_arr.Length;i++)
            {
                if (ch_arr[i].CompareTo(' ') == 0)
                {
                    blank = 1;
                }
                else
                {
                    count = ch_arr[i] - 'a';
                    res_arr[count]++;
                }
            }

            Array.Sort(res_arr);
            for(int i = 25; i >= 0; i--)
            {
                if(res_arr[i] != 0)
                {
                    if(res_arr[i] - res_arr[i-1] != 1)
                    {
                        result = 1;
                    }
                }
                else
                {
                    break;
                }
            }

            if(id.Length == 0 || blank == 1)
            {
                result = 1;
            }

            
            if(result == 1)
            {
                return id + " is not a pyramid word";
                /**return new Pyramid
                {
                   Result = $"The word entered is not a pyramid word" , 
                };*/

            }
            else if(result == 0)
            {
                 return id + " is a pyramid word";
                /**return new Pyramid
                {
                    Result = $"The word entered is a pyramid word",
                };
    */
            }
            else
            {
                return "Error Found";                /**
                return new Pyramid
                {
                    Result = $"Error found",
                };
    */
            }

            
        }
    }
}
