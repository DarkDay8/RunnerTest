using System;

public class ViewPath : System.Attribute
{
    private readonly string _value;

    public ViewPath(string value)
    {
        _value = value;
    }

    public string Value
    {
        get { return _value; }
    }

}
//need path to correct instance
public enum ViewesEnum : byte
{
    [ViewPath("Prefabs/View/Menu")] 
    Menu,
    [ViewPath("Prefabs/View/Game")]
    Game
}

//need path to correct instance
public enum SectionEnum : byte
{
    [ViewPath("Prefabs/Game/Sections/Section")]
    Section,
    [ViewPath("Prefabs/Game/Sections/Section1")]
    Section1,
    [ViewPath("Prefabs/Game/Sections/Section2")]
    Section2,
}