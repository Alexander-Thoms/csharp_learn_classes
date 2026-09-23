// Alexander Thoms
// 9/22/2026

namespace LearnClasses;



class Program
{
    static void Main(string[] args)
    {
        // varibles 
        string fall = "Fall 2026";
        // course codes
        string csharpCourseCode = "CIS 325";
        string aiCourseCode = "CIS 370";
        var javaCourseCode = "CIS 355";
        var projectCourseCode = "CIS 320";
        // course names
        string cSharpName = "C# Programming";
        string aiProgrammingName = "AI programming introduction";
        string javaProgrammingName = "Database connectivity with Java";
        string projectProgrammingName = "IT professional Development";
        // instructors
        string josh = "Josh";
        string james = "James";
        string jeffery = "jeffery";
        Course jeffsCourses = new Course(fall, csharpCourseCode, cSharpName, jeffery);
        Course joshsCourses1 = new Course(fall, aiCourseCode, aiProgrammingName, josh);
        Course joshsCourses2 = new Course(fall, projectCourseCode, projectProgrammingName, josh);
        Course jamesCourses = new Course(fall, javaCourseCode, javaProgrammingName, james);

        List<Course> myCoruses = new List<Course>{jeffsCourses, joshsCourses1, joshsCourses2, jamesCourses};


        // List<string> courses = new List<string> {
        //     "instructors: \n",
        //     jeffsCourses.getInstructor,
        //     joshsCourses1.getInstructor,
        //     joshsCourses2.getInstructor,
        //     jamesCourses.getInstructor,
        //     "course codes: \n",
        //     jeffsCourses.getCourseCode,
        //     joshsCourses1.getCourseCode,
        //     joshsCourses2.getCourseCode,
        //     jamesCourses.getCourseCode,
        //     "Program Names: \n",
        //     jeffsCourses.getProgramName,
        //     joshsCourses1.getProgramName,
        //     joshsCourses2.getProgramName,
        //     jamesCourses.getProgramName
        //     };

        foreach (Course c in myCoruses)
        {
            
            System.Console.WriteLine(c.getCourseCode);
            System.Console.WriteLine(c.getInstructor);
            System.Console.WriteLine(c.getProgramName);
        }


    }
}
