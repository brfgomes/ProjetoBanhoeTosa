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
    public partial class frm_Dono : Form
    {
        FuncGeral obj_FGeral = new FuncGeral();

        Dono Dono_Principal = new Dono();

        public frm_Dono()
        {
            InitializeComponent();
            PopulaLista();
            obj_FGeral.HabilitaTela(this, false);
            if (lbox_Donos.Items.Count > 0)
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
        * CLASSE:          Preenche a ListBox (lbox_Donos) com os dados 
        *                  cadastrados na TB_DONO
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private void PopulaLista()
        {
            BDDono obj_BDDono = new BDDono();
            List<Dono> Lista = new List<Dono>();

            lbox_Donos.Items.Clear();

            Lista = obj_BDDono.FindAllDono();

            if (Lista != null)
            {
                for (int i = 0; i <= Lista.Count - 1; i++)
                {
                    lbox_Donos.Items.Add(Convert.ToString(Lista[i].COD_DONO) + "-" + Lista[i].NM_DONO);
                }
            }
        }

        /**********************************************************************************
        * NOME:            PopulaTela
        * CLASSE:          Preenche os TextBox com os dados do DONO_PRINCIPAL
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     Passar o parametro Dono para o Procedimento
        * ********************************************************************************/
        private void PopulaTela(Dono aobj_Dono)
        {
            if (aobj_Dono.COD_DONO != -1)
            {
                tbox_Cod_Dono.Text = Convert.ToString(aobj_Dono.COD_DONO);
            }
            tbox_Nm_Dono.Text = aobj_Dono.NM_DONO;
            tbox_Ende_Dono.Text = aobj_Dono.ENDE_DONO;
            tbox_Bai_Dono.Text = aobj_Dono.BAI_DONO;
            tbox_Cid_Dono.Text = aobj_Dono.CID_DONO;
            tbox_UF_Dono.Text = aobj_Dono.UF_DONO;
            tbox_CEP_Dono.Text = aobj_Dono.CEP_DONO;
            tbox_Cel_Dono.Text = aobj_Dono.CEL_DONO;
            tbox_Email_Dono.Text = aobj_Dono.EMAIL_DONO;
            tbox_Nasc_Dono.Text = aobj_Dono.NASC_DONO.ToString("dd/MM/yyyy");
        }

        /**********************************************************************************
        * NOME:            PopulaObjeto
        * CLASSE:          Preenche o objeto DONO_PRINCIPAL com os dados da Tela (TextBox´s)
        * DT CRIAÇÃO:      25/09/2019
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     fgomes
        * OBSERVAÇÕES:     
        * ********************************************************************************/
        private Dono PopulaObjeto()
        {
            Dono aobj_Dono = new Dono();

            if (tbox_Cod_Dono.Text != "")
            {
                aobj_Dono.COD_DONO = Convert.ToInt16(tbox_Cod_Dono.Text);
            }
            aobj_Dono.NM_DONO = tbox_Nm_Dono.Text;
            aobj_Dono.ENDE_DONO = tbox_Ende_Dono.Text;
            aobj_Dono.BAI_DONO = tbox_Bai_Dono.Text;
            aobj_Dono.CID_DONO = tbox_Cid_Dono.Text;
            aobj_Dono.UF_DONO = tbox_UF_Dono.Text;
            aobj_Dono.CEP_DONO = tbox_CEP_Dono.Text;
            aobj_Dono.CEL_DONO = tbox_Cel_Dono.Text;
            aobj_Dono.EMAIL_DONO = tbox_Email_Dono.Text;
            aobj_Dono.NASC_DONO = Convert.ToDateTime(tbox_Nasc_Dono.Text);

            return aobj_Dono;
        }
        private void frm_Dono_Load(object sender, EventArgs e)
        {

        }
        //BTN NOVO
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FGeral.HabilitaTela(this, true);
            obj_FGeral.LimpaTela(this);
            tbox_Nm_Dono.Focus();

            obj_FGeral.StatusBtn(this, 2);
        }
        //BTN ALTERRAR
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Dono.Text != "")
            {
                obj_FGeral.HabilitaTela(this, true);
                tbox_Nm_Dono.Focus();
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
            DialogResult varResp = MessageBox.Show("Confirma a Exclusão deste Dono?", "EXCLUSÃO DO DONO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varResp == DialogResult.Yes)
            {

                BDDono obj_BDDono = new BDDono();
                Dono_Principal = PopulaObjeto();

                if (obj_BDDono.Excluir(Dono_Principal))
                {
                    MessageBox.Show("Dono excluido com sucesso.", "EXCLUSÃO DO DONO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FGeral.LimpaTela(this);
                obj_FGeral.HabilitaTela(this, false);
                PopulaLista();

                if (lbox_Donos.Items.Count > 0)
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
            BDDono obj_BDDono = new BDDono();

            if (obj_FGeral.ValidaCampos(this))
            {
                Dono_Principal = PopulaObjeto();


                if (Dono_Principal.COD_DONO != -1)
                {
                    if (obj_BDDono.Alterar(Dono_Principal))
                    {
                        MessageBox.Show("Dono alterado com sucesso.", "ALTERAÇÃO DO DONO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    tbox_Cod_Dono.Text = obj_BDDono.Incluir(Dono_Principal).ToString();
                    if (tbox_Cod_Dono.Text != "-1")
                    {
                        MessageBox.Show("Dono incluido com sucesso.", "INCLUSÃO DO DONO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tbox_Cod_Dono.Text = "";
                    }
                }

                obj_FGeral.HabilitaTela(this, false);
                PopulaLista();

                if (lbox_Donos.Items.Count > 0)
                {
                    obj_FGeral.StatusBtn(this, 1);
                }
                else
                {
                    obj_FGeral.StatusBtn(this, 0);
                }
            }
        }
        //BTN CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            PopulaTela(Dono_Principal);
            obj_FGeral.HabilitaTela(this, false);

            if (lbox_Donos.Items.Count > 0)
            {
                obj_FGeral.StatusBtn(this, 1);
            }
            else
            {
                obj_FGeral.StatusBtn(this, 0);
            }
        }

        private void lbox_Donos_Click(object sender, EventArgs e)
        {
            BDDono aobj_BDDono = new BDDono();
            string slinha = lbox_Donos.Items[lbox_Donos.SelectedIndex].ToString();

            int ipos = 0;

            for (int t = 0; t <= slinha.Length - 1; t++)
            {
                if (slinha.Substring(t, 1) == "-")
                {
                    ipos = t;
                    break;
                }
            }
            Dono_Principal.COD_DONO = Convert.ToInt16(slinha.Substring(0, ipos));
            Dono_Principal = aobj_BDDono.FindByCodDono(Dono_Principal);
            PopulaTela(Dono_Principal);
        }
    }
}