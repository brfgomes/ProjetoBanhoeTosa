using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoBanhoeTosa
{
    public partial class frm_Servico : Form
    {
        FuncGeral obj_FGeral = new FuncGeral();

        Servico Servico_Principal = new Servico();

        public frm_Servico()
        {
            InitializeComponent();
            PopulaLista();
            obj_FGeral.HabilitaTela(this, false);
            if (lbox_Servicos.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }
        }

        /**********************************************************************************
        * NOME:            PopulaLista
        * CLASSE:          Preenche a ListBox (lbox_Servicos) com os dados 
        *                  cadastrados na TB_servico
        * DT CRIAÇÃO:      21/10/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            BDServico obj_BDServico = new BDServico();
            List<Servico> Lista = new List<Servico>();

            lbox_Servicos.Items.Clear();

            Lista = obj_BDServico.FindAllServico();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Servicos.Items.Add(Convert.ToString(Lista[i].COD_SERVICO) + "-" + Lista[i].NM_SERVICO);
                }
            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * CLASSE:          Preenche os TextBox com os dados do SERVICO_PRINCIPAL
        * DT CRIAÇÃO:      21/10/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     Passar o parametro Servico para o Procedimento
        * ********************************************************************************/
        private void PopulaTela(Servico aobj_Servico)
        {
            if (aobj_Servico.COD_SERVICO != -1)
            {
                tbox_Cod_Servico.Text = Convert.ToString(aobj_Servico.COD_SERVICO);
            }
            tbox_Nm_Servico.Text = aobj_Servico.NM_SERVICO;
            tbox_Vlr_Servico.Text = aobj_Servico.VLR_SERVICO;
            tbox_Ds_Servico.Text = aobj_Servico.DS_SERVICO;
            tbox_Dura_Servico.Text = aobj_Servico.DURA_SERVICO;


        }

        /**********************************************************************************
        * NOME:            PopulaObjeto
        * CLASSE:          Preenche o objeto SERVICO_PRINCIPAL com os dados da Tela (TextBox´s)
        * DT CRIAÇÃO:      21/10/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Servico PopulaObjeto()
        {
            Servico aobj_Servico = new Servico();

            if (tbox_Cod_Servico.Text != "")
            {
                aobj_Servico.COD_SERVICO = Convert.ToInt16(tbox_Cod_Servico.Text);
            }
            aobj_Servico.NM_SERVICO = tbox_Nm_Servico.Text;
            aobj_Servico.VLR_SERVICO = tbox_Vlr_Servico.Text;
            aobj_Servico.DS_SERVICO = tbox_Ds_Servico.Text;
            aobj_Servico.DURA_SERVICO = tbox_Dura_Servico.Text;


            return aobj_Servico;
        }

        private void lbox_Servicos_DoubleClick(object sender, EventArgs e)
        {
            BDServico aobj_BDServico = new BDServico();
            string slinha = lbox_Servicos.Items[lbox_Servicos.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Servico_Principal.COD_SERVICO = Convert.ToInt16(slinha.Substring(0, ipos));
            Servico_Principal = aobj_BDServico.FindByCodServico(Servico_Principal);
            PopulaTela(Servico_Principal);
        }
        //BTN NOVO
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FGeral.HabilitaTela(this, true);
            obj_FGeral.LimpaTela(this);
            tbox_Nm_Servico.Focus();

            obj_FGeral.StatusBtn(this, 2);
        }
        //BTN ALTERAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Servico.Text != "")
            {
                obj_FGeral.HabilitaTela(this, true);
                tbox_Nm_Servico.Focus();
                obj_FGeral.StatusBtn(this, 2);
            }
            else
            {
                MessageBox.Show("Meu caro Egnóbio, selecione com um DuploClick, algum genero da lista antes de opcionar Alterar.", "AÇÃO INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // BTN EXCLUIR
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão deste Serviço?", "EXCLUSÃO DO SERVIÇO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {

                BDServico obj_BDServico = new BDServico();
                Servico_Principal = PopulaObjeto();

                if (obj_BDServico.Excluir(Servico_Principal))
                {
                    MessageBox.Show("Serviço excluido com sucesso.", "EXCLUSÃO DO SERVIÇO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FGeral.LimpaTela(this);
                obj_FGeral.HabilitaTela(this, false);
                PopulaLista();

                if (lbox_Servicos.Items.Count > 0)
                {
                    obj_FGeral.StatusBtn(this, 1);
                }
                else
                {
                    obj_FGeral.StatusBtn(this, 0);
                }

            }
        }
        //BTN CONFIRMAR
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            BDServico obj_BDServico = new BDServico();

            Servico_Principal = PopulaObjeto();

            if (Servico_Principal.COD_SERVICO != -1)
            {
                if (obj_BDServico.Alterar(Servico_Principal))
                {
                    MessageBox.Show("Serviço alterado com sucesso.", "ALTERAÇÃO DO SERVIÇO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                tbox_Cod_Servico.Text = obj_BDServico.Incluir(Servico_Principal).ToString();
                if (tbox_Cod_Servico.Text != "-1")
                {
                    MessageBox.Show("Serviço incluido com sucesso.", "INCLUSÃO DO SERVIÇO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbox_Cod_Servico.Text = "";
                }
            }

            obj_FGeral.HabilitaTela(this, false);
            PopulaLista();

            if (lbox_Servicos.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }

        }
        //BTN CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            PopulaTela(Servico_Principal);
            obj_FGeral.HabilitaTela(this, false);

            if (lbox_Servicos.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }
        }

        private void lbox_Servicos_MouseClick(object sender, MouseEventArgs e)
        {
            BDServico aobj_BDServico = new BDServico();
            string slinha = lbox_Servicos.Items[lbox_Servicos.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Servico_Principal.COD_SERVICO = Convert.ToInt16(slinha.Substring(0, ipos));
            Servico_Principal = aobj_BDServico.FindByCodServico(Servico_Principal);
            PopulaTela(Servico_Principal);
        }
    }
}
