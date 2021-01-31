using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Models.Food;

namespace Zoo.Interfaces
{
    public interface IEatable
    {
        void Eat(IFood food);
    }
}
