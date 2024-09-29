using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Repositories
{
    public interface ITemperatureRepository
    {
        int GetOutT();

        int GetInT();
    }
}
