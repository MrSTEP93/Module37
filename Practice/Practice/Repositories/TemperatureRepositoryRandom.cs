using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Repositories
{
    public class TemperatureRepositoryRandom : ITemperatureRepository
    {
        public int GetInT()
        {
            var randomValue = new Random();
            return 15 + randomValue.Next(20);
        }

        public int GetOutT()
        {
            var randomValue = new Random();
            return -35 + randomValue.Next(60);
        }
    }
}
