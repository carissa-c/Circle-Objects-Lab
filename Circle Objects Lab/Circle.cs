using System;
namespace Circle_Objects_Lab
{
	public class Circle
	{
		//properties
		public double Radius { get; set; }

        //constructor
        //a.
        public Circle(double _radius)
		{
            Radius = _radius;
		}

        //methods
        //b.
        public double CalculateCircumference()
        {
            double circleCircumference = 2 * Radius * Math.PI;
            return circleCircumference;
            //1 line: return 2 * Math.PI * Radius;
        }
        //c.
        public string CalculateFormattedCircumference()
        {
            return $"Circumference: {FormatNumber(CalculateCircumference())}";
            //return FormatNumber(CalculateCircumference());
        }
        //d.
        public double CalculateArea()
        {
            double calculatedArea = Math.PI * (Radius * Radius);
            return calculatedArea;
            //return Math.Pi * Math.Pow(Radius,2)
        }
        //e.
        public string CalculateFormattedArea()
        {
           return $"Area: {FormatNumber(CalculateArea())}";
        }
        //f.
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }
    }

}

