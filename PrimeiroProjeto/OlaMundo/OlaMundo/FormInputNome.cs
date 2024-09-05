using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class FormInputNome : Form
    {
        public class Usuario
        {
            public string Nome { get; set; } = string.Empty;
        }
        public FormInputNome()
        {
            InitializeComponent();
            this.Configurar();
        }

        private void Configurar()
        {
            this.BsNome.DataSource = new Usuario();
            this.TbNome.DataBindings.Add("Text", this.BsNome, "Nome");
        }

        public Usuario GetUsuario()
        {
            return (Usuario)this.BsNome.DataSource;
        }
        

        
    }
}
