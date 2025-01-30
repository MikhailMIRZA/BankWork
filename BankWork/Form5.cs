using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWork
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            UpdateTransactionList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTransactionList()
        {
            listBox1.Items.Clear();
            foreach (Transaction transaction in BalanceManager.TransactionHistory)
            {
                listBox1.Items.Add(transaction.ToString());
            }
        }
    }
    

}

