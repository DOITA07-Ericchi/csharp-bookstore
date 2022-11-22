string titolo = "Strawberry Panic: The Complete Novel Collection";
string autore = "Sakurako Kimino";
string isbn = "978-1934876992";
ushort pagine = 470;
float peso = 0.413f;
float altezza = 12.88f;
float larghezza = 4.36f;
float profondita = 18.24f;
float valutazione = 4.4f;
ulong recensioni = 44;
bool kindle = false;
bool copFlessibile = true;
string url = "https://www.amazon.it/Strawberry-Panic-Complete-Novel-Collection/dp/1934876992/";

Console.WriteLine("〜 Il libro di oggi 〜\n");
Console.WriteLine($"Titolo: {titolo}");
Console.WriteLine($"Autore: {autore}");
Console.WriteLine($"ISBN: {isbn}");
Console.WriteLine($"Numero di pagine: {pagine}");
Console.WriteLine($"Peso: {peso} kg");
Console.WriteLine($"Dimensioni: {altezza} x {larghezza} x {profondita}");
Console.WriteLine($"Valutazione media: {valutazione}/5 stelle");
Console.WriteLine($"Numero di recensioni: {recensioni}");
if (kindle == true) {
    Console.WriteLine("Kindle disponibile: Sì");
} else
{
    Console.WriteLine("Kindle disponibile: No");
}
if (copFlessibile == true)
{
    Console.WriteLine("Copertina flessibile: Sì");
}
else
{
    Console.WriteLine("Copertina flessibile: No");
}
Console.WriteLine($"\n{url}");
Console.WriteLine("〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜\n");


Console.Write("Premi Invio per uscire.");
Console.ReadLine();