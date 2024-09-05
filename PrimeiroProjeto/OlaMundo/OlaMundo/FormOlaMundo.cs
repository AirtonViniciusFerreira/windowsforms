namespace OlaMundo
{
    public partial class FormOlaMundo : Form
    {
        private const string OlaMundo = "Ola Mundo!";
        public FormOlaMundo()
        {
            InitializeComponent();
        }

        private void BtnCliqueAqui_Click(object sender, EventArgs e)
        {
            this.LblOlaMundo.Text = OlaMundo;
            this.LblOlaMundo.Visible = true;
            this.TimerOlaMundo.Enabled = true;
        }

        private void BtnCliqueAquiUser_Click(object sender, EventArgs e)
        {
            FormInputNome inputNome = new FormInputNome();
            if (inputNome.ShowDialog() == DialogResult.Cancel) return;
            var usuario = inputNome.GetUsuario();
            this.LblOlaMundo.Visible = true;
            this.LblOlaMundo.Text = $"{OlaMundo}{Environment.NewLine} Bem vindo {usuario.Nome}";
            this.TimerOlaMundo.Enabled = true;
        }

        private void TimerOlaMundo_Tick(object sender, EventArgs e)
        {
            if (this.LblOlaMundo.Visible)
            {
                this.LblOlaMundo.Visible = false;
                this.LblOlaMundo.Text = this.LblOlaMundo.Name;
                this.TimerOlaMundo.Enabled = false;
            }
        }


    }
}
