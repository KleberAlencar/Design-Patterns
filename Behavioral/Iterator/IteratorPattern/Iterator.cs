using System.Collections;

namespace IteratorPattern;

public abstract class Iterator : IEnumerator
{
    object IEnumerator.Current => Current();
    
    // returns the key of the current element
    public abstract int Key();
    
    // returns the current element
    public abstract object Current();

    // move forward to the next element
    public abstract bool MoveNext();

    // rewinds the Iterator to the first element
    public abstract void Reset();
}