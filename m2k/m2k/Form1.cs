using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m2k
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // нажатие клавиши в поле редактирования
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*Правильными символами считаются цифры,
             * Запятая, <Enter> и <Backspace>.
             * Будем считать правильным сиволом
             * также точку, но заменим её запятой.
             * Остальные символы запрещены.
             * Чтобы запрещенный символ не отображался
             * в поле редактирования, присвоим
             * значение true свойству Handled параметра e
             */
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                //Цифра
                return;
            }

            if (e.KeyChar == '.')
            {
                //Точку заменим запятой
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf('0') != -1)
                {
                    //Запятая уже есть в поле редактирования
                    e.Handled = true;
                }
                return;
            }

            if ( Char.IsControl (e.KeyChar))
            {
                //<Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char) Keys.Enter)
                    //Нажата клавига <Enter>
                    //Установить курсор на кнопку OK
                    button1.Focus();
                return;
            }

            // Остальные символы запрещены
            e.Handled = true;
        }
        //Щелчок по кнопке ОК

    }
}

