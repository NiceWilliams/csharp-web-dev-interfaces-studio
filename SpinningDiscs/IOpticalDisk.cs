using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    internal interface IOpticalDisk
    {
        void SpinDisc();
        void Info();

        void MemorySpace(int number);
    }
}
