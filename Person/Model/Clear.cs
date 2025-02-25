using Person.View;
using System.Windows.Forms;

namespace SalesControl.br.com.project.model
{
    public class Clear
    {
        public void Limpartela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is CadastrarPessoa)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                //Limpar o campo de testo
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                            if (ctr2 is MaskedTextBox)
                            {
                                //Limpar o campo de testo
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                            if (ctr2 is ComboBox)
                            {
                                //Limpar o campo de testo
                                (ctr2 as ComboBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}