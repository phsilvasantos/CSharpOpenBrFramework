using CSOBRF_Criptografia;
using CSOBRF_Util.Grafico;
using CSOBRF_Validacoes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSOBRF_ExemploConsumoWinForms
{
    public partial class frmConsumoWinForms : Form
    {
        ValidacaoFormatacaoDeCampos valida = new ValidacaoFormatacaoDeCampos();
        NewContasMatematicas contas = new NewContasMatematicas();
        public frmConsumoWinForms()
        {
            InitializeComponent();
        }

        #region Criptografia
        private void btnCripExecutar_Click(object sender, EventArgs e)
        {
            Criptografia crip = new Criptografia();
            if(rdbCripCriptografia.Checked)
            {
                tbxCripSaida.Text = crip.Criptografar(tbxCripValor.Text);
            }
            else
            {
                tbxCripSaida.Text = crip.Descriptografar(tbxCripValor.Text);
            }
        }

        #endregion

        #region Validação de Dados
        private void tbxFormatacaoTelefone_Leave(object sender, EventArgs e)
        {
            tbxFormatacaoTelefone.Text = valida.validaFormataTelefone(tbxFormatacaoTelefone.Text);
        }

        private void tbxLimpaString_Leave(object sender, EventArgs e)
        {
            tbxLimpaString.Text = valida.retiraPontuacao(tbxLimpaString.Text);
        }

        private void tbxValidaCpfCnpj_Leave(object sender, EventArgs e)
        {
            if (valida.ValidaCPF(tbxValidaCpfCnpj.Text) || valida.ValidaCNPJ(tbxValidaCpfCnpj.Text)) //verifica se o valor é um CPF ou CNPJ
            {
                tbxValidaCpfCnpj.Text = valida.pontuaCpf_CNPJ(tbxValidaCpfCnpj.Text);
            }
            else
            {
                tbxValidaCpfCnpj.Text = "Inválido";
            }
        }

        private void tbxAjusteDecimal_Leave(object sender, EventArgs e)
        {
            if (contas.verificaSeEInteiro(tbxAjusteDecimal.Text) || contas.verificaSeEDecimal(tbxAjusteDecimal.Text))
            {
                if (rdb2Casas.Checked)
                {
                    tbxAjusteDecimal.Text = contas.newValidaAjustaArredonda2CasasDecimais(tbxAjusteDecimal.Text);
                }
                if (rdb3Casas.Checked)
                {
                    tbxAjusteDecimal.Text = contas.newValidaAjustaArredonda3CasasDecimais(tbxAjusteDecimal.Text);
                }
                if (rdb4Casas.Checked)
                {
                    tbxAjusteDecimal.Text = contas.newValidaAjustaArredonda4CasasDecimais(tbxAjusteDecimal.Text);
                }
            }
        }

        private void tbxVerificaSeEDecimal_Leave(object sender, EventArgs e)
        {
            if (contas.verificaSeEDecimal(tbxVerificaSeEDecimal.Text))
            {
                MessageBox.Show("É decimal!");
            }
            else
            {
                MessageBox.Show("Não é decimal!");
            }
        }
        #endregion

        #region Pesquisa CEP
        private void tbxCEP_Leave(object sender, EventArgs e)
        {
            if(valida.ValidaCep(tbxCEP.Text))
            {
                string[] dadosCep = valida.retornaCepPeloWSCorreios(tbxCEP.Text);
                tbxEndereco.Text = dadosCep[0];
                tbxComplemento.Text = dadosCep[1] + " " + dadosCep[2];
                tbxCidade.Text = dadosCep[3];
                tbxBairro.Text = dadosCep[4];
                tbxUF.Text = dadosCep[5];
            }
        }
        #endregion

        #region Tratamento de Imagens
        private void btnAlterarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileProcurarImagem = new OpenFileDialog();
            openFileProcurarImagem.Title = "Selecione uma imagem para o seu logo";
            openFileProcurarImagem.InitialDirectory = @"C:\";
            openFileProcurarImagem.RestoreDirectory = true;
            openFileProcurarImagem.Filter = "Imagens JPG (apenas formato JPG) (*.jpg)|*.jpg;";            

            if(!Directory.Exists(Directory.GetCurrentDirectory() + "\\IMAGENS\\"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\IMAGENS\\");
            }

            if (openFileProcurarImagem.ShowDialog() == DialogResult.OK)
            {
                Imagem img = new Imagem();
                                
                string retorno = new Imagem().gerarNovaImagem(Convert.ToInt32(tbxLargura.Text), Convert.ToInt32(tbxAltura.Text), openFileProcurarImagem.FileName.ToString(), 1, Convert.ToInt32(tbxCompressao.Text), true);

                tbxCaminhoImagem.Text = openFileProcurarImagem.FileName.ToString();
                Image imgObj = Image.FromFile(openFileProcurarImagem.FileName.ToString());
                pctImagemOrigem.Image = imgObj;
                pctImagemOrigem.Refresh();
                long tamanhoArquivoEntrada = new System.IO.FileInfo(openFileProcurarImagem.FileName.ToString()).Length;                
                tbxEntrada.Text = tamanhoArquivoEntrada.ToString() + " MB";

                if (retorno != "ERRO")//se ele conseguir gerar ele pega o novo caminho da nova imagem
                {
                    Image imgObjRet = Image.FromFile(retorno);
                    pctImagemSaida.Image = imgObjRet;
                    pctImagemSaida.Refresh();
                    tbxCaminhoSaida.Text = retorno;
                    long tamanhoArquivoSaida = new System.IO.FileInfo(retorno).Length;                    
                    tbxSaida.Text = tamanhoArquivoSaida.ToString() + " MB";
                }
                else//senão pega a normal mesmo sem compactacao
                {
                    retorno = openFileProcurarImagem.FileName.ToString();
                    tbxCaminhoSaida.Text = retorno;
                }
            }
        }

        private void btnAbrirImagemSaida_Click(object sender, EventArgs e)
        {
            if (tbxCaminhoSaida.Text != "")
            {
                Process.Start(tbxCaminhoSaida.Text);
            }
        }
        #endregion
    }
}
