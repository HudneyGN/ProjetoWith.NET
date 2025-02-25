using MySql.Data.MySqlClient;
using Person.ConnectionBD;
using Person.Model;
using Person.Model.Exception;
using System.Windows.Forms;

namespace Person.Dao
{
    public class PessoaDao
    {
        private MySqlConnection _conexao;

        public PessoaDao()
        {
            _conexao = new Connection().GetConnection();
        }
        #region Cadastrar Pessoa
        public void CadastrarPessoa(Pessoa pessoa)
        {
            try
            {
                // 1 - Definir o comando Insert 
                string sql = @"insert into pessoa
                (nome,email,rg,cpf,sexo,rua,numero,bairro,cidade,estado,uf)
                VALUES (@nome,@email,@rg,@cpf,@sexo,@rua,@numero,@bairro,@cidade,@estado,@uf)";

                MySqlCommand cmd = new MySqlCommand(sql, _conexao);

                //cmd.Parameters.AddWithValue(@"id", pessoa.Id);
                cmd.Parameters.AddWithValue(@"nome", pessoa.Nome);
                cmd.Parameters.AddWithValue(@"email", pessoa.Email);
                cmd.Parameters.AddWithValue(@"rg", pessoa.Rg);
                cmd.Parameters.AddWithValue(@"cpf", pessoa.Cpf);
                cmd.Parameters.AddWithValue(@"sexo", pessoa.Sexo);
                //cmd.Parameters.AddWithValue(@"nascimento", pessoa.Nasciemento);
                cmd.Parameters.AddWithValue(@"rua", pessoa.Rua);
                cmd.Parameters.AddWithValue(@"numero", pessoa.Numero);
                cmd.Parameters.AddWithValue(@"bairro", pessoa.Bairro);
                cmd.Parameters.AddWithValue(@"cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue(@"estado", pessoa.Estado);
                cmd.Parameters.AddWithValue(@"uf", pessoa.Uf);

                // 2 - Abrir conexao e executar o comando sql
                _conexao.Open();
                cmd.ExecuteNonQuery();    // ---------------------------------> // erro estar aqui

                MessageBox.Show("Pessoa cadastrada com Sucesso!");
            }
            catch (ControlException e)
            {
                MessageBox.Show("Erro ao cadastrar cliente" + e.Message);
            }
            finally
            {
                _conexao.Close();
            }
        }
        #endregion
    }
}
