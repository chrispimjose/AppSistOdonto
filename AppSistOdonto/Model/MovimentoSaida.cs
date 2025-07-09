using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistOdonto.Model
{
    internal class MovimentoSaida
    {
        public int SaidaID { get; set; }
        public int CaixaID { get; set; }
        public string Caixa { get; set; } // descrição da caixa para identificação
        public DateTime DataSaida { get; set; }
        public string DetalheSaida { get; set; }  // até 200 caracteres
        public int AlunoID { get; set; }
        public int FuncionarioID { get; set; }
    }
}
