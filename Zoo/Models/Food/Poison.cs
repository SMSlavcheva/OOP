using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Models.Food
{
    public class Poison : Food
    {
        public  const string DefaultName= "poison";
        public Poison() : base(DefaultName)
        {
           
        }
    }
}
