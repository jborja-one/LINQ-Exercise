namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videGames = new List<string>
            {
            "The Legend of Zelda",
            "Super Mario Odyssey",
            "Minecraft",
            "Animal Crossing",
            "Dark Souls",
            "Halo",
            "Stardew Valley",
            "Final Fantasy XV",
            "Overwatch",
            "World of Warcraft"
            };

            var orderedGames = videGames.OrderBy(game => game.Length).ToList();

            Console.WriteLine("List of Video Games ordered by length");

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
