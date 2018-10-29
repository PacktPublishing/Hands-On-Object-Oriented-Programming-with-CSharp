public class Programmer : Human {
    // Name, Age properties can be inherited from Human
    public List<ProgrammingLanguages> ProgrammingLanguages { get; set; }
    public ProgrammerType Type { get; set; } // Backend/Frontend/Full Stack/Web/Mobbile etc

    public bool WorkOnAProject(Project project, Computer computer){
        // use the provided computer to do the project
        // here we can see that the programmer is using a computer
    }
}