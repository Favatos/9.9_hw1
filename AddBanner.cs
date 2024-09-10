namespace _9._9_hw;

public class AddBanner : BaseProxy
{
    public AddBanner(IMovie? next) : base(next) { }

    public override string Text => "Закрыть рекламный баннер?";
}