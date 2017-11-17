using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    /// <summary>
    /// Simple Addition Class
    /// </summary>
    public class Addition
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a">Firtst value</param>
        /// <param name="b">Second value</param>
        public Addition(double a, double b)
        {
            this.val1 = a;
            this.val2 = b;
        }

        /// <summary>
        /// Add the two setted values
        /// </summary>
        /// <returns>Result of sum</returns>
        public double Additionne()
        {
            return val1 + val2;
        }

        /// <summary>
        /// Get the first value
        /// </summary>
        /// <returns>Value</returns>
        public double getVal1()
        {
            return this.val1;
        }

        /// <summary>
        /// Set the first value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }

        /// <summary>
        /// Get the second value
        /// </summary>
        /// <returns>Value</returns>
        public double getVal2()
        {
            return this.val2;
        }

        /// <summary>
        /// Set the second value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }

        public string Affiche()
        {
            return "The sum of " + val1.ToString()
                   + " and " + val2.ToString()
                   + " is " + Additionne().ToString();
        }
    }
}
