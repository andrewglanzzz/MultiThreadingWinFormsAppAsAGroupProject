/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

/* 
Name: Andrew Glanz
Date: November 3rd 2020
Due Date: November 5th 2020
Assignment: #07
Email: glanzad@mail.uc.edu
Desc: MultiThreading GUI Group Project
Citations: N/A
Comments: N/A
 */
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class PropitiousParakeet : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Chirp chirp! Greetings from " + this.GetType().Name); // I was able to check console output by changing the project from a windows form app to a console app inside of the properties. I have changed it back to a windows form application for submission, but I can verify that printing the friendly message is operational.
        }
        public override void RunThread()
        {
            long num = Convert.ToInt64(request); // assigns the value of request to the variable num
            long largestFactor = 0; // assigning placeholder value for variable largestFactor. will eventually be overwrittin assuming a number has a prime factor.

            int i = 2;
            while (i * i <= num) { // this runs until the outer boundary is hit, which is num. in this case, num is 356291053
                if (num % i == 0) { // this if statement checks for a prime factor. if there is a prime factor, i is assigned to largestFactor. this will overwrite previous values held by largestFactor. if there is no prime factor, i is incremented. 
                    num = num / i;
                    largestFactor = i; 
                } else {
                    i++;
                }
            }
            if (num > largestFactor) { 
                largestFactor = num;
                response = Convert.ToString(largestFactor); // assigns the value of largestFactor to the class member response for comparison when RunThread() is called
            }
        }

    }
}
