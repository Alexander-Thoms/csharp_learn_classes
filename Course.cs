namespace LearnClasses;

class Course
{
    //Fields
    private string _season = "";
    private string _courseCode = "";
    private string _programName = "";
    private string _instructors = "";

    // Constructors
    public Course(string seasonParam, string courseCodeParam, string programNameParan, string instructorsParan)
    {
        _season = seasonParam;
        _courseCode = courseCodeParam;
        _programName = programNameParan;
        _instructors = instructorsParan;
    }

    // Properties
    public string GetFall
    {
        get { return _season; }
        set { _season = value; }
    }
    public string getProgramName
    {
        get { return _programName; }
    }
    public string getInstructor
    {
        get { return _instructors; }
    }
    public string getCourseCode
    {
        get { return _courseCode; }
    }

}