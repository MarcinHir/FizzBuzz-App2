using System;

namespace FizzBuzz_App2
{
    internal class FizzBuzz
    {
        public string GetNumber(int number)
        {
                    if (number % 3 == 0 && number % 5 == 0)
                        return "FizzBuzz";
                    else if (number % 3 == 0)                    
                        return "Fizz";               
                    else if (number % 5 == 0)                   
                        return "Buzz";                    
                    else
                        return $"Twoja liczba to {number}. Spróbuj jeszcze raz:";
                }
            }
        }
    

