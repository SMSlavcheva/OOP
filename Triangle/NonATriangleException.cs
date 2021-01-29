using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class NonATriangleException : Exception
    {
        public NonATriangleException()
        {
        }
        public NonATriangleException(string message)
            : base(message)
        {
        }

        public override string Message
        {
            get
            {
                return "Not a valid trinagle. Enter valid triangle datas";
            }
        }
    }
}
