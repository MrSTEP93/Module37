using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Repositories
{
    public class PressureRepositoryRandom : IPressureRepository
    {
        public int GetPressure()
        {
            var randomValue = new Random();
            return 700 + randomValue.Next(60);
        }
    }
}
