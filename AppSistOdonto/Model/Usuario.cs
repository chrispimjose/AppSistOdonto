using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistOdonto.Model
{
    internal class Usuario
    {
        public int IdUser { get; set; }
        public string Nome { get; set; }  // até 150 caracteres
        public string Cpf { get; set; }  // até 11 caracteres
        public string Telefone { get; set; }  // até 11 caracteres
        public string TipoUsuario { get; set; }  // "Administrador", "Funcionario" ou "Aluno"
        public string Email { get; set; }  // até 150 caracteres
        public string TextTemplate { get; set; }  // até 2000 caracteres

    }
}
