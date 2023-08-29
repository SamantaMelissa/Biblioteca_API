using Biblioteca.Contexts;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public class LivroRepository
    {
        private readonly BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public List<Livro> Listar() { 
            return _context.Livros.ToList();
        
        }

    }
}
