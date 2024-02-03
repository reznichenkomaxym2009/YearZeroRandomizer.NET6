using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearZeroRandomizer.NET6
{
    public class SetOfDices
    {
        public List<Dice> Dices { get; private set; }
        public int TypeOfDices { get; private set; }
        public int NumberOf_1 { get => FindNumberOf_Value(1); }
        public int NumberOf_6 { get => FindNumberOf_Value(6); }

        public SetOfDices(int typeOfDices, int numberOfDices)
        {
            if (typeOfDices < 0) typeOfDices = 2;
            if (numberOfDices < 0) numberOfDices = 0;

            Dices = new();

            TypeOfDices = typeOfDices;

            for (int i = 0; i < numberOfDices; i++)
            {
                Dices.Add(new(typeOfDices));
            }
        }

        public void RollAllDices()
        {
            for (int i = 0; i < Dices.Count; i++)
            {
                Dices[i].Roll();
            }
        }

        public void Push(bool and_1_too)
        {
            for (int i = 0; i < Dices.Count; i++)
            {
                if (and_1_too)
                {
                    if (Dices[i].Value != 6) Dices[i].Roll();
                }
                else
                {
                    if (Dices[i].Value != 1 && Dices[i].Value != 6) Dices[i].Roll();
                }
            }
        }

        public void ChangeNumberOfDices(int number)
        {
            Dices = new();

            for (int i = 0; i < number; i++)
            {
                Dices.Add(new(TypeOfDices));
            }
        }

        public void Clear()
        {
            Dices = new();
        }

        private int FindNumberOf_Value(int value)
        {
            int summ = 0;

            for (int i = 0; i < Dices.Count; i++)
            {
                if (Dices[i].Value == value) summ++;
            }

            return summ;
        }
    }
}
