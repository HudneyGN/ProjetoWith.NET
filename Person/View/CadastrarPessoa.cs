using Person.Dao;
using Person.Model;
using SalesControl.br.com.project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person.View
{
    public partial class CadastrarPessoa : Form
    {
        public CadastrarPessoa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            //pessoa.Id = Convert.ToInt32(txtId);
            pessoa.Nome = txtNome.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.Rg = txtRg.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Sexo = txtSexo.Text;
            //pessoa.Nasciemento = Convert.ToDateTime(txtNascimento.Text).;
            pessoa.Rua = txtRua.Text;
            pessoa.Numero = Convert.ToInt32(txtNumero.Text);
            pessoa.Bairro = txtBairro.Text;
            pessoa.Cidade = txtCidade.Text;
            pessoa.Estado = txtEstado.Text;
            pessoa.Uf = txtUf.Text;

            PessoaDao pessoaDao = new PessoaDao();
            pessoaDao.CadastrarPessoa(pessoa);

            new Clear().Limpartela(this);

        }

        private void CadastrarPessoa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Clear().Limpartela(this);
        }

        private void txtUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
