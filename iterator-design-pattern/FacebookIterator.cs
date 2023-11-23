namespace iterator_design_pattern;

public class FacebookIterator : ProfileIterator
{
    private List<FacebookProfile> _profiles;
    private int _position;

    public FacebookIterator(List<FacebookProfile> profiles)
    {
        _profiles = profiles;
        _position = 0;
    }
    
    public FacebookProfile GetNext()
    {
        if (HasNext())
        {
            FacebookProfile result = _profiles[_position];
            _position++;
            return result;
        }

        return null!;
    }

    public bool HasNext()
    {
        return _position < _profiles.Count;
    }
}