using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicMoq.DAL
{
    // 1. Implement the IQuestions Interface
    // 2. Use the methods in your Answers class to address tasks/questions posed by this class
    // 3. Access an instance of your Answers class using the "Wand"
    public class Questions : IQuestions
    {
        public Answers Wand { get; set; } // This is important. Do not delete this.

        public Questions()
        {
            Wand = new Answers();//the equals sign in line 13 setting the Answers
        }
        public Questions(Answers answers)
        {
            Wand = answers;
        }

        public int OnePlusOne()
        {
            //throw new NotImplementedException();
            //return Wand.Two();
            return Wand.One() + Wand.One();
        }

        public int ZeroPlusZero()
        {
            return Wand.Zero();
        }

        public int FourPlusZero()
        {
            return Wand.Four() + Wand.Zero();
        }

        public int TwoMinusZero()
        {
            return Wand.Two() - Wand.Zero();
        }

        public int OnePlusTwo()
        {
            return Wand.One() + Wand.Two();
        }

        public int TwoPlusTwo()
        {
            return Wand.Two() + Wand.Two();
        }

        public int OneMinusOne()
        {
            //Option 1:// Passes without 
            //return Wand.Zero();
           //option 2:
           return Wand.One() - Wand.One(); 
        }

        public int FourMinusTwo()
        {
            return Wand.Four() - Wand.Two();
        }

        public int FourMinusTwoPlusOne()
        {
            return Wand.Four() - Wand.Two() + Wand.One();
        }

        public string SayNothing()
        {
            return Wand.EmptyString();
        }

        public bool ReturnFalse()
        {
            return Wand.False();
        }

        public bool ReturnTrue()
        {
            return Wand.True();
        }

        public bool ReturnTruev2()
        {
            return !Wand.False();
        }

        public string SayHelloWorld()
        {
            return Wand.HelloWorld();
        }

        public List<int> CountToFive()
        {
            return Wand.ListOfNInts(5);
        }

        public List<int> FirstThreeEvenInts()
        {
            //return Wand.ListOfNInts(6);
            List<int> numbers = Wand.ListOfNInts(6);//Presorted
            //use numbers.Sort() if ListOfNInts doesn't run
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        public List<int> FirstThreeOddInts()
        { 
            List<int> numbers = Wand.ListOfNInts(10); //Presorted
            //use numbers.Sort() if ListOfNInts doesn't run
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    result.Add(number);
                }
                if (result.Count == 3)
                {
                    break;//exit loop
                }
            }
            return result;//out of loop to insure the return is used
    }

        public int CountToFive(int v)
        {
            throw new NotImplementedException();
        }

        public int FirstThreeOddInts(int v)
        {
            throw new NotImplementedException();
        }
    }
}