using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace Criadores
{
    /// <summary>
    /// descricao de cada cão
    /// </summary>
    public class Caes
    {
        public  Caes(){
            ListaDeFotos = new HashSet<Fotografias>();
            ListaDeCriadores = new HashSet<Cri_Cae>();
        }
        /// <summary>
        /// identificador do cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// genero do cão
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// data de nascimento do cão
        /// </summary>
        public DateTime DataNascimento { get; set; }

        
        /// <summary>
        /// registo do cão no livro de origens
        /// </summary>
        public string LOP { get; set; }

        //**************************************

        /// <summary>
        /// FK para a raça do cão
        /// </summary>
        [ForeignKey(nameof(Raca))] //representa uma fk para a classe Raça
        public int RacaFK { get; set; }//atributo usado no sgbd e no c#
        public Racas Raca { get; set; }//atributo a ser usado no c# representa fk

    public ICollection<Fotografias> ListaDeFotos { get; set; }

    public ICollection<Cri_Cae> ListaDeCriadores { get; set; }

    }

}
