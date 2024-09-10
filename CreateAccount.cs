namespace _9._9_hw;

public class CreateAccount : BaseProxy
{
    public CreateAccount(IMovie? next): base(next) {  }

    public override string Text => "Создадите бесплатный аккаунт без SMS?";
}
