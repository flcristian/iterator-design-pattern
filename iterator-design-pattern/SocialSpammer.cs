namespace iterator_design_pattern;

public class SocialSpammer
{
    public void SendEmail(ProfileIterator iterator, string message)
    {
        while (iterator.HasNext())
        {
            Console.WriteLine($"Sent email to {iterator.GetNext().Email} with message {message}");
        }
    }
}