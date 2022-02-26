namespace DIO_Series
{
    public class Filme : EntidadeBase
    {
        
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private int Classificacao { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, string descricao, int ano, int classificacao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Classificacao = classificacao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Faixa Etária: " + this.Classificacao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        internal int retornaId()
        {
            return this.Id;
        }

        internal bool retornaExcluido()
        {
            return this.Excluido;
        }   
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}