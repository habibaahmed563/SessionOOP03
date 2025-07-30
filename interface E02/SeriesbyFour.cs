using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03.interface_E02
{
    internal class SeriesbyFour : Iseries
    {
        public int current { get; set; }

        public void Next()
        {
            current += 4;
        }

    }
}
