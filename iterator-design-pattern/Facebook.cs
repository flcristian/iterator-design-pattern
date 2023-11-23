namespace iterator_design_pattern;

public class Facebook : SocialNetwork
{
    private List<FacebookProfile> _profiles;

    public Facebook()
    {
        _profiles = new List<FacebookProfile>
        {
            new (1, "profile1@email.com"),
            new (2, "profile2@email.com"),
            new (3, "profile3@email.com"),
            new (4, "profile4@email.com"),
            new (5, "profile5@email.com")
        };
    }
    
    public ProfileIterator CreateIterator()
    {
        return new FacebookIterator(_profiles);
    }
}