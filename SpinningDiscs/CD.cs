using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc
    {
        public CD(string name) : base(name)
        {
            Name = name;
            MinSpinRate = 200;
            MaxSpinRate = 500;
            StorageCapacity = 734;
        }

        // TODO: Implement your custom interface.


        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 


        //public CD(string name) : base(name);

        public void SpinDisc()
        {
            Console.WriteLine($"A {Name} spins at a rate of {MinSpinRate} - {MaxSpinRate} rpm.");
        }

        public void Info()
        {
            Console.WriteLine($"{Name} is {Format} format.");
        }

        public void MemorySpace(int checkCapacity)
        {

            if (StorageCapacity < checkCapacity)
            {
                Console.WriteLine("Invalid storage");
            }
            else
            {
                Console.WriteLine($"{Name} is {checkCapacity}MB.");
            }
        }

        //public override string ToString()
        //{
        //    return $"{Name} is {StorageCapacity}MB.";
        //}
    }
}
