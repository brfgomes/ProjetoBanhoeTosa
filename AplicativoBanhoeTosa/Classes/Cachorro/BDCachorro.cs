 /**********************************************************************************
 * NOME:            BDCachorro
 * CLASSE:          Representação da classe de banco de dados Cachorro
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
    class BDCachorro
    {
        //Destructor da Classe
        ~BDCachorro()
        {
        }

        /***********************************************************************
        * NOME          :  Incluir          
        * METODO        :  Responsável por incluir o registro na tabela.
        *                  Inclui um registro na tabela TB_CACHORRO         
        * DT CRIAÇÃO    :  16/09/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Cachorro 
        * RETORNO       :  Código do último registro na TB_CACHORRO ou -1 
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public int Incluir(Cachorro aobjCachorro)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "INSERT INTO TB_CACHORRO" +
                            "(" +
                            "I_COD_DONO, " +
                            "S_NM_CACHORRO, " +
                            "S_TMN_CACHORRO, " +
                            "S_IDADE_CACHORRO, " +
                            "S_RACA_CACHORRO, " +
                            "S_DOEN_CACHORRO, " +
                            "S_GEN_CACHORRO, " +
                            "S_CURIO_CACHORRO " +
                            ")" +
                            "VALUES " +
                            "(" +
                            "@I_COD_DONO, " +
                            "@S_NM_CACHORRO, " +
                            "@S_TMN_CACHORRO, " +
                            "@S_IDADE_CACHORRO, " +
                            "@S_RACA_CACHORRO, " +
                            "@S_DOEN_CACHORRO, " +
                            "@S_GEN_CACHORRO, " +
                            "@S_CURIO_CACHORRO " +
                            ");" +
                            "SELECT IDENT_CURRENT('TB_CACHORRO') AS 'id'";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjCachorro.COD_DONO);
            objCmd.Parameters.AddWithValue("@S_NM_CACHORRO", aobjCachorro.NM_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_TMN_CACHORRO", aobjCachorro.TMN_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_IDADE_CACHORRO", aobjCachorro.IDADE_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_RACA_CACHORRO", aobjCachorro.RACA_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_DOEN_CACHORRO", aobjCachorro.DOEN_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_GEN_CACHORRO", aobjCachorro.GEN_CACHORRO);
            objCmd.Parameters.AddWithValue("@S_CURIO_CACHORRO", aobjCachorro.CURIO_CACHORRO);

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
        * METODO        :  Responsável por Alterar o registro na tabela TB_CACHORRO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Cachorro 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Alterar(Cachorro aobjCachorro)
        {
            if (aobjCachorro.COD_CACHORRO != -1)
            {
                //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                string varSql = "UPDATE TB_CACHORRO SET " +
                                "I_COD_DONO    = @I_COD_DONO   ," +
                                "S_NM_CACHORRO  = @S_NM_CACHORRO ," +
                                "S_TMN_CACHORRO   = @S_TMN_CACHORRO  ," +
                                "S_IDADE_CACHORRO   = @S_IDADE_CACHORRO  ," +
                                "S_RACA_CACHORRO    = @S_RACA_CACHORRO   ," +
                                "S_DOEN_CACHORRO   = @S_DOEN_CACHORRO  ," +
                                "S_GEN_CACHORRO   = @S_GEN_CACHORRO  ," +
                                "S_CURIO_CACHORRO = @S_CURIO_CACHORRO " +
                                "WHERE I_COD_CACHORRO = @I_COD_CACHORRO";

                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_CACHORRO", aobjCachorro.COD_CACHORRO);
                objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjCachorro.COD_DONO);
                objCmd.Parameters.AddWithValue("@S_NM_CACHORRO", aobjCachorro.NM_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_TMN_CACHORRO", aobjCachorro.TMN_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_IDADE_CACHORRO", aobjCachorro.IDADE_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_RACA_CACHORRO", aobjCachorro.RACA_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_DOEN_CACHORRO", aobjCachorro.DOEN_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_GEN_CACHORRO", aobjCachorro.GEN_CACHORRO);
                objCmd.Parameters.AddWithValue("@S_CURIO_CACHORRO", aobjCachorro.CURIO_CACHORRO);

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
        * METODO        :  Responsável por excluir o registro na tabela TB_CACHORRO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Cachorro 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Excluir(Cachorro aobjCachorro)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "DELETE FROM TB_CACHORRO " +
                            "WHERE I_COD_CACHORRO = @I_COD_CACHORRO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_CACHORRO", aobjCachorro.COD_CACHORRO);

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
        *                  na tabela TB_CACHORRO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  -
        * RETORNO       :  Lista de Cachorros
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public List<Cachorro> FindAllCachorro()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = "SELECT * FROM TB_CACHORRO";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();
            List<Cachorro> lista = new List<Cachorro>();

            if (objDtr.HasRows)
            {
                //(09/10/2019 - fgomes) Enquanto tiver linha, faça.
                while (objDtr.Read())
                {
                    //(09/10/2019 - fgomes) Estanciei o Objeto Cachorro
                    Cachorro aobjCachorro = new Cachorro();

                    aobjCachorro.COD_CACHORRO = Convert.ToInt16(objDtr["I_COD_CACHORRO"]);
                    aobjCachorro.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                    aobjCachorro.NM_CACHORRO = objDtr["S_NM_CACHORRO"].ToString();
                    aobjCachorro.TMN_CACHORRO = objDtr["S_TMN_CACHORRO"].ToString();
                    aobjCachorro.IDADE_CACHORRO = objDtr["S_IDADE_CACHORRO"].ToString();
                    aobjCachorro.RACA_CACHORRO = objDtr["S_RACA_CACHORRO"].ToString();
                    aobjCachorro.DOEN_CACHORRO = objDtr["S_DOEN_CACHORRO"].ToString();
                    aobjCachorro.GEN_CACHORRO = objDtr["S_GEN_CACHORRO"].ToString();
                    aobjCachorro.CURIO_CACHORRO = objDtr["S_CURIO_CACHORRO"].ToString();

                    lista.Add(aobjCachorro);

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
        * NOME          :  FindByCodCachorro          
        * METODO        :  Responsável por encontar o registros que está 
        *                  na tabela TB_CACHORRO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Cachorro
        * RETORNO       :  Classe Cachorro
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public Cachorro FindByCodCachorro(Cachorro aobjCachorro)
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "SELECT * FROM TB_CACHORRO " +
                            "WHERE I_COD_CACHORRO = @I_COD_CACHORRO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_CACHORRO", aobjCachorro.COD_CACHORRO);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();

            if (objDtr.HasRows)
            {
                objDtr.Read();
                //(09/10/2019 - fgomes) Estanciei o Objeto Cachorro
                aobjCachorro.COD_CACHORRO = Convert.ToInt16(objDtr["I_COD_CACHORRO"]);
                aobjCachorro.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                aobjCachorro.NM_CACHORRO = objDtr["S_NM_CACHORRO"].ToString();
                aobjCachorro.TMN_CACHORRO = objDtr["S_TMN_CACHORRO"].ToString();
                aobjCachorro.IDADE_CACHORRO = objDtr["S_IDADE_CACHORRO"].ToString();
                aobjCachorro.RACA_CACHORRO = objDtr["S_RACA_CACHORRO"].ToString();
                aobjCachorro.DOEN_CACHORRO = objDtr["S_DOEN_CACHORRO"].ToString();
                aobjCachorro.GEN_CACHORRO = objDtr["S_GEN_CACHORRO"].ToString();
                aobjCachorro.CURIO_CACHORRO = objDtr["S_CURIO_CACHORRO"].ToString();

                objCon.Close();
                objDtr.Close();
                return aobjCachorro;
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