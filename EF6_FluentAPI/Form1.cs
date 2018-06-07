using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF6_FluentAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnProcessar_Click(object sender, EventArgs e)
            {
                using (VendasContexto contexto = new VendasContexto())
                {
                    try
                    {
                        var cliente1 = new Cliente { Nome = "Macoratti", Endereco = "Rua Peru, 100", Telefone = "4555-6666", Cidade = "Lins" };
                        contexto.Clientes.Add(cliente1);
                        contexto.SaveChanges();
                        MessageBox.Show("Cliente criado com sucesso.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
    }
}
