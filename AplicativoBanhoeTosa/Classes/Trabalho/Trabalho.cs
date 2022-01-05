/**********************************************************************************
 * NOME:            Trabalho
 * CLASSE:          Representação da entidade Trabalho 
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
    class Trabalho
    {
        //(fgomes - 07/10/2019) Metodo de Destruição da Classe
        ~Trabalho()
        {
        }

        //(fgomes - 07/10/2019) Atributos/Propriedades Privadas Encapsuladas
        private int vcod_Trabalho = -1;
        private int vcod_Dono = -1;
        private int vcod_Cachorro = -1;
        private int vcod_Servico = -1;
        private DateTime vdata_Trabalho = DateTime.MinValue;
        private DateTime vhr_Trabalho = DateTime.MinValue;

        //(fgomes - 07/10/2019) Metodos/Ações Publicas

        /***********************************************************************
        * NOME:            COD_TRABALHO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public int COD_TRABALHO
        {
            get { return vcod_Trabalho; }
            set { vcod_Trabalho = value; }
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
        * NOME:            DATA_TRABALHO       
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes 
        **********************************************************************/
        public DateTime DATA_TRABALHO
        {
            get { return vdata_Trabalho; }
            set { vdata_Trabalho = value; }
        }

        /***********************************************************************
        * NOME:            HR_TRABALHO     
        * METODO:          Representação do atributo Código com os métodos 
        *                  Get e Set          
        * DT CRIAÇÃO:      07/10/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:    fgomes 
        **********************************************************************/
        public DateTime HR_TRABALHO
        {
            get { return vhr_Trabalho; }
            set { vhr_Trabalho = value; }
        }


    }
}
