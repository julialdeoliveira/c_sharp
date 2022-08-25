using Console_exe._1_TipoReferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.exercicios
{
    internal class TestBooks
    {
        public static void ShowBooks()
        {
            Book romance = new Book("Como eu era antes de você", "Um homem que morre");
            Book acao = new Book("Divergente", "Muita ação");
            
            BaseRepository<Book> baseRepository = new BaseRepository<Book>();
            baseRepository.Create(acao);
            baseRepository.Create(romance);

            foreach (var book in baseRepository.Read())
            {
                Console.WriteLine(book.TalkAboutBook());
            }

        }
    }
}
