/**********************************************************************************
 * NOME:            BDServico
 * CLASSE:          Representação da classe de banco de dados Servico
 * DT CRIAÇÃO:      16/09/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     fgomes
 * OBSERVAÇÕES:     
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AplicativoBanhoeTosa
{
    class BDServico
    {
        //Destructor da Classe
        ~BDServico()
        {
        }

        /***********************************************************************r
        * NOME          :  Incluir          
        * METODO        :  Responsável por incluir o registro na tabela.
        *                  Inclui um registro na tabela TB_SERVICO         
        * DT CRIAÇÃO    :  16/09/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Servico 
        * RETORNO       :  Código do último registro na TB_SERVICO ou -1 
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public int Incluir(Servico aobjServico)
        {
            //(10/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "INSERT INTO TB_SERVICO " +
                            "(" +
                            "S_NM_SERVICO, " +
                            "S_VLR_SERVICO, " +
                            "S_DS_SERVICO, " +
                            "S_DURA_SERVICO " +
                            ")" +
                            "VALUES " +
                            "(" +
                            "@S_NM_SERVICO, " +
                            "@S_VLR_SERVICO, " +
                            "@S_DS_SERVICO, " +
                            "@S_DURA_SERVICO " +
                            ");" +
                            "SELECT IDENT_CURRENT('TB_SERVICO') AS 'id'";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_NM_SERVICO", aobjServico.NM_SERVICO);
            objCmd.Parameters.AddWithValue("@S_VLR_SERVICO", aobjServico.VLR_SERVICO);
            objCmd.Parameters.AddWithValue("@S_DS_SERVICO", aobjServico.DS_SERVICO);
            objCmd.Parameters.AddWithValue("S_DURA_SERVICO", aobjServico.DURA_SERVICO);

            try
            {
                //(10/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                objCon.Open();

                //(10/10/2019 - fgomes) Executo o comando de forma Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(10/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
                objCon.Close();

                return _id;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        /***********************************************************************
        * NOME          :  Alterar          
        * METODO        :  Responsável por Alterar o registro na tabela TB_SERVICO         
        * DT CRIAÇÃO    :  10/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Servico 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Alterar(Servico aobjServico)
        {
            if (aobjServico.COD_SERVICO != -1)
            {
                //(10/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                string varSql = "UPDATE TB_SERVICO SET " +
                                "S_NM_SERVICO = @S_NM_SERVICO, " +
                                "S_VLR_SERVICO  = @S_VLR_SERVICO, " +
                                "S_DS_SERVICO = @S_DS_SERVICO, " +
                                "S_DURA_SERVICO = @S_DURA_SERVICO " +
                                "WHERE I_COD_SERVICO = @I_COD_SERVICO";

                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_SERVICO", aobjServico.COD_SERVICO);
                objCmd.Parameters.AddWithValue("@S_NM_SERVICO", aobjServico.NM_SERVICO);
                objCmd.Parameters.AddWithValue("@S_VLR_SERVICO", aobjServico.VLR_SERVICO);
                objCmd.Parameters.AddWithValue("@S_DS_SERVICO", aobjServico.DS_SERVICO);
                objCmd.Parameters.AddWithValue("@S_DURA_SERVICO", aobjServico.DURA_SERVICO);

                try
                {
                    //(10/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                    objCon.Open();

                    //(10/10/2019 - fgomes) Executo o comando de forma Escalar
                    objCmd.ExecuteNonQuery();

                    //(10/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
                    objCon.Close();

                    return true;

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /***********************************************************************
        * NOME          :  Excluir          
        * METODO        :  Responsável por excluir o registro na tabela TB_SERVICO         
        * DT CRIAÇÃO    :  10/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Servico 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Excluir(Servico aobjServico)
        {
            //(10/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "DELETE FROM TB_SERVICO " +
                            "WHERE I_COD_SERVICO = @I_COD_SERVICO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_SERVICO", aobjServico.COD_SERVICO);

            try
            {
                //(10/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                objCon.Open();

                //(10/10/2019 - fgomes) Executo o comando de forma Escalar
                objCmd.ExecuteNonQuery();

                //(10/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
                objCon.Close();

                return true;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /***********************************************************************
        * NOME          :  FindAll          
        * METODO        :  Responsável por encontar todos os registros que estão 
        *                  na tabela TB_SERVICO         
        * DT CRIAÇÃO    :  10/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  -
        * RETORNO       :  Lista de Servicos
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public List<Servico> FindAllServico()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = "SELECT * FROM TB_SERVICO";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();
            List<Servico> lista = new List<Servico>();

            if (objDtr.HasRows)
            {
                //(10/10/2019 - fgomes) Enquanto tiver linha, faça.
                while (objDtr.Read())
                {
                    //(10/10/2019 - fgomes) Estanciei o Objeto Servico
                    Servico aobjServico = new Servico();

                    aobjServico.COD_SERVICO = Convert.ToInt16(objDtr["I_COD_SERVICO"]);
                    aobjServico.NM_SERVICO = objDtr["S_NM_SERVICO"].ToString();
                    aobjServico.VLR_SERVICO = objDtr["S_VLR_SERVICO"].ToString();
                    aobjServico.DS_SERVICO = objDtr["S_DS_SERVICO"].ToString();
                    aobjServico.DURA_SERVICO = objDtr["S_DURA_SERVICO"].ToString();

                    lista.Add(aobjServico);

                }
                objCon.Close();
                objDtr.Close();
                return lista;
            }
            else
            {
                objCon.Close();
                objDtr.Close();
                return null;
            }
        }

        /***********************************************************************
        * NOME          :  FindByCodServico          
        * METODO        :  Responsável por encontar o registros que está 
        *                  na tabela TB_SERVICO         
        * DT CRIAÇÃO    :  10/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Servico
        * RETORNO       :  Classe Servico
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public Servico FindByCodServico(Servico aobjServico)
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "SELECT * FROM TB_SERVICO " +
                            "WHERE I_COD_SERVICO = @I_COD_SERVICO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_SERVICO", aobjServico.COD_SERVICO);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();

            if (objDtr.HasRows)
            {
                objDtr.Read();
                //(10/10/2019 - fgomes) Estanciei o Objeto Servico
                aobjServico.COD_SERVICO = Convert.ToInt16(objDtr["I_COD_SERVICO"]);
                aobjServico.NM_SERVICO = objDtr["S_NM_SERVICO"].ToString();
                aobjServico.VLR_SERVICO = objDtr["S_VLR_SERVICO"].ToString();
                aobjServico.DS_SERVICO = objDtr["S_DS_SERVICO"].ToString();
                aobjServico.DURA_SERVICO = objDtr["S_DURA_SERVICO"].ToString();

                objCon.Close();
                objDtr.Close();
                return aobjServico;
            }
            else
            {
                objCon.Close();
                objDtr.Close();
                return null;
            }
        }

    }
}