using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Child child = new Child();

            if (child.ShowDialog() == DialogResult.OK)
            {
                //if (!String.IsNullOrEmpty(child.TName) && !String.IsNullOrEmpty(child.TCountry) && !String.IsNullOrEmpty(child.TPrice))
                lstbProduct.Items.Add(new Product() {Name = child.TName , Country = child.TCountry, Price = child.TPrice });
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstbProduct.SelectedIndex != -1)
            {
                Child child = new Child(lstbProduct.SelectedItem as Product);


                if (child.ShowDialog() == DialogResult.OK)
                {
                    int idx = lstbProduct.SelectedIndex;
                    lstbProduct.Items.RemoveAt(idx);
                    lstbProduct.Items.Insert(idx, new Product() { Name = child.TName, Country = child.TCountry, Price = child.TPrice });
                }
            }

            else MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbProduct.Items.Clear();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstbProduct.SelectedIndex != -1)
                lstbProduct.Items.RemoveAt(lstbProduct.SelectedIndex);

            else MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
