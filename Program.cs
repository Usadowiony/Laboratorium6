using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CWzLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Film> filmy = Film.GenerujFilmy();

            // Znajdź wszystkie filmy wydane po roku 2000.
            var filmyPo2000 = filmy.Where(f => f.RokWydania > 2000);
            Console.WriteLine("Filmy wydane po roku 2000:");
            Film.WyswietlWyniki(filmyPo2000);

            Console.WriteLine();

            // Znajdź wszystkie filmy z gatunku "Dramat".
            var filmyDramatyczne = filmy.Where(f => f.Gatunek == "Dramat");
            Console.WriteLine("Filmy z gatunku 'Dramat':");
            Film.WyswietlWyniki(filmyDramatyczne);

            Console.WriteLine();

            // Znajdź średnią ocenę wszystkich filmów.
            var sredniaOcena = filmy.Average(f => f.Ocena);
            Console.WriteLine($"Średnia ocena wszystkich filmów: {sredniaOcena}");

            Console.WriteLine();

            // Znajdź 3 najlepiej ocenione filmy.
            var najlepszeFilmy = filmy.OrderByDescending(f => f.Ocena).Take(3);
            Console.WriteLine("Najlepiej ocenione filmy:");
            Film.WyswietlWyniki(najlepszeFilmy);

            Console.WriteLine();

            // Posortuj filmy według roku wydania.
            var posortowaneFilmy = filmy.OrderBy(f => f.RokWydania);
            Console.WriteLine("Filmy posortowane według roku wydania:");
            Film.WyswietlWyniki(posortowaneFilmy);

            Console.WriteLine();

            // Znajdź najstarszy film w bazie.
            var najstarszyFilm = filmy.OrderBy(f => f.RokWydania).First();
            Console.WriteLine($"Najstarszy film w bazie: {najstarszyFilm.Tytul}, Rok wydania: {najstarszyFilm.RokWydania}");

            // Znajdź najnowszy film w bazie.
            var najnowszyFilm = filmy.OrderByDescending(f => f.RokWydania).First();
            Console.WriteLine($"Najnowszy film w bazie: {najnowszyFilm.Tytul}, Rok wydania: {najnowszyFilm.RokWydania}");

            Console.WriteLine();

            // Znajdź wszystkie unikalne gatunki filmowe obecne w bazie.
            var unikalneGatunki = filmy.Select(f => f.Gatunek).Distinct();
            Console.WriteLine("Unikalne gatunki filmowe:");
            foreach (var gatunek in unikalneGatunki)
            {
                Console.WriteLine(gatunek);
            }

            Thread.Sleep(30000); // Dodany wątek oczekiwania na zakończenie, aby program nie zamykał się natychmiastowo
        }
    }

    public class Film
    {
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public double Ocena { get; set; }

        public Film(string tytul, int rokWydania, string gatunek, double ocena)
        {
            Tytul = tytul;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            Ocena = ocena;
        }

        public static List<Film> GenerujFilmy()
        {
            List<Film> filmy = new List<Film>
            {
                new Film("The Shawshank Redemption", 1994, "Dramat", 9.3),
        new Film("The Godfather", 1972, "Dramat", 9.2),
        new Film("The Dark Knight", 2008, "Akcja", 9.0),
        new Film("Schindler's List", 1993, "Biograficzny", 8.9),
        new Film("The Lord of the Rings: The Return of the King", 2003, "Fantasy", 8.9),
        new Film("Pulp Fiction", 1994, "Kryminał", 8.9),
        new Film("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy", 8.8),
        new Film("Forrest Gump", 1994, "Dramat", 8.8),
        new Film("Fight Club", 1999, "Dramat", 8.8),
        new Film("Inception", 2010, "Sci-Fi", 8.7),
        new Film("The Lord of the Rings: The Two Towers", 2002, "Fantasy", 8.7),
        new Film("Star Wars: Episode V - The Empire Strikes Back", 1980, "Sci-Fi", 8.7),
        new Film("The Matrix", 1999, "Sci-Fi", 8.7),
        new Film("Goodfellas", 1990, "Biograficzny", 8.7),
        new Film("One Flew Over the Cuckoo's Nest", 1975, "Dramat", 8.7),
        new Film("Se7en", 1995, "Kryminał", 8.6),
        new Film("The Silence of the Lambs", 1991, "Kryminał", 8.6),
        new Film("City of God", 2002, "Dramat", 8.6),
        new Film("The Green Mile", 1999, "Dramat", 8.6),
        new Film("The Usual Suspects", 1995, "Kryminał", 8.5),
        new Film("Léon: The Professional", 1994, "Akcja", 8.5),
        new Film("Saving Private Ryan", 1998, "Wojenny", 8.5),
        new Film("Interstellar", 2014, "Sci-Fi", 8.5),
        new Film("The Pianist", 2002, "Biograficzny", 8.5),
        new Film("Gladiator", 2000, "Akcja", 8.5),
        new Film("American History X", 1998, "Dramat", 8.5),
        new Film("The Departed", 2006, "Kryminał", 8.5),
        new Film("Whiplash", 2014, "Dramat", 8.5),
        new Film("The Lion King", 1994, "Animacja", 8.5),
        new Film("The Prestige", 2006, "Mystery", 8.5),
        new Film("The Intouchables", 2011, "Biograficzny", 8.5),
        new Film("The Godfather: Part II", 1974, "Dramat", 8.5),
        new Film("The Sixth Sense", 1999, "Thriller", 8.5),
        new Film("The Departed", 2006, "Kryminał", 8.5),
        new Film("The Shining", 1980, "Horror", 8.4),
        new Film("The Truman Show", 1998, "Dramat", 8.4),
        new Film("The Dark Knight Rises", 2012, "Akcja", 8.4),
        new Film("The Lives of Others", 2006, "Dramat", 8.4),
        new Film("The Help", 2011, "Dramat", 8.4),
        new Film("The Terminator", 1984, "Sci-Fi", 8.4),
        new Film("The Matrix", 1999, "Sci-Fi", 8.4),
        new Film("The Silence of the Lambs", 1991, "Kryminał", 8.4)
            };

            return filmy;
        }

        public static void WyswietlWyniki(IEnumerable<Film> wyniki)
        {
            foreach (var film in wyniki)
            {
                Console.WriteLine($"Tytuł: {film.Tytul}, Rok wydania: {film.RokWydania}, Gatunek: {film.Gatunek}, Ocena: {film.Ocena}");
            }
        }
    }
}
