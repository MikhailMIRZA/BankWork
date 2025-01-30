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
    public interface ITransactionHistoryForm
    {
        void UpdateTransactionList();
    }
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal amount))
            {
                if (amount <= 0 || amount > 1000)
                {
                    MessageBox.Show( "Сумма должна быть больше 0 и не более 1000");
                }
                else if (amount == 300)
                {
                    MessageBox.Show("♂️ Fuckin slave ♂️");
                    BalanceManager.AddToBalance(amount);

                }
                else
                {
                    BalanceManager.AddToBalance(amount);
                    MessageBox.Show($"Сумма {amount} успешно добавлена. Текущий баланс: {BalanceManager.Balance}");
                    UpdateBalanceLabels();
                   

                }
            }
            else
            {
                MessageBox.Show( "Введите корректную сумму!");
            }
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
       
        public interface IBalanceForm
        {
            void UpdateBalance();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
public class Transaction
{
    public DateTime Date { get; set; }
    public string Type { get; set; } // "Внесение" или "Снятие"
    public decimal Amount { get; set; }
    public decimal BalanceAfter { get; set; }

    public override string ToString()
    {
        return $"{Date} | {Type} | {Amount} | Баланс: {BalanceAfter}";
    }
}
public static class BalanceManager
{
    public static decimal Balance { get; private set; }
    public static List<Transaction> TransactionHistory { get; } = new List<Transaction>();


    public static void AddToBalance(decimal amount)
    {
        if (amount > 0 && amount <= 1000)
        {
            Balance += amount;
            RecordTransaction("Внесение", amount);
        }

    }
    public static void WithdrawFromBalance(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            RecordTransaction("Снятие", amount);
        }
    }
    private static void RecordTransaction(string type, decimal amount)
    {
        Transaction transaction = new Transaction
        {
            Date = DateTime.Now,
            Type = type,
            Amount = amount,
            BalanceAfter = Balance
        };

        TransactionHistory.Add(transaction);

    }
}