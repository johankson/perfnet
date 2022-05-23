using System;
using System.Collections.Generic;
using System.Linq;
// ReSharper disable All

namespace Examples
{
    public class Collections
    {
        public List<Duck> Ducks = new();
        public List<Junk> Junkz = new();

        #region Duck Factories

        public void Generate(int count, bool largeDucks, bool withJunk)
        {
            switch (largeDucks, withJunk)
            {
                case (false, false):
                    GenerateDucks_InLineInMemory(count);
                    break;
                case (true, false):
                    GenerateLargeDucks_InLineInMemory(count);
                    break;
                case (false, true):
                    GenerateDucks_EmbeddedInJunkObjects(count);
                    break;
                case (true, true):
                    GenerateLargeDucks_EmbeddedInJunkObjects(count);
                    break;
            }
        }
        
        /// <summary>
        /// We have a special method to generate ze Ducks.
        /// </summary>
        public void GenerateDucks_InLineInMemory(int count)
        {
            Ducks.Clear();
            
            for(var i=0;i<count;i++)
            {
                Ducks.Add(new Duck());
            }
        }

        public void GenerateDucks_EmbeddedInJunkObjects(int count)
        {
            var random = new Random(1337); // Use the same seed to ensure that each benchmark is comparable
            Ducks.Clear();
            
            for(var i=0;i<count;i++)
            {
                Ducks.Add(new Duck());
                var junkNumber = random.NextInt64(0, 50);
                for (var j = 0; j < junkNumber; j++)
                {
                    Junkz.Add(new Junk());
                }
            }
        }
        
        public void GenerateLargeDucks_InLineInMemory(int count)
        {
            Ducks.Clear();
            for(var i=0;i<count;i++)
            {
                Ducks.Add(new LargeDuck());
            }
        }
        
        public void GenerateLargeDucks_EmbeddedInJunkObjects(int count)
        {
            var random = new Random(1337);
            Ducks.Clear();
            
            for(var i=0;i<count;i++)
            {
                Ducks.Add(new LargeDuck());
                var junkNumber = random.NextInt64(0, 50);
                for (var j = 0; j < junkNumber; j++)
                {
                    Junkz.Add(new Junk());
                }
            }
        }
        
        #endregion

  
        public int Sum_ForEach_Ducks()
        {
            int sum = 0;
            foreach (var duck in Ducks)
            {
                sum += duck.Age;
            }

            return sum;
        }

        public int Sum_For_Ducks()
        {
            var sum = 0;
            
            for (var index = 0; index < Ducks.Count; index++)
            {
                var duck = Ducks[index];
                sum += duck.Age;
            }
            
            return sum;
        }

        public int Sum_ForEach_Ducks_As_IEnumerable()
        {
            var sum = 0;
            
            var enumerable = Ducks as IEnumerable<Duck>;
            foreach (var duck in enumerable)
            {
                sum += duck.Age;
            }

            return sum;
        }
    }
}