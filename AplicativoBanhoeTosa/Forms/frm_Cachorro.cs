
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
    public partial class frm_Cachorro : Form
    {
        FuncGeral obj_FGeral = new FuncGeral();

        Cachorro Cachorro_Principal = new Cachorro();

        public frm_Cachorro()
        {
            InitializeComponent();
            PopulaLista();
            obj_FGeral.HabilitaTela(this, false);
            if (lbox_Cachorros.Items.Count > 0)
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
        * CLASSE:          Preenche a ListBox (lbox_Cachorros) com os dados 
        *                  cadastrados na TB_CACHORRO
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            BDCachorro obj_BDCachorro = new BDCachorro();
            List<Cachorro> Lista = new List<Cachorro>();

            lbox_Cachorros.Items.Clear();

            Lista = obj_BDCachorro.FindAllCachorro();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Cachorros.Items.Add(Convert.ToString(Lista[i].COD_CACHORRO) + "-" + Lista[i].NM_CACHORRO);
                }
            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * CLASSE:          Preenche os TextBox com os dados do CACHORRO_PRINCIPAL
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     Passar o parametro Cachorro para o Procedimento
        * ********************************************************************************/
        private void PopulaTela(Cachorro aobj_Cachorro)
        {
            if (aobj_Cachorro.COD_CACHORRO != -1)
            {
                tbox_Cod_Cachorro.Text = Convert.ToString(aobj_Cachorro.COD_CACHORRO);
            }
            tbox_Nm_Cachorro.Text = aobj_Cachorro.NM_CACHORRO;
            tbox_Tmn_Cachorro.Text = aobj_Cachorro.TMN_CACHORRO;
            tbox_Idade_Cachorro.Text = aobj_Cachorro.IDADE_CACHORRO;
            tbox_Raca_Cachorro.Text = aobj_Cachorro.RACA_CACHORRO;
            tbox_Doen_Cachorro.Text = aobj_Cachorro.DOEN_CACHORRO;
            tbox_Curio_Cachorro.Text = aobj_Cachorro.CURIO_CACHORRO;

            tbox_Cod_Dono.Text = Convert.ToString(aobj_Cachorro.COD_DONO);
            lb_Nm_Dono.Text = obj_FGeral.PopulaLabels(tbox_Cod_Dono.Text, 1);


            if (aobj_Cachorro.GEN_CACHORRO == "M")
            {
                rbtn_Mas_Cachorro.Checked = true;
                rbtn_Fem_Cachorro.Checked = false;
            }
            else
            {
                rbtn_Fem_Cachorro.Checked = true;
                rbtn_Mas_Cachorro.Checked = false;
            }

        }


        /**********************************************************************************
        * NOME:            PopulaObjeto
        * CLASSE:          Preenche o objeto CACHORRO_PRINCIPAL com os dados da Tela (TextBox´s)
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Cachorro PopulaObjeto()
        {
            Cachorro aobj_Cachorro = new Cachorro();

            if (tbox_Cod_Cachorro.Text != "")
            {
                aobj_Cachorro.COD_CACHORRO = Convert.ToInt16(tbox_Cod_Cachorro.Text);
            }
            aobj_Cachorro.NM_CACHORRO = tbox_Nm_Cachorro.Text;
            aobj_Cachorro.TMN_CACHORRO = tbox_Tmn_Cachorro.Text;
            aobj_Cachorro.IDADE_CACHORRO = tbox_Idade_Cachorro.Text;
            aobj_Cachorro.RACA_CACHORRO = tbox_Raca_Cachorro.Text;
            aobj_Cachorro.DOEN_CACHORRO = tbox_Doen_Cachorro.Text;
            aobj_Cachorro.CURIO_CACHORRO = tbox_Curio_Cachorro.Text;
            aobj_Cachorro.COD_DONO = Convert.ToInt16(tbox_Cod_Dono.Text);

            if (rbtn_Mas_Cachorro.Checked)
            {
                aobj_Cachorro.GEN_CACHORRO = "M";
            }
            else
            {
                aobj_Cachorro.GEN_CACHORRO = "F";
            }


            return aobj_Cachorro;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_Fem_Cachorro_CheckedChanged(object sender, EventArgs e)
        {

        }
        //BTN NOVO
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FGeral.HabilitaTela(this, true);
            obj_FGeral.LimpaTela(this);
            tbox_Nm_Cachorro.Focus();

            obj_FGeral.StatusBtn(this, 2);
        }
        //BTN ALTERAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Cachorro.Text != "")
            {
                obj_FGeral.HabilitaTela(this, true);
                tbox_Nm_Cachorro.Focus();
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
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão deste Cachorro?", "EXCLUSÃO DO AUTOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {

                BDCachorro obj_BDCachorro = new BDCachorro();
                Cachorro_Principal = PopulaObjeto();

                if (obj_BDCachorro.Excluir(Cachorro_Principal))
                {
                    MessageBox.Show("Cachorro excluido com sucesso.", "EXCLUSÃO DO AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FGeral.LimpaTela(this);
                obj_FGeral.HabilitaTela(this, false);
                PopulaLista();

                if (lbox_Cachorros.Items.Count > 0)
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
            BDCachorro obj_BDCachorro = new BDCachorro();

            Cachorro_Principal = PopulaObjeto();

            if (Cachorro_Principal.COD_CACHORRO != -1)
            {
                if (obj_BDCachorro.Alterar(Cachorro_Principal))
                {
                    MessageBox.Show("Cachorro alterado com sucesso.", "ALTERAÇÃO DO AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                tbox_Cod_Cachorro.Text = obj_BDCachorro.Incluir(Cachorro_Principal).ToString();
                if (tbox_Cod_Cachorro.Text != "-1")
                {
                    MessageBox.Show("Cachorro incluido com sucesso.", "INCLUSÃO DO AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbox_Cod_Cachorro.Text = "";
                }
            }

            obj_FGeral.HabilitaTela(this, false);
            PopulaLista();

            if (lbox_Cachorros.Items.Count > 0)
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
            PopulaTela(Cachorro_Principal);
            obj_FGeral.HabilitaTela(this, false);

            if (lbox_Cachorros.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }
        }
        //CLICK
        private void lbox_Cachorros_Click(object sender, EventArgs e)
        {
            BDCachorro aobj_BDCachorro = new BDCachorro();
            string slinha = lbox_Cachorros.Items[lbox_Cachorros.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Cachorro_Principal.COD_CACHORRO = Convert.ToInt16(slinha.Substring(0, ipos));
            Cachorro_Principal = aobj_BDCachorro.FindByCodCachorro(Cachorro_Principal);
            PopulaTela(Cachorro_Principal);
        }

        private void tbox_Cod_Dono_Leave(object sender, EventArgs e)
        {
            lb_Nm_Dono.Text = obj_FGeral.PopulaLabels(tbox_Cod_Dono.Text, 1);
        }

        private void btn_Dono_Click(object sender, EventArgs e)
        {
            frm_Dono objfrm_Dono = new frm_Dono();
            objfrm_Dono.ShowDialog();
        }
    }
}



