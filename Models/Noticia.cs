using System.ComponentModel.DataAnnotations;

namespace Portal.Models
{
    public class Noticia
    {
        //PASO 1
        //de utilizar algun OTRO termino que NO SEA ID, se requiere poner KEY para que el atributo se vuelva la llave
        //primaria, de utilizar ID por convencion se toma como PRIMARY KEY
        [Key]
        public int ID { get; set; }
        //Se le otorga la funciona de se requerida al atributo
        [Required]
        public string Titulo { get; set; } 
        [Required]
        public string Descripcion { get; set; }

        public string Fuente { get; set; }

        public Categoria Categoria { get; set; }
    }
}