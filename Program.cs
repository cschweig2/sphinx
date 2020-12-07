using System;
using System.Collections.Generic;
using Sphinx.Riddles;

namespace Sphinx
{
  class Questions
  {
    static void Main()
    {
      Console.WriteLine("Always wax, yet always wane: I melt, succumbéd to the flame. Lighting darkness, with fate unblest, I soon devolve to shapeless mess.");
      string answerOne = Console.ReadLine();

      bool candle = answerOne == "candle";

      if (candle)
      {
        Console.WriteLine("You are Correct, you won't be eaten, you filthy mortal");
      }
      else if(!candle)
      {
        Console.WriteLine("Incorrect, prepare to be eaten");
      }
    }
  }
}


// //Console.WriteLine three questions
// boolean true/false
// console.ReadLine for userAnswer
// Console.WriteLine for the answer
// method to randomize