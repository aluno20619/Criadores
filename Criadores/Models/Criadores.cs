using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Criadores
{
    /// <summary>
    /// descricao de cada criador
    /// </summary>
    public class Criadores
    {
        public Criadores() {
            ListaDeCaes = new HashSet<Cri_Cae>();
    }

    /// <summary>
    /// identificador do criador
    /// </summary>
    [Key]
    public int Id { get; set; }
        /// <summary>
        ///Nome do criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// nome registado com o do(s) cão(es)
        /// </summary>
        public string NomeComerce { get; set; }

        /// <summary>
        ///morada do criador, não contém o código postal
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// código postal do criador
        /// </summary>
        public string CodigoPos { get; set; }

        /// <summary>
        /// telemóvel do criador
        /// </summary>
        public string Telemomovel { get; set; }

        /// <summary>
        /// endereço email do criador
        /// </summary>
        public string Email { get; set; }

        public ICollection<Cri_Cae> ListaDeCaes { get; set; }

    }
}
