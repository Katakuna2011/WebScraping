using WebScraper.Driver;

Console.Write("Digite a porcentagem alvo: ");
int alvo = int.Parse(Console.ReadLine());

Console.Write("Digite o destino da mensagem (conforme salvo no WhatsApp): ");
string destino = Console.ReadLine();

var web = new WebScraperBlaze();
web.GetData("https://blaze.com/pt/games/crash", alvo, destino);
