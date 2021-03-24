using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criadores
{
    /// <summary>
    /// raça atribuida a um cão
    /// </summary>
    public class Racas
    {
        public Racas(){
            ListaDeCaes = new HashSet<Caes>();
        }
        /// <summary>
        /// identificador das raças
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// identifica o nome da raça
        /// </summary>
        public string Designacao { get; set; }

        //****************************

        //uma raca está associada a muitos cães( aka lista de cães)
        /// <summary>
        /// Lista de cães que são da mesma raça
        /// </summary>
        public ICollection<Caes> ListaDeCaes { get; set; }
    }

}