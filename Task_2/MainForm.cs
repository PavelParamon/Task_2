using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace Task_2
{
    

    public partial class MainForm : Form
    {
        Phones phones = new Phones();

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string mark = FormsUtils.Enter("Укажите марку телефона", "Информация о телефоне");
            string model = FormsUtils.Enter("Укажите модель телефона", "Информация о телефоне");
            int price = Convert.ToInt32(FormsUtils.Enter("Укажите цену телефона", "Информация о телефоне"));
            int memory = Convert.ToInt32(FormsUtils.Enter("Укажите память телефона (Гб)", "Информация о телефоне"));
            int countSIM = Convert.ToInt32(FormsUtils.Enter("Укажите кол-во SIM телефона", "Информация о телефоне"));


            if (countSIM < 2 && countSIM > -1)
            {
                MobilePhone phone = new MobilePhone(mark, model, price, memory);
                phones.AddMobilePhone(phone, null);
            }
            else if (countSIM >= 2)
            {
                PhoneModify phone = new PhoneModify(mark, model, price, memory, countSIM);
                phones.AddMobilePhone(null, phone);
            }          
            else
                FormsUtils.ErrorMessageBox("Некорректное значение");

        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.Text = "";
                string[] phonesInfo = phones.PrintInfo();
                for (int i = 0; i < phonesInfo.Length; i++)
                {
                    InfoTextBox.AppendText(phonesInfo[i]);
                }
            }
            catch
            {
                FormsUtils.ErrorMessageBox("Error");
            }
        }

        private void Clean_btn_Click(object sender, EventArgs e)
        {
            InfoTextBox.Text = "";
        }
    }
}
