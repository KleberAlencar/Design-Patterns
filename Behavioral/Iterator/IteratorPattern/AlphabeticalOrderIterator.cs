namespace IteratorPattern;

public class AlphabeticalOrderIterator : Iterator
{
    private WordsCollection _collection;
    private int _position = -1;
    private bool _reverse = false;

    public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
    {
        this._collection = collection;
        this._reverse = reverse;

        if (reverse)
        {
            this._position = collection.getItems().Count;
        }
    }
    
    public override object Current()
    {
        return this._collection.getItems()[_position];
    }    
    
    public override int Key()
    {
        return this._position;
    }

    public override bool MoveNext()
    {
        int updatePosition = this._position + (this._reverse ? -1 : 1);

        if (updatePosition >= 0 && updatePosition < this._collection.getItems().Count)
        {
            this._position = updatePosition;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void Reset()
    {
        this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
    }
}