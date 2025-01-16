using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            minhaBiblioteca.minhaCLasse minhaCLasse = new minhaBiblioteca.minhaCLasse();
            // introduzindo minhaBiblioteca na classe do botão para utiliza-la
            string Texto = "Oiii";
             System.Windows.Forms.MessageBox.Show("Mensagem do botão");
            //menssagem do botão
            MessageBox.Show(Texto); //utilizando messageBox utilizando a string Texto
            MessageBox.Show(minhaCLasse.name);//utilizando a string armazenada no nameSpace
        }
    }
}

    namespace minhaBiblioteca //criando namespace
{
    public class minhaCLasse // definindo a classe
    {
        public string name = "boa boa"; //introduzindo uma string
    }
}
    