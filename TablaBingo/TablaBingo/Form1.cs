using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaBingo
{
    public partial class FmTblBingo : Form
    {
        TablaBingo tb;
        int cont = 1;
        public FmTblBingo()
        {
            InitializeComponent();
            tb = new TablaBingo();
        }

        private void BtnNewTbl_Click(object sender, EventArgs e)
        {
            tb.Generar();
            TblBingo.DataSource = tb.Tabla1;

        }

        private void TblBingo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellStyle sty = new DataGridViewCellStyle();
            sty.BackColor = Color.Red;
            if (!TblBingo.SelectedCells[0].Value.ToString().Equals("X") && 
                !TblBingo.SelectedCells[0].Value.ToString().Equals("UPB"))
            {
                TblBingo.SelectedCells[0].Style = sty;
                BtnNewTbl.Enabled = false;
                cont++;
            }
            if (cont == 25)
            {
                MessageBox.Show(null, "Felicidades,acaba de ganar", "¡BINGO!");
            }
        }

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            cont = 1;
            BtnNewTbl.Enabled = true;
            tb.Generar();
            TblBingo.DataSource = tb.Tabla1;
        }
    }
}
