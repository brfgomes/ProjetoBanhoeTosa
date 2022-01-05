/**********************************************************************************
 * NOME:            Cachorro
 * CLASSE:          Representação da entidade Cachorro 
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
    class Cachorro
    {
        //(fgomes - 07/10/2019) Metodo de Destruição da Classe
        ~Cachorro()
        {
        }

        //(fgomes - 07/10/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Cachorro = -1;
        private int vcod_Dono = -1;
        private string vnm_Cachorro = null;
        private string vtmn_Cachorro = null;
        private string vidade_Cachorro = null;
        private string vraca_Cachorro = null;
        private string vdoen_Cachorro = null;
        private string vgen_Cachorro = null;
        private string vcurio_Cachorro = null;

        //(fgomes - 07/10/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public int COD_CACHORRO
        {
            get { return vcod_Cachorro; }
            set { vcod_Cachorro = value; }
        }

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
        * NOME:            NM_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string NM_CACHORRO
        {
            get { return vnm_Cachorro; }
            set { vnm_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            TMN_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        **********************************************************************/
        public string TMN_CACHORRO
        {
            get { return vtmn_Cachorro; }
            set { vtmn_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            IDADE_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string IDADE_CACHORRO
        {
            get { return vidade_Cachorro; }
            set { vidade_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            RACA_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    fgomes 
        **********************************************************************/
        public string RACA_CACHORRO
        {
            get { return vraca_Cachorro; }
            set { vraca_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            DOEN_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        **********************************************************************/
        public string DOEN_CACHORRO
        {
            get { return vdoen_Cachorro; }
            set { vdoen_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            GEN_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public string GEN_CACHORRO
        {
            get { return vgen_Cachorro; }
            set { vgen_Cachorro = value; }
        }

        /***********************************************************************
        * NOME:            CURIO_CACHORRO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    fgomes 
        **********************************************************************/
        public string CURIO_CACHORRO
        {
            get { return vcurio_Cachorro; }
            set { vcurio_Cachorro = value; }
        }

    }
}
