using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge_2_4_Endpoints_MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class API3EndpointController : ControllerBase
    {
        [HttpGet("/sumOfTwo")]
        public string sumOfTwo(double a, double b){
            double sum = a + b;
   
            string result = "The sum of " + a + " and " + b + " is " + sum + ".";
            return result;
        }

        [HttpGet("/oneSentence")]
        public string oneSentence(string yourName, string timeYouAwoke){
            string result = "Hello " + yourName + "! I see you woke up at " + timeYouAwoke + ". I hope you are well rested! Go make that money!";
            return result;
        }

        [HttpGet("/greaterThanLessThanEqual")]
        public string greaterThanLessThanEqual(double a, double b){
            // establish two results
            string resultOne = "";
            string resultTwo = "";

            // check for comparisons
            if (a > b){
                resultOne = a + " is greater than " + b + "!";
                resultTwo = b + " is less than " + a + "!";
            }

            else if (b > a){
                resultOne = b + " is greater than " + a + "!";
                resultTwo = a + " is less than " + b + "!";   
            }

            else {
                resultOne = b + " is equal to " + a + "!";
                resultTwo = a + " is equal to " + b + "!";
            }
    
            string statement = resultOne + "\n" + resultTwo;
            return statement;
        }
    }
}