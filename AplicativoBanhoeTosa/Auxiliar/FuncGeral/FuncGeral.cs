/************************************************************************
 * NOME:            FuncGeral
 * CLASSE:          REPRESENTAÇÃO DA CLASSE DE AUXÍLIO DAS FUNÇÕES GERAIS
 * DT CRIAÇÃO:      21/10/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     Monstro - mFacine
 * OBSERVAÇÕES:     CLASSE RESPONSÁVEL PELAS AÇÕES 
 *                  AUXILIARES DE CLASSES E FORMULÁRIOS
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace AplicativoBanhoeTosa
{
    class FuncGeral
    {

        /// <SUMMARY>
        /// Vetor de byte utilizados para a criptografia (chave externa)
        /// </SUMMARY>
        private static byte[] bIV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

        /// <summary>
        /// Representação de valor em base 64 (chave interna)
        /// O valor represanta a transformação para base64 de 
        /// um conjunto de 32 caracteres (8 * 32 - 256 bits)
        /// a chave é: "Criptografia com Rijndael / AES"
        /// </summary>
        private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";


        /***********************************************************************
        * NOME:            Criptografa        
        * METODO:          Criptografa o Password do usuário e retorna o 
        *                   Password criptografado
        * PARAMETRO:       String sPassWord
        * RETORNO:         String 
        * DT CRIAÇÃO:      21/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        ***********************************************************************/
        public string Criptografa(string sPassWord)
        {

            try
            {
                //(21/10/2019-mfacine) Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(sPassWord))
                {
                    //(21/10/2019-mfacine) Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = new UTF8Encoding().GetBytes(sPassWord);

                    //(21/10/2019-mfacine) Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    //(21/10/2019 - mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    //(21/10/2019 - mfacine)
                    // Cria o espaço de memória para guardar o valor criptografado:                
                    MemoryStream mStream = new MemoryStream();
                    // Instancia o encriptador                 
                    CryptoStream encryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateEncryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    //(21/10/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória
                    encryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    encryptor.FlushFinalBlock();
                    // Pega o vetor de bytes da memória e gera a string criptografada                
                    return Convert.ToBase64String(mStream.ToArray());
                }
                else
                {
                    //(21/10/2019-mfacine) Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(21/10/2019-mfacine) Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }



        /*****************************************************************************
        * Nome           : DesCriptografa
        * Procedimento   : Descriptografa o password do usuário e retorna o 
        *                  pass descriptografado
        * Parametros     : sCriptoPassWord
        * Data  Criação  : 21/10/2019
        * Data Alteração : -
        * Escrito por    : mfacine
        * ***************************************************************************/
        public string DesCriptografa(string sCriptoPassWord)
        {
            try
            {
                //(27/05/2019-mfacine) Se a string não está vazia, executa a criptografia           
                if (!string.IsNullOrEmpty(sCriptoPassWord))
                {
                    //(21/10/2019-mfacine) Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = Convert.FromBase64String(sCriptoPassWord);

                    // Instancia a classe de criptografia Rijndael                
                    Rijndael rijndael = new RijndaelManaged();

                    //(21/10/2019-mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    //(21/10/2019-mfacine) Cria o espaço de memória para guardar o valor DEScriptografado:               
                    MemoryStream mStream = new MemoryStream();

                    //(21/10/2019-mfacine) Instancia o Decriptador                 
                    CryptoStream decryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateDecryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    //(21/10/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória   
                    decryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    decryptor.FlushFinalBlock();
                    // Instancia a classe de codificação para que a string venha de forma correta         
                    UTF8Encoding utf8 = new UTF8Encoding();
                    // Com o vetor de bytes da memória, gera a string descritografada em UTF8       
                    return utf8.GetString(mStream.ToArray());
                }
                else
                {
                    //(21/10/2019-mfacine) Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(21/10/2019-mfacine) Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }




        /*************************************************************************
        * NOME          :  LimpaTela          
        * METODO        :  Responsável por limpar cada componente de tela editável
        * DT CRIAÇÃO    :  21/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Nome do Formulário
        * RETORNO       :  
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  
        *************************************************************************/
        public void LimpaTela(Form obj_Form)
        {
            //(21/10/2019 - mFacine) Percorrer todos os componentes do Formulário
            foreach (Control obj_pnl in obj_Form.Controls)
            {
                //(21/10/2019 - mFacine) Perguntar se o Controle é o pnl_Detalhe
                if (obj_pnl is Panel && obj_pnl.Name == "pnl_Detalhe")
                {
                    //(26 / 09 / 2019 - mFacine) Percorrer todos os componentes do painel
                    foreach (Control obj_Comp in obj_pnl.Controls)
                    {
                        //(21/10/2019 - mFacine) Perguntar se o Controle é um TextBox
                        if (obj_Comp is TextBox)
                        {
                            obj_Comp.Text = "";
                        }

                        if (obj_Comp is Label && Convert.ToInt16(obj_Comp.Tag) == 1)
                        {
                            obj_Comp.Text = "";
                        }

                    }
                }
            }
        }

        /*************************************************************************
        * NOME          :  HabilitaTela          
        * METODO        :  Responsável por habilitar cada componente de tela editável
        * DT CRIAÇÃO    :  21/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Nome do Formulário e uma variável bool
        * RETORNO       :  
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  
        *************************************************************************/
        public void HabilitaTela(Form obj_Form, bool Hab)
        {
            //(21/10/2019 - mFacine) Percorrer todos os componentes do Formulário
            foreach (Control obj_pnl in obj_Form.Controls)
            {
                //(21/10/2019 - mFacine) Perguntar se o Controle é o pnl_Detalhe
                if (obj_pnl is Panel && obj_pnl.Name == "pnl_Detalhe")
                {
                    //(26 / 09 / 2019 - mFacine) Percorrer todos os componentes do painel
                    foreach (Control obj_Comp in obj_pnl.Controls)
                    {
                        //(21/10/2019 - mFacine) Perguntar se o Controle é um TextBox
                        if (obj_Comp is TextBox && Convert.ToInt16(obj_Comp.Tag) != 1)
                        {
                            obj_Comp.Enabled = Hab;
                        }

                        if (obj_Comp is RadioButton)
                        {
                            obj_Comp.Enabled = Hab;
                        }

                        if (obj_Comp is Button)
                        {
                            obj_Comp.Enabled = Hab;
                        }

                        if (obj_Comp is CheckBox)
                        {
                            obj_Comp.Enabled = Hab;
                        }

                    }
                }
            }
        }

        /*************************************************************************
       * NOME          :  StatusBtn          
       * METODO        :  Responsável por habilitar ou desabilitar os botões do 
       *                  painel Buttons
       * DT CRIAÇÃO    :  21/10/2019    
       * DT ALTERAÇÃO  :  -
       * PARAMETRO     :  Nome do Formulário e uma variável 
       * RETORNO       :  
       * ESCRITA POR   :  fgomes 
       * OBSERVAÇÕES   :  
       *************************************************************************/
        public void StatusBtn(Form obj_Form, int iStatus)
        {
            foreach (Control obj_pnl in obj_Form.Controls)
            {
                //(21/10/2019 - mFacine) Perguntar se o Controle é o pnl_Button
                if (obj_pnl is Panel && obj_pnl.Name == "pnl_Button")
                {
                    //(26 / 09 / 2019 - mFacine) Percorrer todos os componentes do painel
                    foreach (Control obj_btn in obj_pnl.Controls)
                    {
                        switch (iStatus)
                        {
                            case 0:
                                {
                                    if (obj_btn.Name == "btn_Novo")
                                    {
                                        obj_btn.Enabled = true;
                                    }

                                    if (obj_btn.Name == "btn_Alterar")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Excluir")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Confirmar")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Cancelar")
                                    {
                                        obj_btn.Enabled = false;
                                    }
                                    break;
                                }

                            case 1:
                                {
                                    if (obj_btn.Name == "btn_Novo")
                                    {
                                        obj_btn.Enabled = true;
                                    }

                                    if (obj_btn.Name == "btn_Alterar")
                                    {
                                        obj_btn.Enabled = true;
                                    }

                                    if (obj_btn.Name == "btn_Excluir")
                                    {
                                        obj_btn.Enabled = true;
                                    }

                                    if (obj_btn.Name == "btn_Confirmar")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Cancelar")
                                    {
                                        obj_btn.Enabled = false;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (obj_btn.Name == "btn_Novo")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Alterar")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Excluir")
                                    {
                                        obj_btn.Enabled = false;
                                    }

                                    if (obj_btn.Name == "btn_Confirmar")
                                    {
                                        obj_btn.Enabled = true;
                                    }

                                    if (obj_btn.Name == "btn_Cancelar")
                                    {
                                        obj_btn.Enabled = true;
                                    }
                                    break;
                                }

                        }
                    }
                }
            }
        }

        /*************************************************************************
        * NOME          :  PopulaLabels          
        * METODO        :  Responsável por trazer os valores dos labels das telas com
        *                  códigos de outras classes
        *                  1-Dono; 2-Cachorro; 3-Servico; 4-aluno; 5-Livro
        * DT CRIAÇÃO    :  21/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  duas variável 
        * RETORNO       :  
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  
        *************************************************************************/

        public String PopulaLabels(string sCod, int iTipo)
        {
            string stexto = "";
            switch (iTipo)
            {
                case 1:
                    {
                        BDDono objBDDono = new BDDono();
                        Dono objDono = new Dono();
                        objDono.COD_DONO = Convert.ToInt16(sCod);
                        stexto = objBDDono.FindByCodDono(objDono).NM_DONO;
                        break;

                    }

                case 2:
                    {
                        BDCachorro objBDCachorro = new BDCachorro();
                        Cachorro objCachorro = new Cachorro();
                        objCachorro.COD_CACHORRO = Convert.ToInt16(sCod);
                        stexto = objBDCachorro.FindByCodCachorro(objCachorro).NM_CACHORRO;
                        break;
                    }

                case 3:
                    {
                        BDServico objBDServico = new BDServico();
                        Servico objServico = new Servico();
                        objServico.COD_SERVICO = Convert.ToInt16(sCod);
                        stexto = objBDServico.FindByCodServico(objServico).NM_SERVICO;
                        break;
                    }

                default:
                    {
                        stexto = "";
                        break;
                    }


            }
            return stexto;
        }


        /***********************************************************************
        * NOME:            ValidaTipo       
        * METODO:          Valida cada conteúdo editado
        * PARAMETRO:       Tipo e uma String                 
        * DT CRIAÇÃO:      21/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public bool ValidaTipo(Type tipo, string valorVerificar)
        {

            bool bValida = false;
            switch (tipo.Name)
            {
                case "Int16":
                    {
                        int valorInteiro;
                        bValida = int.TryParse(valorVerificar, out valorInteiro);
                        break;
                    }

                case "double":
                    {
                        double valordouble;
                        bValida = double.TryParse(valorVerificar, out valordouble);
                        break;
                    }

                case "DateTime":
                    {
                        DateTime valorDateTime;
                        bValida = DateTime.TryParse(valorVerificar, out valorDateTime);
                        break;
                    }

                default:
                    {
                        bValida = false;
                        break;
                    }
            }
            return bValida;
        }

        /***********************************************************************
        * NOME:            ValidaCampos       
        * METODO:          Valida Componentes editáveis que está no painel 
        *                  Detalhe onde Tag 2 é INT e Tag 3 é Data e Tab 4 é double
        * PARAMETRO:       Nome do Formulário  
        * RETORNO:         BOOLEANO                
        * DT CRIAÇÃO:      27/06/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public bool ValidaCampos(Form objForm)
        {
            bool bValida = true;

            //(27/06/2019-mfacine) Percorre todos os componentes do Formulário
            foreach (Control pnl in objForm.Controls)
            {
                //(27/06/2019-mfacine) Perguntar se é um painel e se o nome é pnl_Detalhe
                if (pnl is Panel && pnl.Name == "pnl_Detalhe")
                {
                    //(27/06/2019-mfacine) Percorre todos os componentes do pnl_Detalhe
                    foreach (Control ctrl1 in pnl.Controls)
                    {
                        if (ctrl1 is TextBox)
                        {
                            if (Convert.ToInt16(ctrl1.Tag) == 2)
                            {
                                if (!(ValidaTipo(typeof(Int16), ctrl1.Text)))
                                {
                                    MessageBox.Show("Dados inválidos no campo preenchido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ctrl1.Focus();
                                    bValida = false;
                                    break;
                                }
                            }

                            if (Convert.ToInt16(ctrl1.Tag) == 3)
                            {
                                if (!(ValidaTipo(typeof(DateTime), ctrl1.Text)))
                                {
                                    MessageBox.Show("Dados inválidos no campo preenchido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ctrl1.Focus();
                                    bValida = false;
                                    break;
                                }

                            }

                            if (Convert.ToInt16(ctrl1.Tag) == 4)
                            {
                                if (!(ValidaTipo(typeof(double), ctrl1.Text)))
                                {
                                    MessageBox.Show("Dados inválidos no campo preenchido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ctrl1.Focus();
                                    bValida = false;
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            return bValida;
        }
    }
}


