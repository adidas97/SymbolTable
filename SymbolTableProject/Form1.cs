using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolTableProject
{
    public partial class Form1 : Form
    {
        
        Dictionary<string, string> tableData;
        public Form1()
        {
            tableData = new Dictionary<string, string>();

            InitializeComponent();
            fill();
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void fill ()
        {
            for (int i = 1; i <= 13; i++)
            {
                dataGridView.Rows.Add(i.ToString());

            }
        }

       

        

        private void addBtn_Click(object sender, EventArgs e)
        {
            string key = keyTxt.Text;
            string value = valueTxt.Text;
            

            if(!tableData.ContainsKey(key))
            {
                tableData.Add(key, value);
                refresh();
            }
            else
            {
                var a = tableData.Keys.ToList().IndexOf(key);

                a++;
                indexTxt.Text = a.ToString();

            }

           


        }

        private void refresh()
        {
            int count = 0;
            foreach (var item in tableData)
            {
                
                dataGridView.Rows[count].Cells[1].Value = item.Key;
                dataGridView.Rows[count].Cells[2].Value = item.Value;
                count++;
               
            }
            indexTxt.Text = count.ToString();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tableData = new Dictionary<string, string>();
            refresh();
            dataGridView.Rows.Clear();
            fill();
            keyTxt.Text = "";
            valueTxt.Text = "";
            indexTxt.Text = "";
        }
    }
}
