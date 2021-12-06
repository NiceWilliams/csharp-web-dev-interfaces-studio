using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc
    {
        // TODO: Implement your custom interface

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int minSpinRate, int maxSpinRate, string format, int storageCapacity) : base(name)
        {
        }

        public void SpinDisc()
        {
            Console.WriteLine(ToString());
        }

        public void Info()
        {
            Console.WriteLine($"{Name} is {Format} format.");
        }

        //public DVD(string name, int storageCapacity) : base(name, storageCapacity) { }
        public void MemorySpace(int storageCapacity)
        {
            
            if(storageCapacity > 100)
            {
                Console.WriteLine("Invalid storage");
            }
            else if (storageCapacity <= 100)
            {
                Console.WriteLine(ToString());
            }
        }

        public override string ToString()
        {
            return $"{Name} has {StorageCapacity}MB of memory.";
        }
    }
}
