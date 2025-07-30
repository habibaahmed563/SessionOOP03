using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interface_E02
{
    internal class SeriesByTwo : Iseries
    {
        public int current { get ; set; } // 0

        public void Next()
        {
            current +=2;
        }

    }
}
