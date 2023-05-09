using WebScraper.Driver;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a porcentagem alvo: ");
        int alvo = int.Parse(Console.ReadLine());

        Console.Write("Digite o destino da mensagem (conforme salvo no WhatsApp): ");
        string destino = Console.ReadLine();D
        var web = new WebScraperBlaze();
        web.GetData("https://blaze.com/pt/games/crash", alvo, destino);
        
    }
}

