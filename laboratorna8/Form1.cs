using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace laboratorna8
{
    public partial class Form1 : Form
    {
        private bool _ascending = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Додати число до списку
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text.Trim();

            if (double.TryParse(input, out double number))
            {
                listBox1.Items.Add(number);
                txtNumber.Clear();
                txtNumber.Focus();
            }
            else
            {
                MessageBox.Show("Введіть коректне число!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.SelectAll();
                txtNumber.Focus();
            }
        }

        // Сортування за зростанням / спаданням
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Список порожній!", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<double> numbers = listBox1.Items
                .Cast<object>()
                .Select(item => Convert.ToDouble(item))
                .ToList();

            if (_ascending)
            {
                numbers.Sort();
                btnSort.Text = "Сортувати ↑ (зростання)";
            }
            else
            {
                numbers.Sort((a, b) => b.CompareTo(a));
                btnSort.Text = "Сортувати ↓ (спадання)";
            }

            _ascending = !_ascending;

            listBox1.Items.Clear();
            foreach (var n in numbers)
                listBox1.Items.Add(n);
        }

        // Видалити вибраний елемент
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        // Очистити весь список
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // Додавання числа клавішею Enter
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd_Click(sender, e);
        }
    }
}