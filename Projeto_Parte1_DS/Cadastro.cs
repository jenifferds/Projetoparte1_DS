using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UI_Projeto_Parte1_DS
{

    public partial class Cadastro : Form
    {
        Thread t4;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltardocadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            t4 = new Thread(voltarcadastro);
            t4.SetApartmentState(ApartmentState.STA);
            t4.Start();
        }
        private void voltarcadastro(object obj)
        {
            Application.Run(new Entrada());
        }
    }
}
