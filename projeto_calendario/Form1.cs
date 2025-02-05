using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            txt_inicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            txt_final.Text = monthCalendar.SelectionEnd.ToShortDateString();
            txt_atual.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void txt_atual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_final_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_inicial2.Text = monthCalendar.SelectionStart.ToShortDateString();
            txt_final2.Text = monthCalendar.SelectionEnd.ToShortDateString();
            txt_atual2.Text = monthCalendar.TodayDate.ToShortDateString();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("Você está lendo essa mensagem!");
            }
        }
    }
}
