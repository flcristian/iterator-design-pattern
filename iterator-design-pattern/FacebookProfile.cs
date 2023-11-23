namespace iterator_design_pattern;

public class FacebookProfile
{
    private int _id;
    private string _email;

    public FacebookProfile(int id, string email)
    {
        _id = id;
        _email = email;
    }

    public override string ToString()
    {
        String desc = "";
        desc += $"Id : {_id}\n";
        desc += $"Email : {_email}\n";
        return desc;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }
}