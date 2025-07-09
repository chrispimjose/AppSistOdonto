using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistOdonto.Model
{
    internal class MovimentoEntrada
    {
        public int CaixaID{ get; set; }
        public required string Caixa { get; set; } // descrição da caixa para identificação
        public string TipoProcedimento { get; set; }
        public string DataEntrada { get; set; }
        public string? DetalheEntrada { get; set; }  // até 200 caracteres
        public int AlunoID { get; set; }
        public int FuncionarioID { get; set; }
    }
}
