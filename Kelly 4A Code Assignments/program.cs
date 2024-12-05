using System;
class Template{
    static void Main() {

    int age = 56;
    Player codeMonkeyPlayer = new Player();
    Player ironManPlayer = new Player();

    Console.WriteLine(codeMonkeyPlayer.GetHashCode() + " " + ironManPlayer.GetHashCode());
}

class Player {

    public Player() {
        Console.WriteLine("Creating player!");
    }

   
    } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN

z