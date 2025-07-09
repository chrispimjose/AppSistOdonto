using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSistOdonto.Model;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AppSistOdonto.View
{
    public partial class TelaMultifuncional : MaterialForm
    {
        private int _indiceAbaInicial;
        public TelaMultifuncional(int indiceAbaInicial = 0)
        {
            InitializeComponent();

            _indiceAbaInicial = indiceAbaInicial;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal200,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            this.StartPosition = FormStartPosition.CenterScreen;

            // seleciona aba depois que InitializeComponent() já criou o tabcontrol
            this.Load += (s, e) =>
            {
                materialTabControl1.SelectedIndex = _indiceAbaInicial;
            };

            // Configurações iniciais das ListViews de Entrada e Saída
            ConfiguraListView();            
            CarregaEntradas();

            ConfiguraListViewSaida();
            CarregaSaidas();


        }

        private void ConfiguraListView()
        {            
            ListViewEntrada.FullRowSelect = true;
            ListViewEntrada.GridLines = true;

            ListViewEntrada.Columns.Clear();
            ListViewEntrada.Columns.Add("Caixa", 200);
            ListViewEntrada.Columns.Add("Tipo Procedimento", 250);
            ListViewEntrada.Columns.Add("Data Entrada", 150);
            ListViewEntrada.Columns.Add("Aluno", 150);
            ListViewEntrada.Columns.Add("Funcionário", 150);
        }

        private void ConfiguraListViewSaida()
        {
            ListViewSaida.FullRowSelect = true;
            ListViewSaida.GridLines = true;

            ListViewSaida.Columns.Clear();
            ListViewSaida.Columns.Add("Caixa", 200);
            ListViewSaida.Columns.Add("Tipo Procedimento", 250);
            ListViewSaida.Columns.Add("Data Entrada", 150);
            ListViewSaida.Columns.Add("Aluno", 150);
            ListViewSaida.Columns.Add("Funcionário", 150);
        }

        private List<MovimentoEntrada> ObterEntradas()
        {
            return new List<MovimentoEntrada>
            {
                new MovimentoEntrada {  Caixa = "Caixa de Maria", TipoProcedimento= "Periodontia", DataEntrada="01/01/2025", AlunoID = 1, FuncionarioID = 1},
                new MovimentoEntrada {  Caixa = "Caixa de João", TipoProcedimento= "Ortondontia", DataEntrada="02/01/2025", AlunoID = 2, FuncionarioID =  1},
                new MovimentoEntrada {  Caixa = "Caixa de Clara", TipoProcedimento= "Ortodontia", DataEntrada="03/01/2025", AlunoID = 3, FuncionarioID = 1 }
            };
        }

        private void CarregaEntradas()
        {
            var entradas = ObterEntradas();

            ListViewEntrada.Items.Clear();

            foreach (var entrada in entradas)
            {
                var item = new ListViewItem(entrada.Caixa.ToString());
                item.SubItems.Add(entrada.TipoProcedimento.ToString());
                item.SubItems.Add(entrada.DataEntrada.ToString());
                item.SubItems.Add(entrada.AlunoID.ToString());
                item.SubItems.Add(entrada.FuncionarioID.ToString());

                ListViewEntrada.Items.Add(item);
            }
        }

        private void CarregaSaidas()
        {
            // Simula a obtenção de dados de saída usando o memso da entrada
            var entradas = ObterEntradas();

            ListViewSaida.Items.Clear();

            foreach (var entrada in entradas)
            {
                var item = new ListViewItem(entrada.Caixa.ToString());
                item.SubItems.Add(entrada.TipoProcedimento.ToString());
                item.SubItems.Add(entrada.DataEntrada.ToString());
                item.SubItems.Add(entrada.AlunoID.ToString());
                item.SubItems.Add(entrada.FuncionarioID.ToString());

                ListViewSaida.Items.Add(item);
            }
        }


    }

}


