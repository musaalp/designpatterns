using System;

namespace Prototype
{
     /*
     Shallow copies duplicate as little as possible. A shallow copy of a collection is a copy of the collection structure, not the elements. 
     With a shallow copy, two collections now share the individual elements.

     Deep copies duplicate everything. A deep copy of a collection is two collections with all of the elements in the original collection duplicated.
     */
    public interface IAnimal : ICloneable
    {
        string Name { get; set; }
        IAnimal MakeCopy();
    }
}
