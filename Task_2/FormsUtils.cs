using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Utils
{
    public class FormsUtils
    {
        // Показать сообщение об ошибке (параметр - строка)
        public static void ErrorMessageBox(string message) {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        // Показать сообщение об ошибке (параметр - исключение)
        public static void ErrorMessageBox(Exception except) {
            ErrorMessageBox(String.Format("{0}\n\n{1}", except.Message, except.StackTrace));
        }

        public static void ShowMessage (string text)
        {
            MessageBox.Show(text);
        }

        public static string Enter (string text, string header)
        {
            Form Enter = new Form()
            {
                Width = 350,
                Height = 150,
                Text = header,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog

            };

            Label lbl = new Label()
            {
                Left = 85,
                Top = 10,
                Width = 300,
                Text = text
            };

            Enter.Controls.Add(lbl);

            TextBox textbox = new TextBox()
            {
                Left = 25,
                Top = 40,
                Width = 300
            };

            Enter.Controls.Add(textbox);

            Button OK_btn = new Button()
            {
                Left = 100,
                Width = 100,
                Top = 70,
                Text = "OK", 
                DialogResult = DialogResult.OK
            };

            OK_btn.Click += (sender, e) => { Enter.Close(); };

            Enter.AcceptButton = OK_btn;
            Enter.Controls.Add(OK_btn);

            return Enter.ShowDialog() == DialogResult.OK ? textbox.Text : null;
        }

    }
}
