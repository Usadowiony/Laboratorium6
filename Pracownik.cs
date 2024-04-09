using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWzLinq
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IloscLatPrzepracowanych { get; set; }
        public int Wiek { get; set; }
        public string StopienNaukowy { get; set; }
        public string Stanowisko { get; set; }
        public decimal WynagrodzenieMiesieczne { get; set; }
        public int IloscUrlopuDoPobrania { get; set; }



        public static void Print(IEnumerable<Pracownik> pracownicy)
        {
            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine($"Imię: {pracownik.Imie}, Nazwisko: {pracownik.Nazwisko}, Ilość lat przepracowanych: {pracownik.IloscLatPrzepracowanych}, Wiek: {pracownik.Wiek}, Stopień naukowy: {pracownik.StopienNaukowy}, Stanowisko: {pracownik.Stanowisko}, Wynagrodzenie miesięczne: {pracownik.WynagrodzenieMiesieczne}, Ilość urlopu do pobrania: {pracownik.IloscUrlopuDoPobrania}");
            }
        }



        public static List<Pracownik> GenerujPracownikow()
        {
            List<Pracownik> pracownicy = new List<Pracownik>()
         {
             new Pracownik { Imie = "Jan", Nazwisko = "Kowalski", IloscLatPrzepracowanych = 5, Wiek = 35, StopienNaukowy = "Magister", Stanowisko = "Analityk", WynagrodzenieMiesieczne = 5000, IloscUrlopuDoPobrania = 20 },
             new Pracownik { Imie = "Anna", Nazwisko = "Nowak", IloscLatPrzepracowanych = 10, Wiek = 45, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Projektu", WynagrodzenieMiesieczne = 8000, IloscUrlopuDoPobrania = 25 },
             new Pracownik { Imie = "Marek", Nazwisko = "Wiśniewski", IloscLatPrzepracowanych = 3, Wiek = 30, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6000, IloscUrlopuDoPobrania = 18 },
             new Pracownik { Imie = "Katarzyna", Nazwisko = "Kowalczyk", IloscLatPrzepracowanych = 8, Wiek = 40, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 7000, IloscUrlopuDoPobrania = 22 },
             new Pracownik { Imie = "Piotr", Nazwisko = "Lewandowski", IloscLatPrzepracowanych = 15, Wiek = 50, StopienNaukowy = "Profesor", Stanowisko = "Dyrektor", WynagrodzenieMiesieczne = 10000, IloscUrlopuDoPobrania = 30 },
             new Pracownik { Imie = "Ewa", Nazwisko = "Zając", IloscLatPrzepracowanych = 7, Wiek = 38, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Projektu", WynagrodzenieMiesieczne = 8500, IloscUrlopuDoPobrania = 24 },
             new Pracownik { Imie = "Tomasz", Nazwisko = "Dąbrowski", IloscLatPrzepracowanych = 12, Wiek = 42, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6200, IloscUrlopuDoPobrania = 21 },
             new Pracownik { Imie = "Karolina", Nazwisko = "Szymańska", IloscLatPrzepracowanych = 6, Wiek = 33, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 7200, IloscUrlopuDoPobrania = 23 },
             new Pracownik { Imie = "Marcin", Nazwisko = "Wójcik", IloscLatPrzepracowanych = 4, Wiek = 28, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4500, IloscUrlopuDoPobrania = 19 },
             new Pracownik { Imie = "Magdalena", Nazwisko = "Kamińska", IloscLatPrzepracowanych = 9, Wiek = 48, StopienNaukowy = "Magister", Stanowisko = "Kierownik Zespołu", WynagrodzenieMiesieczne = 7800, IloscUrlopuDoPobrania = 26 },
             new Pracownik { Imie = "Łukasz", Nazwisko = "Woźniak", IloscLatPrzepracowanych = 11, Wiek = 44, StopienNaukowy = "Doktor", Stanowisko = "Starszy Analityk", WynagrodzenieMiesieczne = 8700, IloscUrlopuDoPobrania = 27 },
             new Pracownik { Imie = "Natalia", Nazwisko = "Kowalczyk", IloscLatPrzepracowanych = 2, Wiek = 26, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4000, IloscUrlopuDoPobrania = 17 },
             new Pracownik { Imie = "Michał", Nazwisko = "Zieliński", IloscLatPrzepracowanych = 16, Wiek = 52, StopienNaukowy = "Profesor", Stanowisko = "Dyrektor Naczelny", WynagrodzenieMiesieczne = 11000, IloscUrlopuDoPobrania = 32 },
             new Pracownik { Imie = "Monika", Nazwisko = "Szymańska", IloscLatPrzepracowanych = 3, Wiek = 31, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 6700, IloscUrlopuDoPobrania = 20 },
             new Pracownik { Imie = "Tomasz", Nazwisko = "Woźniak", IloscLatPrzepracowanych = 7, Wiek = 36, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 5900, IloscUrlopuDoPobrania = 25 },
             new Pracownik { Imie = "Kinga", Nazwisko = "Wójcik", IloscLatPrzepracowanych = 5, Wiek = 34, StopienNaukowy = "Magister", Stanowisko = "Analityk", WynagrodzenieMiesieczne = 5200, IloscUrlopuDoPobrania = 21 },
             new Pracownik { Imie = "Krzysztof", Nazwisko = "Piotrowski", IloscLatPrzepracowanych = 14, Wiek = 49, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Projektu", WynagrodzenieMiesieczne = 9300, IloscUrlopuDoPobrania = 28 },
             new Pracownik { Imie = "Alicja", Nazwisko = "Kowalczyk", IloscLatPrzepracowanych = 6, Wiek = 32, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6400, IloscUrlopuDoPobrania = 22 },
             new Pracownik { Imie = "Mariusz", Nazwisko = "Lewandowski", IloscLatPrzepracowanych = 13, Wiek = 47, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 8200, IloscUrlopuDoPobrania = 27 },
             new Pracownik { Imie = "Agnieszka", Nazwisko = "Nowak", IloscLatPrzepracowanych = 4, Wiek = 29, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4700, IloscUrlopuDoPobrania = 19 },
             new Pracownik { Imie = "Artur", Nazwisko = "Krawczyk", IloscLatPrzepracowanych = 11, Wiek = 46, StopienNaukowy = "Doktor", Stanowisko = "Dyrektor", WynagrodzenieMiesieczne = 9700, IloscUrlopuDoPobrania = 29 },
             new Pracownik { Imie = "Ewelina", Nazwisko = "Mazur", IloscLatPrzepracowanych = 8, Wiek = 41, StopienNaukowy = "Magister", Stanowisko = "Kierownik Zespołu", WynagrodzenieMiesieczne = 7500, IloscUrlopuDoPobrania = 24 },
             new Pracownik { Imie = "Robert", Nazwisko = "Jankowski", IloscLatPrzepracowanych = 2, Wiek = 27, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4300, IloscUrlopuDoPobrania = 18 },
             new Pracownik { Imie = "Aleksandra", Nazwisko = "Wojciechowska", IloscLatPrzepracowanych = 9, Wiek = 43, StopienNaukowy = "Doktor", Stanowisko = "Starszy Analityk", WynagrodzenieMiesieczne = 8900, IloscUrlopuDoPobrania = 28 },
             new Pracownik { Imie = "Mateusz", Nazwisko = "Kaczmarek", IloscLatPrzepracowanych = 14, Wiek = 51, StopienNaukowy = "Profesor", Stanowisko = "Dyrektor Naczelny", WynagrodzenieMiesieczne = 12000, IloscUrlopuDoPobrania = 33 },
             new Pracownik { Imie = "Patrycja", Nazwisko = "Zając", IloscLatPrzepracowanych = 3, Wiek = 30, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 6700, IloscUrlopuDoPobrania = 20 },
             new Pracownik { Imie = "Adam", Nazwisko = "Kowalski", IloscLatPrzepracowanych = 6, Wiek = 34, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6200, IloscUrlopuDoPobrania = 23 },
             new Pracownik { Imie = "Sylwia", Nazwisko = "Dąbrowska", IloscLatPrzepracowanych = 12, Wiek = 48, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Projektu", WynagrodzenieMiesieczne = 9100, IloscUrlopuDoPobrania = 27 },
             new Pracownik { Imie = "Kamil", Nazwisko = "Mazur", IloscLatPrzepracowanych = 5, Wiek = 32, StopienNaukowy = "Magister", Stanowisko = "Analityk", WynagrodzenieMiesieczne = 5300, IloscUrlopuDoPobrania = 22 },
             new Pracownik { Imie = "Klaudia", Nazwisko = "Witkowska", IloscLatPrzepracowanych = 9, Wiek = 40, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6500, IloscUrlopuDoPobrania = 25 },
             new Pracownik { Imie = "Rafał", Nazwisko = "Kaczmarek", IloscLatPrzepracowanych = 16, Wiek = 53, StopienNaukowy = "Profesor", Stanowisko = "Dyrektor Naczelny", WynagrodzenieMiesieczne = 11500, IloscUrlopuDoPobrania = 31 },
             new Pracownik { Imie = "Marta", Nazwisko = "Jankowska", IloscLatPrzepracowanych = 4, Wiek = 31, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4800, IloscUrlopuDoPobrania = 20 },
             new Pracownik { Imie = "Bartosz", Nazwisko = "Wojciechowski", IloscLatPrzepracowanych = 10, Wiek = 45, StopienNaukowy = "Doktor", Stanowisko = "Dyrektor", WynagrodzenieMiesieczne = 8900, IloscUrlopuDoPobrania = 28 },
             new Pracownik { Imie = "Dominika", Nazwisko = "Krawczyk", IloscLatPrzepracowanych = 7, Wiek = 35, StopienNaukowy = "Magister", Stanowisko = "Kierownik Zespołu", WynagrodzenieMiesieczne = 7000, IloscUrlopuDoPobrania = 24 },
             new Pracownik { Imie = "Kacper", Nazwisko = "Witkowski", IloscLatPrzepracowanych = 13, Wiek = 49, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Projektu", WynagrodzenieMiesieczne = 9200, IloscUrlopuDoPobrania = 29 },
             new Pracownik { Imie = "Wiktoria", Nazwisko = "Lewandowska", IloscLatPrzepracowanych = 8, Wiek = 42, StopienNaukowy = "Magister", Stanowisko = "Specjalista ds. HR", WynagrodzenieMiesieczne = 7600, IloscUrlopuDoPobrania = 25 },
             new Pracownik { Imie = "Radosław", Nazwisko = "Mazurek", IloscLatPrzepracowanych = 3, Wiek = 29, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4600, IloscUrlopuDoPobrania = 19 },
             new Pracownik { Imie = "Weronika", Nazwisko = "Kaczmarek", IloscLatPrzepracowanych = 6, Wiek = 33, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6300, IloscUrlopuDoPobrania = 23 },
             new Pracownik { Imie = "Mikołaj", Nazwisko = "Witkowski", IloscLatPrzepracowanych = 11, Wiek = 47, StopienNaukowy = "Doktor", Stanowisko = "Dyrektor", WynagrodzenieMiesieczne = 9600, IloscUrlopuDoPobrania = 30 },
             new Pracownik { Imie = "Agata", Nazwisko = "Kaczmarek", IloscLatPrzepracowanych = 5, Wiek = 31, StopienNaukowy = "Magister", Stanowisko = "Analityk", WynagrodzenieMiesieczne = 5400, IloscUrlopuDoPobrania = 20 },
             new Pracownik { Imie = "Łukasz", Nazwisko = "Lewandowski", IloscLatPrzepracowanych = 10, Wiek = 46, StopienNaukowy = "Doktor", Stanowisko = "Kierownik Zespołu", WynagrodzenieMiesieczne = 8800, IloscUrlopuDoPobrania = 26 },
             new Pracownik { Imie = "Natalia", Nazwisko = "Zając", IloscLatPrzepracowanych = 2, Wiek = 28, StopienNaukowy = "Brak", Stanowisko = "Asystent", WynagrodzenieMiesieczne = 4400, IloscUrlopuDoPobrania = 18 },
             new Pracownik { Imie = "Marcin", Nazwisko = "Witkowski", IloscLatPrzepracowanych = 7, Wiek = 36, StopienNaukowy = "Inżynier", Stanowisko = "Programista", WynagrodzenieMiesieczne = 6000, IloscUrlopuDoPobrania = 24 },
             new Pracownik { Imie = "Aleksandra", Nazwisko = "Szymańska", IloscLatPrzepracowanych = 14, Wiek = 50, StopienNaukowy = "Doktor", Stanowisko = "Starszy Analityk", WynagrodzenieMiesieczne = 9200, IloscUrlopuDoPobrania = 29 }
         };
            return pracownicy;
        }
    }
}
