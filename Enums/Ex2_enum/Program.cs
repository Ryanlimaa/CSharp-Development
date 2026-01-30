using System;
using System.Globalization;
using Ex2_enum.Entitis;

namespace Ex2_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip! (Tenha uma boa viagem)");
            Comment c2 = new Comment("Wow that's awesome! (Uau isso é incrivel)");
            Post p1 = new Post(
                DateTime.Parse("21/06/2026 13:05:44"),
                "Traveling to New Zealand (Viajando para Nova Zelandia)",
                "I'm going to visit this wonderful country! (Vou visitar este país maravilhoso!)",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night (Boa Noite)");
            Comment c4 = new Comment("May the Force be with you (Que a força esteja com você)");
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Good night guys (Boa noite pessoal)",
                    "See you tomorrow (Até amanhã)",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
