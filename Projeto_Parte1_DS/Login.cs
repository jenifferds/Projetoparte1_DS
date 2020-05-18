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
    public partial class Login : Form
    {
        Thread t3;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltarlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(voltarlogin);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void voltarlogin(object obj)
        {
            Application.Run(new Entrada());
        }
    }
}
