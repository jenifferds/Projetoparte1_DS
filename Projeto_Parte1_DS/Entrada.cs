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
    public partial class Entrada : Form
    {
        Thread t1;
        Thread t2;
        public Entrada()
        {
            InitializeComponent();
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        
        private void abrirLogin(object obj)
        {
            Application.Run( new Login());
        }

        private void btn_cadastre_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrircadastro);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
        private void abrircadastro(object obj)
        {
            Application.Run(new Cadastro());
        }
    }
}
