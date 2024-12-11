using System;
class Template{
    private static void Main() {

    Player codeMonkeyPlayer = new Player("Code Monkey");
    codeMonkeyPlayer.SayHello();
    Player ironManPlayer = new Player("Iron Man");
    ironManPlayer.SayHello();

    Console.WriteLine(codeMonkeyPlayer.GetHashCode() + " " + ironManPlayer.GetHashCode());
}

private class Player {

    public string name = "-";

    public Player(string name) {
        this.name = name;
        Console.WriteLine($"Creating player {name}!");
    }
    
    public static void SayHello(){
        Console.WriteLine($"Hello {name}!");
    }

   
    } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN

