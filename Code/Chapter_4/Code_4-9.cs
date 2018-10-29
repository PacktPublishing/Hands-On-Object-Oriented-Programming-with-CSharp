public class Subject {
    public int Id { get; set; }
    public string Name { get; set; }
    public Grade Grade { get; set; }
}

public class Grade {
    public int Id { get; set; }
    public double Mark { get; set; }
    public char GradeSymbol { get; set; } // A, B, C, D, F etc
}