using System;

namespace Prototype
{
    public class Person
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return this.MemberwiseClone() as Person;
        }

        public Person DeepCopy()
        {
            Person clone = this.MemberwiseClone() as Person;
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(this.Name);
            return clone;
        }
    }
}
