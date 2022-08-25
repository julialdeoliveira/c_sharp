using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe._1_TipoReferencia
{
    internal class Book : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Book(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public virtual string BooksName()
        {

            return $"O nome do livro é: {Name}";
        }

        public virtual string TalkAboutBook()
        {

            return $"Esse é o livro: {Name}, que fala sobre {Description}";
        }
    }
}
