using System.Collections;

namespace IteratorPattern;

public abstract class IteratorAggregate : IEnumerable
{
    // returns an Iterator or another IteratorAggregate for the implementing object
    public abstract IEnumerator GetEnumerator();
}