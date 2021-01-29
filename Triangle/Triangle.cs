using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
   public class Triangle
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;

        }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

       
        public double CalculatePerimeter(double sideA, double sideB, double sideC)
        {

            return sideA + sideB + sideC;
        
        }

        public double CalculateSurface(double SideA, double SideB,double SideC)
        {

            double p = 0;
            double s = 0;
            p = (SideA + SideB + SideC) / 2; 
            s = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return s;
        }

        }

    }

