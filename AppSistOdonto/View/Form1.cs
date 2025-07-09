using AppSistOdonto.View;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AppSistOdonto
{
    public partial class Inicio : MaterialForm
    {
        public Inicio()
        {
            InitializeComponent();

            // Centraliza no centro da tela
            this.StartPosition = FormStartPosition.CenterScreen;

            // Travar tamanho
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // impede redimensionamento
            this.MaximizeBox = false; // desativa botão de maximizar
            this.MinimizeBox = true;  // deixa minimizar, se quiser
            this.SizeGripStyle = SizeGripStyle.Hide; // tira aquela alça no canto
            this.MinimumSize = this.Size;  // impede que o usuário diminua a janela abaixo do tamanho atual
            this.MaximumSize = this.Size; // impede que o usuário aumente a janela acima do tamanho atual


            // MaterialSkin2 setup
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Teal500,
                Primary.Teal700,
                Primary.Teal200,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void gerenciar_Click(object sender, EventArgs e)
        {
            // Abre a tela multifuncional como modal
            var telaMulti = new TelaMultifuncional(0);
            telaMulti.ShowDialog(); // abre como modal
        }

        private void recebeCxa_Click(object sender, EventArgs e)
        {
            // Abre a tela multifuncional como modal
            var telaMulti = new TelaMultifuncional(1);
            telaMulti.ShowDialog(); // abre como modal
        }

        private void devolveCxa_Click(object sender, EventArgs e)
        {
            // Abre a tela multifuncional como modal
            var telaMulti = new TelaMultifuncional(2);
            telaMulti.ShowDialog(); // abre como modal

        }

        private void cadastraAluno_Click(object sender, EventArgs e)
        {
            // Abre a tela multifuncional como modal
            var telaMulti = new TelaMultifuncional(3);
            telaMulti.ShowDialog(); // abre como modal

        }

        private void relatorios_Click(object sender, EventArgs e)
        {
            // Abre a tela multifuncional como modal
            var telaMulti = new TelaMultifuncional(4);
            telaMulti.ShowDialog(); // abre como modal

        }

        private void sairSistema_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
