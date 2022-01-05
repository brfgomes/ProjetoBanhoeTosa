
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
    public partial class frm_Trabalho : Form
    {
        FuncGeral obj_FGeral = new FuncGeral();

        Trabalho Trabalho_Principal = new Trabalho();

        public frm_Trabalho()
        {
            InitializeComponent();
            PopulaLista();
            obj_FGeral.HabilitaTela(this, false);
            if (lbox_Trabalhos.Items.Count > 0)
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
        * CLASSE:          Preenche a ListBox (lbox_Trabalhos) com os dados 
        *                  cadastrados na TB_TRABALHO
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Monstro (mFacine)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            BDTrabalho obj_BDTrabalho = new BDTrabalho();
            List<Trabalho> Lista = new List<Trabalho>();

            lbox_Trabalhos.Items.Clear();

            Lista = obj_BDTrabalho.FindAllTrabalho();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Trabalhos.Items.Add(Convert.ToString(Lista[i].COD_TRABALHO) + "-" + Lista[i].DATA_TRABALHO);
                }
            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * CLASSE:          Preenche os TextBox com os dados do TRABALHO_PRINCIPAL
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Monstro (mFacine)
        * OBSERVAÇÕES:     Passar o parametro Trabalho para o Procedimento
        * ********************************************************************************/
        private void PopulaTela(Trabalho aobj_Trabalho)
        {
            if (aobj_Trabalho.COD_TRABALHO != -1)
            {
                tbox_Cod_Trabalho.Text = Convert.ToString(aobj_Trabalho.COD_TRABALHO);
            }
            tbox_Cod_Dono.Text = Convert.ToString(aobj_Trabalho.COD_DONO);
            lb_Nm_Dono.Text = obj_FGeral.PopulaLabels(tbox_Cod_Dono.Text, 1);

            tbox_Cod_Cachorro.Text = Convert.ToString(aobj_Trabalho.COD_CACHORRO);
            lb_Nm_Cachorro.Text = obj_FGeral.PopulaLabels(tbox_Cod_Cachorro.Text, 2);

            tbox_Cod_Servico.Text = Convert.ToString(aobj_Trabalho.COD_SERVICO);
            lb_Nm_Servico.Text = obj_FGeral.PopulaLabels(tbox_Cod_Servico.Text, 3);

            tbox_Data_Trabalho.Text = aobj_Trabalho.DATA_TRABALHO.ToString("dd/MM/yyyy");  
            tbox_Hr_Trabalho.Text = aobj_Trabalho.HR_TRABALHO.ToString("HH:mm:ss");


        }

        /**********************************************************************************
        * NOME:            PopulaObjeto
        * CLASSE:          Preenche o objeto TRABALHO_PRINCIPAL com os dados da Tela (TextBox´s)
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Monstro (mFacine)
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Trabalho PopulaObjeto()
        {
            Trabalho aobj_Trabalho = new Trabalho();

            if (tbox_Cod_Trabalho.Text != "")
            {
                aobj_Trabalho.COD_TRABALHO = Convert.ToInt16(tbox_Cod_Trabalho.Text);
            }

            aobj_Trabalho.COD_DONO = Convert.ToInt16(tbox_Cod_Dono.Text);
            aobj_Trabalho.COD_CACHORRO = Convert.ToInt16(tbox_Cod_Cachorro.Text);
            aobj_Trabalho.COD_SERVICO = Convert.ToInt16(tbox_Cod_Servico.Text);
            aobj_Trabalho.DATA_TRABALHO = Convert.ToDateTime(tbox_Data_Trabalho.Text);
            aobj_Trabalho.HR_TRABALHO = Convert.ToDateTime(tbox_Hr_Trabalho.Text);

            return aobj_Trabalho;
        }

        private void lbox_Trabalhos_DoubleClick(object sender, EventArgs e)
        {
            BDTrabalho aobj_BDTrabalho = new BDTrabalho();
            string slinha = lbox_Trabalhos.Items[lbox_Trabalhos.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Trabalho_Principal.COD_TRABALHO = Convert.ToInt16(slinha.Substring(0, ipos));
            Trabalho_Principal = aobj_BDTrabalho.FindByCodTrabalho(Trabalho_Principal);
            PopulaTela(Trabalho_Principal);
        }




        private void btn_Dono_Click(object sender, EventArgs e)
        {
            frm_Dono objfrm_Dono = new frm_Dono();
            objfrm_Dono.ShowDialog();
        }

        private void btn_Cachorro_Click(object sender, EventArgs e)
        {
            frm_Cachorro objfrm_Cachorro = new frm_Cachorro();
            objfrm_Cachorro.ShowDialog();
        }

        private void btn_Servico_Click(object sender, EventArgs e)
        {
            frm_Servico objfrm_Servico = new frm_Servico();
            objfrm_Servico.ShowDialog();
        }



        private void tbox_Cod_Dono_Leave(object sender, EventArgs e)
        {
            lb_Nm_Dono.Text = obj_FGeral.PopulaLabels(tbox_Cod_Dono.Text, 1);
        }

        private void tbox_Cod_Cachorro_Leave(object sender, EventArgs e)
        {
            lb_Nm_Cachorro.Text = obj_FGeral.PopulaLabels(tbox_Cod_Cachorro.Text, 2);
        }

        private void tbox_Cod_Servico_Leave(object sender, EventArgs e)
        {
            lb_Nm_Servico.Text = obj_FGeral.PopulaLabels(tbox_Cod_Servico.Text, 3);
        }
        private void btn_Autor_Click(object sender, EventArgs e)
        {

        }

        private void lb_Nm_Autor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Nm_Editora_Click(object sender, EventArgs e)
        {

        }
        //BTN NOVO
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FGeral.HabilitaTela(this, true);
            obj_FGeral.LimpaTela(this);
            tbox_Data_Trabalho.Focus();

            obj_FGeral.StatusBtn(this, 2);
        }
        //BTN ALTERAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Trabalho.Text != "")
            {
                obj_FGeral.HabilitaTela(this, true);
                tbox_Data_Trabalho.Focus();
                obj_FGeral.StatusBtn(this, 2);
            }
            else
            {
                MessageBox.Show("Meu caro Egnóbio, selecione com um DuploClick, algum genero da lista antes de opcionar Alterar.", "AÇÃO INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //BTN EXCLUIR
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão deste Trabalho?", "EXCLUSÃO DO TRABALHO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {

                BDTrabalho obj_BDTrabalho = new BDTrabalho();
                Trabalho_Principal = PopulaObjeto();

                if (obj_BDTrabalho.Excluir(Trabalho_Principal))
                {
                    MessageBox.Show("Trabalho excluido com sucesso.", "EXCLUSÃO DO TRABALHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FGeral.LimpaTela(this);
                obj_FGeral.HabilitaTela(this, false);
                PopulaLista();

                if (lbox_Trabalhos.Items.Count > 0)
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
            BDTrabalho obj_BDTrabalho = new BDTrabalho();

            Trabalho_Principal = PopulaObjeto();

            if (Trabalho_Principal.COD_TRABALHO != -1)
            {
                if (obj_BDTrabalho.Alterar(Trabalho_Principal))
                {
                    MessageBox.Show("Trabalho alterado com sucesso.", "ALTERAÇÃO DO TRABALHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                tbox_Cod_Trabalho.Text = obj_BDTrabalho.Incluir(Trabalho_Principal).ToString();
                if (tbox_Cod_Trabalho.Text != "-1")
                {
                    MessageBox.Show("Trabalho incluido com sucesso.", "INCLUSÃO DO TRABALHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbox_Cod_Trabalho.Text = "";
                }
            }

            obj_FGeral.HabilitaTela(this, false);
            PopulaLista();

            if (lbox_Trabalhos.Items.Count > 0)
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
            PopulaTela(Trabalho_Principal);
            obj_FGeral.HabilitaTela(this, false);

            if (lbox_Trabalhos.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }

        }

        private void lbox_Trabalhos_Click(object sender, EventArgs e)
        {
            BDTrabalho aobj_BDTrabalho = new BDTrabalho();
            string slinha = lbox_Trabalhos.Items[lbox_Trabalhos.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Trabalho_Principal.COD_TRABALHO = Convert.ToInt16(slinha.Substring(0, ipos));
            Trabalho_Principal = aobj_BDTrabalho.FindByCodTrabalho(Trabalho_Principal);
            PopulaTela(Trabalho_Principal);
        }

        private void btn_Cachorro_Click_1(object sender, EventArgs e)
        {
            frm_Cachorro objfrm_Cachorro = new frm_Cachorro();
            objfrm_Cachorro.ShowDialog();
        }

        private void btn_Servico_Click_1(object sender, EventArgs e)
        {
            frm_Servico objfrm_Servico = new frm_Servico();
            objfrm_Servico.ShowDialog();
        }

        private void tbox_Cod_Dono_Leave_1(object sender, EventArgs e)
        {
            lb_Nm_Dono.Text = obj_FGeral.PopulaLabels(tbox_Cod_Dono.Text, 1);
        }

        private void tbox_Cod_Cachorro_Leave_1(object sender, EventArgs e)
        {
            lb_Nm_Cachorro.Text = obj_FGeral.PopulaLabels(tbox_Cod_Cachorro.Text, 2);
        }

        private void tbox_Cod_Servico_Leave_1(object sender, EventArgs e)
        {
            lb_Nm_Servico.Text = obj_FGeral.PopulaLabels(tbox_Cod_Servico.Text, 3);
        }
    }
}


