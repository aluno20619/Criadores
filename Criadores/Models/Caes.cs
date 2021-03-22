using System;
namespace Criadores
{
    /// <summary>
    /// descricao de cada cão
    /// </summary>
    public class Caes
    {
        /// <summary>
        /// identificador do cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome do cão
        /// </summary>
        public string Nome{ get; set; }

        /// <summary>
        /// genero do cão
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// data de nascimento do cão
        /// </summary>
        public DateTime DataNascimento{ get; set; }

        /// <summary>
        /// data de compra do cao
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// registo do cão no livro de origens
        /// </summary>
        public string LOP { get; set; }
    }

}
