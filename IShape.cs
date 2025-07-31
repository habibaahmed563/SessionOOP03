using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal interface IShape
    {
        public double Area { get; set; }

        void DisplayShapeinfo();
    }
}
