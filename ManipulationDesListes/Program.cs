namespace ManipulationDesListes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the StrawHats Crew!");

            List<string> onePieceCharacters = new List<string>();
            onePieceCharacters.Add("Luffy");
            onePieceCharacters.Add("Zorro");
            onePieceCharacters.Add("Sanji");
            onePieceCharacters.Add("Nami");

            onePieceCharacters.Insert(0, "Jinbei");
            onePieceCharacters.Insert(3,"Brook");
            onePieceCharacters.Remove("Nami");
            onePieceCharacters.RemoveAt(1);

            foreach (string onePieceCharacter in onePieceCharacters) 
            { Console.WriteLine(onePieceCharacter); }
        }
     

        
    }
}
