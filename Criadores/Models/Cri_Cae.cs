using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criadores
{
    public class Cri_Cae
    {
        /// <summary>
        /// data de compra do cao
        /// </summary>
        public DateTime DataCompra { get; set; }


        //*************************** 

        [ForeignKey(nameof(Cao))]
        public int CaesFK { get; set; }
        public Caes Cao { get; set; }


        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }
    }

}