/**********************************************************************************
 * NOME:            Dono
 * CLASSE:          Representação da entidade Dono 
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
    class Dono
    {
        //(fgomes - 07/10/2019) Metodo de Destruição da Classe
        ~Dono()
        {
        }

        //(fgomes - 07/10/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Dono = -1;
        private string vnm_Dono = null;
        private string vende_Dono = null;
        private string vbai_Dono = null;
        private string vcid_Dono = null;
        private string vuf_Dono = null;
        private string vcep_Dono = null;
        private string vcel_Dono = null;
        private string vemail_Dono = null;
        private DateTime vnasc_Dono = DateTime.MinValue;

        //(fgomes - 07/10/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public int COD_DONO
        {
            get { return vcod_Dono; }
            set { vcod_Dono = value; }
        }

        /***********************************************************************
        * NOME:            NM_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string NM_DONO
        {
            get { return vnm_Dono; }
            set { vnm_Dono = value; }
        }

        /***********************************************************************
        * NOME:            ENDE_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        **********************************************************************/
        public string ENDE_DONO
        {
            get { return vende_Dono; }
            set { vende_Dono = value; }
        }

        /***********************************************************************
        * NOME:            BAI_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string BAI_DONO
        {
            get { return vbai_Dono; }
            set { vbai_Dono = value; }
        }

        /***********************************************************************
        * NOME:            CID_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    fgomes 
        **********************************************************************/
        public string CID_DONO
        {
            get { return vcid_Dono; }
            set { vcid_Dono = value; }
        }

        /***********************************************************************
        * NOME:            UF_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        **********************************************************************/
        public string UF_DONO
        {
            get { return vuf_Dono; }
            set { vuf_Dono = value; }
        }

        /***********************************************************************
        * NOME:            CEP_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string CEP_DONO
        {
            get { return vcep_Dono; }
            set { vcep_Dono = value; }
        }

        /***********************************************************************
        * NOME:            CEL_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    fgomes 
        **********************************************************************/
        public string CEL_DONO
        {
            get { return vcel_Dono; }
            set { vcel_Dono = value; }
        }

        /***********************************************************************
        * NOME:            EMAIL_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string EMAIL_DONO
        {
            get { return vemail_Dono; }
            set { vemail_Dono = value; }
        }

        /***********************************************************************
        * NOME:            NASC_DONO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public DateTime NASC_DONO
        {
            get { return vnasc_Dono; }
            set { vnasc_Dono = value; }
        }

    }
}
