using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDExam
{
    public class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; 
        private int nextIndex = 0; 

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {

            int SumFirst = 0;
            int SumLast = 0;

            for (int i = startIndex; i < nextIndex; i++)
            {
                SumFirst += items[i].First;
                SumLast += items[i].Last;
            }
            Pair Sum = new Pair(SumFirst, SumLast);
            return Sum;
        }

        public Pair Sum()
        {

            int SumFirst = 0;
            int SumLast = 0;
            for (int i = 0; i < this.Count; i++)
            {
                SumFirst += items[i].First;
                SumLast += items[i].Last;
            }
            Pair Sum = new Pair(SumFirst, SumLast);
            return Sum;
        }

        public void Add(Pair item)
        { 
            if(nextIndex == items.Length)
            {
                items[startIndex] = SumIntervalPairs();
                startIndex++;
                nextIndex = startIndex;
                Count++;
            }
            items[nextIndex] = item;
            nextIndex++;
           //Идея какво се случва тука - НИКАКВА!  
           //Защо не може да проверявам count == capacity
           //Защото caount брои компресираните двойки
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

    }
}