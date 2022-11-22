Console.WriteLine("〜 Generatore di libri del giorno 〜\n");

Console.Write("Inserisci il titolo: ");
string titolo = Console.ReadLine();

Console.Write("Inserisci l'autore: ");
string autore = Console.ReadLine();

Console.Write("Inserisci l'ISBN: ");
string isbn = Console.ReadLine();

Console.Write("Inserisci il numero di pagine: ");
ushort pagine = ushort.Parse(Console.ReadLine());

Console.Write("Inserisci il peso del libro in kg: ");
float peso = ushort.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del libro: ");
float altezza = float.Parse(Console.ReadLine());

Console.Write("Inserisci la larghezza del libro: ");
float larghezza = float.Parse(Console.ReadLine());

Console.Write("Inserisci la profondità del libro: ");
float profondita = float.Parse(Console.ReadLine());

Console.Write("Inserisci la valutazione media: ");
float valutazione = float.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di recensioni: ");
float recensioni = float.Parse(Console.ReadLine());

Console.Write("È disponibile in formato Kindle? (s/n): ");
bool valid = false;
bool kindle = false;
do {
    string letter = Console.ReadLine();
    if (letter == "s" || letter == "n") {
        valid = true;
		if (letter == "s") {
			kindle = true;
		}
		else {
			kindle = false;
		}
	} else {
        Console.Write("Non è una scelta valida. Inserisci \"s\" o \"n\": ");
    };
} while (valid == false);

Console.Write("È disponibile in copertina flessibile? (s/n): ");
valid = false;
bool copFlessibile = false;
do {
	string letter = Console.ReadLine();
	if (letter == "s" || letter == "n") {
		valid = true;
		if (letter == "s") {
			copFlessibile = true;
		}
		else {
			copFlessibile = false;
		}
	}
	else {
		Console.Write("Non è una scelta valida. Inserisci \"s\" o \"n\": ");
	};
} while (valid == false);
Console.Write("Inserisci l'URL del libro: ");
string url = Console.ReadLine();

// Printout
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
}
else {
    Console.WriteLine("Kindle disponibile: No");
}
if (copFlessibile == true) {
    Console.WriteLine("Copertina flessibile: Sì");
}
else {
    Console.WriteLine("Copertina flessibile: No");
}
Console.WriteLine($"\n{url}");
Console.WriteLine("〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜 〜\n");


Console.Write("Premi Invio per uscire.");
Console.ReadLine();