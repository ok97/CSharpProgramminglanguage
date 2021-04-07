using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePrograms
{      /* User input and Replace String Template “Hello<<UserName>>,How are you?"
           a. I/P: - Take user Name as Input. Ensure UserName has min 3 char
           b. Logic: - Replace<<UserName>> with the proper name
           c. O/P: - Print the String with user Name
      */

    class ReplaceString
    {
        public void ReadInput()
        {
            Console.WriteLine("Before Template Changes Hello <<UserName>> How are you?");
            string template = "Hello <<UserName>>, How are you?";  //Given String Template
            Console.Write("Enter Your Name:- ");        //Take Name from User
            string userInput = Console.ReadLine();      
            ReplaceWord(template, userInput);       //calling Method
        }

        private void ReplaceWord(string template, string userInput)   //ReplaceWord Method
        {
            string result = template.Replace("<<UserName>>",userInput);     // Store Result result variables
            Console.WriteLine("After Template Changes\n" + result);         // Display result
            string fine=Console.ReadLine();
            Console.WriteLine($"{userInput} is {fine}");
        }
    }
}
