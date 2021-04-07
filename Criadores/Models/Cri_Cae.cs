using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Criadores
{
    public class Cri_Cae
    {
        //pk da tabela( cuidado com dados duplicados)
        [Key]
        public int Id { get; set; }

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


        /*
         *  [Key,Column(Order =1)]
         *  [ForeignKey(nameof(Cao))]
         *  public int CaesFK { get; set; }
         *  public Caes Cao { get; set; }
         *  
         *  [Key,Column(Order =2)]
         *  [ForeignKey(nameof(Criador))]
         *  public int CriadorFK { get; set; }
         *  public Criadores Criador { get; set; }
         */
    }

}