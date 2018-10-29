public class Programmer {
    public string Name { get; set; }
    public string Age { get; set; }
    public List<ProgrammingLanguages> ProgrammingLanguages { get; set; }
    public ProgrammerType Type { get; set; } // Backend/Frontend/Full Stack/Web/Mobbile etc

    public bool WorkOnAProject(Project project, Computer computer){
        // use the provided computer to do the project
        // here we can see that the programmer is using a computer
    }
}

public class Computer {
    public int Id { get; set; }
    public string ModelNumber { get; set; }
    public Company Manufacturer { get; set; }
    public Ram Ram { get; set; }
    public MotherBoard MotherBoard { get; set; }
    public CPU CPU { get; set; }
}