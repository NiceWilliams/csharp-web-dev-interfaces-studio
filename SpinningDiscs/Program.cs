using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD blueCd = new CD("BlueCD");
            //DVD crackedDvd = new DVD("CrackedDvd", 570, 1600, "MPEG-2", 29);

            //crackedDvd.SpinDisc();
            //blueCd.SpinDisc();

            //crackedDvd.Info();
            blueCd.MemorySpace(735);

            //crackedDvd.MemorySpace(35);
            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
