/*****************************************************************
 * NOME:            CONNECTION
 * CLASSE:          REPRESENTAÇÃO DA CLASSE DE CONEXÃO
 * DT CRIAÇÃO:      09/10/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     fgomes
 * OBSERVAÇÕES:     CLASSE RESPONSÁVEL PELA CONEXÃO COM O BANCO
 *                  DE DADOS ATRAVÉS DE UM PATH.
 *****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBanhoeTosa
{
    class Connection
    {
        //Metodo da Classe de conexão que retorna o caminho do banco de dados
        public static string ConnectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName=C:\Users\Bruno\Documents\Nova pasta\AplicativoBanhoeTosa\AplicativoBanhoeTosa\BD_BanhoeTosa.mdf;Integrated Security=True; Connect Timeout = 30";
        }
    }
}
