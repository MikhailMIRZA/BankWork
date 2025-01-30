using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankWork
{
    public partial class Form2 : Form
    {
        private int attempts = 0;
        private const int MaxAttempts = 3;
        private string correctCardNumber = "1234123412341234";
        private string correctPinCode = "1234";

        public Form2()
        {
            InitializeComponent();

        }


        private bool ValidateCard(string cardNumber)
        {

            if (cardNumber.Length != 16 || !long.TryParse(cardNumber, out _))
                return false;


            if (cardNumber != correctCardNumber)
            {
                return false;
            }

            return true;
        }
        private bool ValidatePin(string pinCode)
        {
            if (pinCode.Length != 4 || !int.TryParse(pinCode, out _))
                return false;

            if (pinCode != correctPinCode)
            {
                return false;
            }
            return true;

        }


        private void OpenForm3()
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            form3.FormClosed += (s, args) => this.Close();
        }

        private void GoToForm1()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cardNumber = textBox1.Text;
            string pinCode = textBox2.Text;

            if (ValidateCard(cardNumber) && ValidatePin(pinCode))
            {
                OpenForm3();
            }
            else
            {
                attempts++;
                if (attempts >= MaxAttempts)
                {
                    MessageBox.Show("Превышено количество попыток. Поробуйте позже.");
                    GoToForm1();
                }
                else
                {
                    label1.Text = $"Неверные данные. Осталось попыток: {MaxAttempts - attempts}";
                    label1.Visible = true;
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}