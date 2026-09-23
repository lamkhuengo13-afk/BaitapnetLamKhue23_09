using System;
using System.Windows.Forms;

namespace Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMenu.Items.Add(new FoodItem("Hamburger", 50000));
            lstMenu.Items.Add(new FoodItem("Pizza", 120000));
            lstMenu.Items.Add(new FoodItem("Gà Rán", 35000));
            lstMenu.Items.Add(new FoodItem("Pepsi", 15000));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                FoodItem selectedFood = (FoodItem)lstMenu.SelectedItem;
                lstSelected.Items.Add(selectedFood);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn từ Thực đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTotal()
        {
            int total = 0;

            foreach (FoodItem item in lstSelected.Items)
            {
                total += item.Price;
            }

            lblTotal.Text = $"Tổng tiền: {total:#,##0} VNĐ";
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public FoodItem(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:#,##0}đ";
        }
    }
}