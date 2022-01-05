/**********************************************************************************
 * NOME:            BDTrabalho
 * CLASSE:          Representação da classe de banco de dados Trabalho
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
    class BDTrabalho
    {
        //Destructor da Classe
        ~BDTrabalho()
        {
        }

        /***********************************************************************
        * NOME          :  Incluir          
        * METODO        :  Responsável por incluir o registro na tabela.
        *                  Inclui um registro na tabela TB_TRABALHO         
        * DT CRIAÇÃO    :  16/09/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Trabalho 
        * RETORNO       :  Código do último registro na TB_TRABALHO ou -1 
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public int Incluir(Trabalho aobjTrabalho)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "INSERT INTO TB_TRABALHO " +
                            "(" +
                            "I_COD_DONO, " +
                            "I_COD_CACHORRO, " +
                            "I_COD_SERVICO, " +
                            "DT_DATA_TRABALHO, " +
                            "DT_HR_TRABALHO " +
                            ")" +
                            "VALUES " +
                            "(" +
                            "@I_COD_DONO, " +
                            "@I_COD_CACHORRO, " +
                            "@I_COD_SERVICO, " +
                            "@DT_DATA_TRABALHO, " +
                            "@DT_HR_TRABALHO " +
                            ");" +
                            "SELECT IDENT_CURRENT('TB_TRABALHO') AS 'id'";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjTrabalho.COD_DONO);
            objCmd.Parameters.AddWithValue("@I_COD_CACHORRO", aobjTrabalho.COD_CACHORRO);
            objCmd.Parameters.AddWithValue("@I_COD_SERVICO", aobjTrabalho.COD_SERVICO);
            objCmd.Parameters.AddWithValue("@DT_DATA_TRABALHO", aobjTrabalho.DATA_TRABALHO);
            objCmd.Parameters.AddWithValue("@DT_HR_TRABALHO", aobjTrabalho.HR_TRABALHO);

            try
            {
                //(09/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                objCon.Open();

                //(09/10/2019 - fgomes) Executo o comando de forma Escalar
                int _id = Convert.ToInt16(objCmd.ExecuteScalar());

                //(09/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
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
        * METODO        :  Responsável por Alterar o registro na tabela TB_TRABALHO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Trabalho 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Alterar(Trabalho aobjTrabalho)
        {
            if (aobjTrabalho.COD_TRABALHO != -1)
            {
                //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                string varSql = "UPDATE TB_TRABALHO SET " +
                                "I_COD_DONO         = @I_COD_DONO   ," +
                                "I_COD_CACHORRO     = @I_COD_CACHORRO   ," +
                                "I_COD_SERVICO     = @I_COD_SERVICO ," +
                                "DT_DATA_TRABALHO     = @DT_DATA_TRABALHO  ," +
                                "DT_HR_TRABALHO   = @DT_HR_TRABALHO " +
                                "WHERE I_COD_TRABALHO = @I_COD_TRABALHO";

                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_TRABALHO", aobjTrabalho.COD_TRABALHO);
                objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjTrabalho.COD_DONO);
                objCmd.Parameters.AddWithValue("@I_COD_CACHORRO", aobjTrabalho.COD_CACHORRO);
                objCmd.Parameters.AddWithValue("@I_COD_SERVICO", aobjTrabalho.COD_SERVICO);
                objCmd.Parameters.AddWithValue("@DT_DATA_TRABALHO", aobjTrabalho.DATA_TRABALHO);
                objCmd.Parameters.AddWithValue("@DT_HR_TRABALHO", aobjTrabalho.HR_TRABALHO);

                try
                {
                    //(09/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                    objCon.Open();

                    //(09/10/2019 - fgomes) Executo o comando de forma Escalar
                    objCmd.ExecuteNonQuery();

                    //(09/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
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
        * METODO        :  Responsável por excluir o registro na tabela TB_TRABALHO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Trabalho 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Excluir(Trabalho aobjTrabalho)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "DELETE FROM TB_TRABALHO " +
                            "WHERE I_COD_TRABALHO = @I_COD_TRABALHO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_TRABALHO", aobjTrabalho.COD_TRABALHO);

            try
            {
                //(09/10/2019 - fgomes) Abro a Conexão com o Banco de Dados
                objCon.Open();

                //(09/10/2019 - fgomes) Executo o comando de forma Escalar
                objCmd.ExecuteNonQuery();

                //(09/10/2019 - fgomes) Fecho a Conexão com o Banco de Dados
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
        *                  na tabela TB_TRABALHO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  -
        * RETORNO       :  Lista de Trabalhos
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public List<Trabalho> FindAllTrabalho()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = "SELECT * FROM TB_TRABALHO";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();
            List<Trabalho> lista = new List<Trabalho>();

            if (objDtr.HasRows)
            {
                //(09/10/2019 - fgomes) Enquanto tiver linha, faça.
                while (objDtr.Read())
                {
                    //(09/10/2019 - fgomes) Estanciei o Objeto Trabalho
                    Trabalho aobjTrabalho = new Trabalho();

                    aobjTrabalho.COD_TRABALHO = Convert.ToInt16(objDtr["I_COD_TRABALHO"]);
                    aobjTrabalho.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                    aobjTrabalho.COD_CACHORRO = Convert.ToInt16(objDtr["I_COD_CACHORRO"]);
                    aobjTrabalho.COD_SERVICO = Convert.ToInt16(objDtr["I_COD_SERVICO"]);
                    aobjTrabalho.DATA_TRABALHO = Convert.ToDateTime(objDtr["DT_DATA_TRABALHO"]);
                    aobjTrabalho.HR_TRABALHO = Convert.ToDateTime(objDtr["DT_HR_TRABALHO"]);

                    lista.Add(aobjTrabalho);

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
        * NOME          :  FindByCodTrabalho          
        * METODO        :  Responsável por encontar o registros que está 
        *                  na tabela TB_TRABALHO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Trabalho
        * RETORNO       :  Classe Trabalho
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public Trabalho FindByCodTrabalho(Trabalho aobjTrabalho)
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "SELECT * FROM TB_TRABALHO " +
                            "WHERE I_COD_TRABALHO = @I_COD_TRABALHO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_TRABALHO", aobjTrabalho.COD_TRABALHO);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();

            if (objDtr.HasRows)
            {
                objDtr.Read();
                //(09/10/2019 - fgomes) Estanciei o Objeto Trabalho

                aobjTrabalho.COD_TRABALHO = Convert.ToInt16(objDtr["I_COD_TRABALHO"]);
                aobjTrabalho.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                aobjTrabalho.COD_CACHORRO = Convert.ToInt16(objDtr["I_COD_CACHORRO"]);
                aobjTrabalho.COD_SERVICO = Convert.ToInt16(objDtr["I_COD_SERVICO"]);
                aobjTrabalho.DATA_TRABALHO = Convert.ToDateTime(objDtr["DT_DATA_TRABALHO"]);
                aobjTrabalho.HR_TRABALHO = Convert.ToDateTime(objDtr["DT_HR_TRABALHO"]);

                objCon.Close();
                objDtr.Close();
                return aobjTrabalho;
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