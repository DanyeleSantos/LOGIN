using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnconectar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = Txtusuario.Text;
            senha = Txtsenha.Text;

            if (usuario == "conradito" && senha == "123")
            {
                MessageBox.Show("Voce se conectou!");
            }
            else
            {
                MessageBox.Show("Está incorrerto...");


            } 

           
            

            
        }
    }
}
