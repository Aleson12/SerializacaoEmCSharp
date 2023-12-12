using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Serializacao
{
    public partial class Form1 : Form
    {
        List<Empresa> Empresas = new List<Empresa>();

        JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
           
            var empresa = new Empresa();

            empresa.Nome = txtNome.Text;
            empresa.Municipio = txtMunicipio.Text;
            empresa.UF = txtUF.Text;



            try // tente
            {
                // se os campos não estiverem vazios,

                if ((empresa.Nome != string.Empty) && (empresa.Municipio != string.Empty) && (empresa.UF != string.Empty))
                {
                    // instância para salvar os dados serializados em uma pasta no diretório local:
                    using (StreamWriter sw = new StreamWriter(@"c:\dados\arquivo.json"))
                    {
                         Empresas.Add(empresa); // adicionar cada "empresa" (objetos) à lista global "Empresas"
                         sw.WriteLine(JsonSerializer.Serialize(Empresas, options)); // serializar esses objetos e digitalizá-los
                    }
                    
                    // ao terminar a serialização, abrir uma nova tela
                    Form2 frm = new Form2(Empresas);
                    frm.ShowDialog();
                }
                // se algum dos campos estiver vazio:
                else
                {
                    MessageBox.Show("Preencha todos os campos para gravar os dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        /*
private void radioButton2_CheckedChanged(object sender, EventArgs e)
{
   try
   {
       var strJson = "";

       using (StreamReader sr = new StreamReader(@"c:\dados\arquivo.json"))
       {
           strJson = sr.ReadToEnd();

       }

       var empresa = Empresa.JsonDesserializar(strJson);

       txtNome.Text = empresa.Nome;
       txtMunicipio.Text = empresa.Municipio;
       txtUF.Text = empresa.UF;

   }
   catch (Exception ex)
   {
       MessageBox.Show("Falha: " + ex.Message);
   }
}
*/
    }
}
