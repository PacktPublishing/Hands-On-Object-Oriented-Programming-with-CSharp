public class Computer {
    public int Id { get; set; }
    public string ModelNumber { get; set; }
    public Company Manufacturer { get; set; }
    public Ram Ram { get; set; }
    public MotherBoard MotherBoard { get; set; }
    public CPU CPU { get; set; }
}

public class Ram {
    // Ram properties and methods
}

public class CPU {
    // CPU properties and methods
}

public class MotherBoard {
    // MotherBoard properties and methods
}