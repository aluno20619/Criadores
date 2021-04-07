using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Criadores
{

    /// <summary>
    /// fotografias de cada cão
    /// </summary>
    public class Fotografias
	{
        /// <summary>
        /// identificador da fotografia
        /// </summary>
        [Key]
        public int Id{ get; set; }

        /// <summary>
        /// data de quando a foto foi tirada
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// sitio onde a foto foi tirada
        /// </summary>
        public string Local { get; set; }

        //*****************************

        //criação da fk que referencia o cão
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }
   }
}
