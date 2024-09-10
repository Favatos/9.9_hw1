namespace _9._9_hw;

internal class Program
{
    static void Main(string[] args)
    {
        IMovie movie = new IsHuman(new AcceptCookie(new CreateAccount(new AddBanner(new Movie()))));
        movie.Play();
        Console.ReadLine();
    }
}