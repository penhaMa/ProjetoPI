using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class Menu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeighEllipse
     );

        Retirar ret;
        Devolucao dev;
        Reservar res;
        Buscar bu;
        public Menu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            bu = new Buscar();
            ret = new Retirar();
            res = new Reservar();
            dev = new Devolucao();
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            ret.ShowDialog();
        }// Retirar

        private void Devolucao_Click(object sender, EventArgs e)
        {
            dev.ShowDialog();
        }//Devolução

        private void Reservar_Click(object sender, EventArgs e)
        {
            res.ShowDialog();
        }//Reservar

        private void Buscar_Click(object sender, EventArgs e)
        {
            bu.ShowDialog();
        }//Buscar

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//Sair

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }//Fim da Classe
}//Fim do Projeto
