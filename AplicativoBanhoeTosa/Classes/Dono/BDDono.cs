/**********************************************************************************
 * NOME:            BDDono
 * CLASSE:          Representação da classe de banco de dados Dono
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
    class BDDono
    {
        //Destructor da Classe
        ~BDDono()
        {
        }

        /***********************************************************************
        * NOME          :  Incluir          
        * METODO        :  Responsável por incluir o registro na tabela.
        *                  Inclui um registro na tabela TB_DONO         
        * DT CRIAÇÃO    :  16/09/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Dono 
        * RETORNO       :  Código do último registro na TB_DONO ou -1 
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public int Incluir(Dono aobjDono)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "INSERT INTO TB_DONO " +
                            "(" +
                            "S_NM_DONO, " +
                            "S_ENDE_DONO, " +
                            "S_BAI_DONO, " +
                            "S_CID_DONO, " +
                            "S_UF_DONO, " +
                            "S_CEP_DONO, " +
                            "S_CEL_DONO, " +
                            "S_EMAIL_DONO, " +
                            "DT_NASC_DONO " +
                            ")" +
                            "VALUES " +
                            "(" +
                            "@S_NM_DONO, " +
                            "@S_ENDE_DONO, " +
                            "@S_BAI_DONO, " +
                            "@S_CID_DONO, " +
                            "@S_UF_DONO, " +
                            "@S_CEP_DONO, " +
                            "@S_CEL_DONO, " +
                            "@S_EMAIL_DONO, " +
                            "@DT_NASC_DONO " +
                            ");" +
                            "SELECT IDENT_CURRENT('TB_DONO') AS 'id'";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@S_NM_DONO", aobjDono.NM_DONO);
            objCmd.Parameters.AddWithValue("@S_ENDE_DONO", aobjDono.ENDE_DONO);
            objCmd.Parameters.AddWithValue("@S_BAI_DONO", aobjDono.BAI_DONO);
            objCmd.Parameters.AddWithValue("@S_CID_DONO", aobjDono.CID_DONO);
            objCmd.Parameters.AddWithValue("@S_UF_DONO", aobjDono.UF_DONO);
            objCmd.Parameters.AddWithValue("@S_CEP_DONO", aobjDono.CEP_DONO);
            objCmd.Parameters.AddWithValue("@S_CEL_DONO", aobjDono.CEL_DONO);
            objCmd.Parameters.AddWithValue("@S_EMAIL_DONO", aobjDono.EMAIL_DONO);
            objCmd.Parameters.AddWithValue("@DT_NASC_DONO", aobjDono.NASC_DONO);

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
        * METODO        :  Responsável por Alterar o registro na tabela TB_DONO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Dono 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Alterar(Dono aobjDono)
        {
            if (aobjDono.COD_DONO != -1)
            {
                //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
                SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

                string varSql = "UPDATE TB_DONO SET " +
                                "S_NM_DONO = @S_NM_DONO, " +
                                "S_ENDE_DONO = @S_ENDE_DONO, " +
                                "S_BAI_DONO = @S_BAI_DONO, " +
                                "S_CID_DONO = @S_CID_DONO, " +
                                "S_UF_DONO = @S_UF_DONO, " +
                                "S_CEP_DONO = @S_CEP_DONO, " +
                                "S_CEL_DONO = @S_CEL_DONO, " +
                                "S_EMAIL_DONO = @S_EMAIL_DONO, " +
                                "DT_NASC_DONO = @DT_NASC_DONO " +
                                "WHERE I_COD_DONO = @I_COD_DONO";

                SqlCommand objCmd = new SqlCommand(varSql, objCon);
                objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjDono.COD_DONO);
                objCmd.Parameters.AddWithValue("@S_NM_DONO", aobjDono.NM_DONO);
                objCmd.Parameters.AddWithValue("@S_ENDE_DONO", aobjDono.ENDE_DONO);
                objCmd.Parameters.AddWithValue("@S_BAI_DONO", aobjDono.BAI_DONO);
                objCmd.Parameters.AddWithValue("@S_CID_DONO", aobjDono.CID_DONO);
                objCmd.Parameters.AddWithValue("@S_UF_DONO", aobjDono.UF_DONO);
                objCmd.Parameters.AddWithValue("@S_CEP_DONO", aobjDono.CEP_DONO);
                objCmd.Parameters.AddWithValue("@S_CEL_DONO", aobjDono.CEL_DONO);
                objCmd.Parameters.AddWithValue("@S_EMAIL_DONO", aobjDono.EMAIL_DONO);
                objCmd.Parameters.AddWithValue("@DT_NASC_DONO", aobjDono.NASC_DONO);

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
        * METODO        :  Responsável por excluir o registro na tabela TB_DONO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Dono 
        * RETORNO       :  True ou False
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public bool Excluir(Dono aobjDono)
        {
            //(09/10/2019 - fgomes) Estancia a classe Conection para acesso ao banco de dados
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "DELETE FROM TB_DONO " +
                            "WHERE I_COD_DONO = @I_COD_DONO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjDono.COD_DONO);

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
        *                  na tabela TB_DONO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  -
        * RETORNO       :  Lista de Donos
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public List<Dono> FindAllDono()
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());
            string varSql = "SELECT * FROM TB_DONO";
            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();
            List<Dono> lista = new List<Dono>();

            if (objDtr.HasRows)
            {
                //(09/10/2019 - fgomes) Enquanto tiver linha, faça.
                while (objDtr.Read())
                {
                    //(09/10/2019 - fgomes) Estanciei o Objeto Dono
                    Dono aobjDono = new Dono();

                    aobjDono.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                    aobjDono.NM_DONO = objDtr["S_NM_DONO"].ToString();
                    aobjDono.ENDE_DONO = objDtr["S_ENDE_DONO"].ToString();
                    aobjDono.BAI_DONO = objDtr["S_BAI_DONO"].ToString();
                    aobjDono.CID_DONO = objDtr["S_CID_DONO"].ToString();
                    aobjDono.UF_DONO = objDtr["S_UF_DONO"].ToString();
                    aobjDono.CEP_DONO = objDtr["S_CEP_DONO"].ToString();
                    aobjDono.CEL_DONO = objDtr["S_CEL_DONO"].ToString();
                    aobjDono.EMAIL_DONO = objDtr["S_EMAIL_DONO"].ToString();
                    aobjDono.NASC_DONO = Convert.ToDateTime(objDtr["DT_NASC_DONO"]);

                    lista.Add(aobjDono);

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
        * NOME          :  FindByCodDono          
        * METODO        :  Responsável por encontar o registros que está 
        *                  na tabela TB_DONO         
        * DT CRIAÇÃO    :  09/10/2019    
        * DT ALTERAÇÃO  :  -
        * PARAMETRO     :  Classe Dono
        * RETORNO       :  Classe Dono
        * ESCRITA POR   :  fgomes 
        * OBSERVAÇÕES   :  Utiliza a Classe Connection para acessar o BD.   
        **********************************************************************/
        public Dono FindByCodDono(Dono aobjDono)
        {
            SqlConnection objCon = new SqlConnection(Connection.ConnectionPath());

            string varSql = "SELECT * FROM TB_DONO " +
                            "WHERE I_COD_DONO = @I_COD_DONO";

            SqlCommand objCmd = new SqlCommand(varSql, objCon);

            objCmd.Parameters.AddWithValue("@I_COD_DONO", aobjDono.COD_DONO);

            objCon.Open();

            SqlDataReader objDtr = objCmd.ExecuteReader();

            if (objDtr.HasRows)
            {
                objDtr.Read();
                //(09/10/2019 - fgomes) Estanciei o Objeto Dono
                aobjDono.COD_DONO = Convert.ToInt16(objDtr["I_COD_DONO"]);
                aobjDono.NM_DONO = objDtr["S_NM_DONO"].ToString();
                aobjDono.ENDE_DONO = objDtr["S_ENDE_DONO"].ToString();
                aobjDono.BAI_DONO = objDtr["S_BAI_DONO"].ToString();
                aobjDono.CID_DONO = objDtr["S_CID_DONO"].ToString();
                aobjDono.UF_DONO = objDtr["S_UF_DONO"].ToString();
                aobjDono.CEP_DONO = objDtr["S_CEP_DONO"].ToString();
                aobjDono.CEL_DONO = objDtr["S_CEL_DONO"].ToString();
                aobjDono.EMAIL_DONO = objDtr["S_EMAIL_DONO"].ToString();
                aobjDono.NASC_DONO = Convert.ToDateTime(objDtr["DT_NASC_DONO"]);

                objCon.Close();
                objDtr.Close();
                return aobjDono;
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