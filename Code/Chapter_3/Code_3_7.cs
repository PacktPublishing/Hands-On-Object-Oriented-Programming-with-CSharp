public static Tuple<string, int, string> GetPerson() {
    var person = new Tuple<string, int, string>("Martin Dew", 42, "Software Developer");
    return person;
}
static void Main() {
    var developer = GetPerson();
    Console.WriteLine("The person is {0}. He is {1} years old. He is a {2}", developer.Item1, developer.Item2, developer.Item3 );
}