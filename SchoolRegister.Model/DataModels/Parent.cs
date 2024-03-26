using SchoolRegister.Model.DataModels;

public class Parent : User
{
    public virtual IList<Student> Students
    {
        get;
        set;
    }

    public Parent() : base()
    {
        Students = new List<Student>();
    }
}