var myObject = new Derived();

class Base
{
    public Base()
    {
        _ = new Tracker("Base.Instance.Constructor");
        this.Virtual();
    }
    static Base()
    {
        _ = new Tracker("Base.Static.Constructor");
    }
    private Tracker m_Field = new("Base.Instance.Field");
    static private Tracker s_Field = new("Base.Static.Field");
    virtual public void Virtual()
    {
        _ = new Tracker("Base.Instance.Virtual");
    }
}

class Derived : Base
{
    public Derived()
    {
        _ = new Tracker("Derived.Instance.Constructor");
    }
    static Derived()
    {
        _ = new Tracker("Derived.Static.Constructor");
    }
    private Tracker m_Field = new("Derived.Instance.Field");
    static private Tracker s_Field = new("Derived.Static.Field");
    override public void Virtual()
    {
        _ = new Tracker("Derived.Instance.Virtual");
    }
}
class Tracker
{
    public Tracker(string text)
    {
        Console.WriteLine(text);
    }
}