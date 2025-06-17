namespace CommandPattern._02_Approach;

public interface ICommand
{
    void Execute();
    void Undo();
}