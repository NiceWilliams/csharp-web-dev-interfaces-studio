using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc : IOpticalDisk
    {
        
        public string Name { get; set; }
        public int MinSpinRate { get; set; }
        public int MaxSpinRate { get; set; }

        public int StorageCapacity { get; set; }
        public string Format { get; set; }

        protected BaseDisc(string name)
        {
            Name = name;
        }

        //public BaseDisc(string name, int storageCapacity)
        //{
        //    Name = name;
        //    StorageCapacity = storageCapacity;
        //}

        public override string ToString()
        {
            return $"A {Name} spins at a rate of {MinSpinRate} - {MaxSpinRate} rpm.";
        }

        public void SpinDisc()
        {

        }

        public void Info() { }

        public void MemorySpace(int number) { }
    }
}
