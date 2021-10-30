namespace Amazonia.DAL.Entidades
{
    public abstract class Livro : Entidade
    {
        public decimal Preco { protected get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public Idioma Idioma { get; set; }   //Portugues, Espanhol, Ingles

        public virtual decimal ObterPreco(){
            return Preco;
        }

        //Alternativa com mais codigo
        //protected decimal Preco {get; set; }
        //public virtual void InformarPreco(decimal precoSemDesconto)
        //{
        //    Preco = precoSemDesconto;
        //}
    }
}

