namespace _9._9_hw;

public class IsHuman : BaseProxy
{
    public IsHuman(IMovie? next) : base(next) { }

    public override string Text => "Вы человек?";
}
