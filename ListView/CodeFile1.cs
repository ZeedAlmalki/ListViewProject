using static ListView.Form1;

public struct stItem
{
    public string ID;
    public string Name;
    public string DOB;
    public string JobTitle;
    public string Gmail;
    public double salary;
    public enGenderImage genderImage;
}

public enum enGenderImage
{
    Male = 0,
    Female =1
}
