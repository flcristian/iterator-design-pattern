using iterator_design_pattern;

internal class Program
{
    public static void Main(string[] args)
    {
        SocialNetwork facebook = new Facebook();
        ProfileIterator iterator = facebook.CreateIterator();
        SocialSpammer spammer = new SocialSpammer();
        spammer.SendEmail(iterator, "Hello world!");
    }
}