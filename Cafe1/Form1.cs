using System.Windows.Forms;

namespace Cafe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> Items = new List<string>();
        public List<int> Quantity = new List<int>();
        public List<double> Price = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemList.Text == "Hot Chocolate")
            {
                Items.Add("Hot Chocolate");
                Price.Add(25);
            }

            if (ItemList.Text == "Latte")
            {
                Items.Add("Latte");
                Price.Add(28);
            }

            if (ItemList.Text == "Cappuccino")
            {
                Items.Add("Cappuccino");
                Price.Add(30);
            }

            if (ItemList.Text == "Vanilla Maffin")
            {
                Items.Add("Vanilla Maffin");
                Price.Add(15);
            }

            if (ItemList.Text == "Chocolate Chip Muffin")
            {
                Items.Add("Chocolate Chip Muffin");
                Price.Add(19);
            }

            if (ItemList.Text == "BarOne Cake")
            {
                Items.Add("BarOne Cake");
                Price.Add(35);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(QuantityInput.Text);
            Quantity.Add(input);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                string itemInfo = "Item: " + Items[i] + "\n" +
                                  "Quantity: " + Quantity[i] + "\n" +
                                  "Price for 1: R " + Price[i] + "\n" +
                                  "Total: R" + (Quantity[i] * Price[i]) + "\n\n";

                Display.SelectionFont = new Font("Aerial", 10, FontStyle.Regular);

                // Add the constructed string to the ListBox
                Display.AppendText(itemInfo);


            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Display.Clear();
            Items.Clear();
            Quantity.Clear();
            Price.Clear();
        }
    }
}
