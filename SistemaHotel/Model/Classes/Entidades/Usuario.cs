using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Usuario
    {

        //Propriedades
        public int Id { get; set; }
        public string NomeDoUsuario { get; set; }
        public long Cpf { get; set; }
        public long Telefone { get; set; }
        public string Endereco { get; set; }
        public string Regra { get; set; }

        //Construtor
        public Usuario(string nomeDoUsuario, long cpf, long telefone, string endereco, string regra)
        {
            NomeDoUsuario = nomeDoUsuario;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
            Regra = regra;
        }

    }
}
