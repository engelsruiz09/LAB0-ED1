
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LAB0_ED1_G.Models
{
    public class Cliente
    {
        [Required]
        [Display(Name = "Nombre")]
        
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        
        public string Apellido { get; set; }

        [Required]
        [Display(Name = "Numero Telefonico")]
        
        public int? telefono { get; set; } //el ? significa que los objetos son de tipo anulables

        [Required]
        [Display(Name = "Descripcion del Cliente")]
        public string Descripcion { get; set; }

        public void OrdenamientoN(List<Cliente> listaclientes)//aqui va la lista)
        {
            Cliente aux = new Cliente();
            for(int i = 0; i < listaclientes.Count(); i++)
            {
                for (int j = 0; i < listaclientes.Count() - i - 1; j++)
                {
                    if (listaclientes[j].Nombre[0] > listaclientes[j + 1].Nombre[0])
                    {
                        aux = listaclientes[j];
                        listaclientes[j] = listaclientes[j + 1];
                        listaclientes[j + 1] = aux;
                    }
                }
            }
        }

        public void OrdenamientoA(List<Cliente> listaclientes)//aqui tambien la lista)
        {
            Cliente aux = new Cliente();
            for (int i = 0; i < listaclientes.Count(); i++)
            {
                for (int j = 0; i < listaclientes.Count() - i - 1; j++)
                {
                    if (listaclientes[j].Nombre[0] > listaclientes[j + 1].Nombre[0])
                    {
                        aux = listaclientes[j];
                        listaclientes[j] = listaclientes[j + 1];
                        listaclientes[j + 1] = aux;
                    }
                }
            }
        }
    }
}
