namespace LearnClasses;
class Course
{
    
    private string season = "";
    private string courseCode = "";
    private string programName = "";
    private string instructors = "";

    public  Course(string seasonParam, string courseCodeParam, string programNameParan, string instructorsParan)
    {
        season = seasonParam;
        courseCode = courseCodeParam;
        programName = programNameParan;
        instructors = instructorsParan;
    }
    public string GetFall
    {
        get { return season; }
    }
    public string getProgramName
    {
        get{ return programName;}
    }
    public string getInstructor
    {
        get{return instructors;}
    }
    public string getCourseCode
    {
        get{return courseCode;}
    }

}