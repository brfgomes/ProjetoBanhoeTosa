/**********************************************************************************
 * NOME:            Servico
 * CLASSE:          Representação da entds Servico 
 * DT CRIAÇÃO:      07/10/2019
 * DT ALTERAÇÃO:    -
 * ESCRITA POR:     fgomes
 * OBSERVAÇÕES:     Atributos privados com métodos Get e Set públicos
 * ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoBanhoeTosa
{
    class Servico
    {
        //(fgomes - 07/10/2019) Metodo de Destruição da Classe
        ~Servico()
        {
        }

        //(fgomes - 07/10/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Servico = -1;
        private string vnm_Servico = null;
        private string vvlr_Servico = null;
        private string vds_Servico = null;
        private string vdura_Servico = null;

        //(fgomes - 07/10/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_SERVICO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public int COD_SERVICO
        {
            get { return vcod_Servico; }
            set { vcod_Servico = value; }
        }

        /***********************************************************************
        * NOME:            NM_SERVICO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string NM_SERVICO
        {
            get { return vnm_Servico; }
            set { vnm_Servico = value; }
        }

        /***********************************************************************
        * NOME:            VLR_SERVICO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        **********************************************************************/
        public string VLR_SERVICO
        {
            get { return vvlr_Servico; }
            set { vvlr_Servico = value; }
        }

        /***********************************************************************
        * NOME:            DS_SERVICO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string DS_SERVICO
        {
            get { return vds_Servico; }
            set { vds_Servico = value; }
        }

        /***********************************************************************
        * NOME:            DURA_SERVICO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string DURA_SERVICO
        {
            get { return vdura_Servico; }

            set { vdura_Servico = value; }
        }

    }
}
