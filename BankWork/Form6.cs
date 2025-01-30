using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankWork.Form4;

namespace BankWork
{
    public partial class Form6 : Form, IBalanceForm
    {
        public Form6()
        {
            InitializeComponent();
            UpdateBalance();
        }
        public void UpdateBalance()
        {
            label3.Text = $"Баланс: {BalanceManager.Balance}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateBalanceLabels()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is IBalanceForm balanceForm)
                {
                    balanceForm.UpdateBalance();
                }
                if (form is ITransactionHistoryForm transactionForm)
                {
                    transactionForm.UpdateTransactionList();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    MessageBox.Show( "Сумма для снятия должна быть больше 0");
                }
                else if (amount > BalanceManager.Balance)
                {
                    MessageBox.Show("Сумма для снятия не может быть больше текущего баланса.");
                }
                else
                {
                    BalanceManager.WithdrawFromBalance(amount);
                    MessageBox.Show($"Сумма {amount} успешно снята. Текущий баланс: {BalanceManager.Balance}");
                    UpdateBalanceLabels();

                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму!");
            } 

        } 
    }
    
}

