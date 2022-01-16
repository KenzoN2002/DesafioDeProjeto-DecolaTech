using System;
namespace DIO.Series
{
    public class Serie : entidadebase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }
                        
        private string Descricao { get; set; }
        
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString(){
            string retorno = "";
            retorno += "Genêro: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;

        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaID(){
            return this.Id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Exclui(){
            this.Excluido = true;
        }

    }
}