using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudPetshop.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string NomeAnimal { get; set; }

        public int Idade { get; set; }

        public bool Cachorro { get; set; }

        public string NomeDono { get; set; }

        public int Telefone { get; set; }
    }
}

