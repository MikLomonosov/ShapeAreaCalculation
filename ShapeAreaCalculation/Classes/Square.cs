using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    /// <summary>
    /// unwantable class, the class we test in last way.
    /// </summary>
    public class Square : Shape
    {
        #region fields

        private double  _side;

        #endregion

        #region properties

        public double Side
        {
            get => _side;
            set => _side = value;
        }

        #endregion
    }
}
