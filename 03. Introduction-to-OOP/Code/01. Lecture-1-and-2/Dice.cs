using System;

namespace Demo
{
    // наследява System.Object -> следователно е reference type
    public class Dice 
    {
        // полета(fields)
        private int sides;
        private string type;
        
        public int Roll()
        {
            Random random = new Random();
            // избира число от 1 до sides + 1. Ако имам side = 6 ще ми избере число от [1,7)
            int rollResult = random.Next(1, this.sides + 1);
            return rollResult;
        }

        public override string ToString()
        {
            // return base.ToString(); // ще ми върне на System.Object.ToString() 
            return this.ToString(); // ще ми върне на Dice.ToString()
        }
    }  
}