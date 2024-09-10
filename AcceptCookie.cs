namespace _9._9_hw;

public class AcceptCookie : BaseProxy
{
    public AcceptCookie(IMovie? next) : base(next) { }

    public override string Text => "Принимаете куки?";
}

