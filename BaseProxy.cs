namespace _9._9_hw;

public abstract class BaseProxy:IMovie
{
    protected readonly IMovie? next;
    public abstract string Text { get; }
    public BaseProxy(IMovie? next)
    {
        this.next = next;
    }

    public virtual void Play()
    {
        Console.WriteLine(Text + "\n1 - да, 0 - нет");
        bool check = Convert.ToBoolean(Int32.TryParse(Console.ReadLine(), out int l));
        Console.WriteLine(check);
        if (check)
        {
            next?.Play();
        }
        else { Console.WriteLine("Нельзя!"); }
    }
}
