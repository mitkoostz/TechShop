using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_ShopManagemant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadOrderListItems();     
        }

        public void LoadOrderListItems()
        {
            var lastSelectedIndex = OrderListBox.SelectedIndex;

            OrderListBox.Items.Clear();
            using (var db = new DataContext())
            {
                List<Order> sortedOrders = new List<Order>();
                sortedOrders = db.Orders.OrderByDescending(o => o.clientName).ToList();

                foreach (var order in sortedOrders)
                {
                    OrderListBox.Items.Add(order);
                                   
                }
               
                OrderListBox.DisplayMember = "clientName";
                orderscount.Text = OrderListBox.Items.Count + " orders";
                OrderListBox.SelectedIndex = lastSelectedIndex;
            }
        }
        public void LoadOrderListItemsByDate()
        {
            var lastSelectedIndex = OrderListBox.SelectedIndex;

            OrderListBox.Items.Clear();
            using (var db = new DataContext())
            {
                List<Order> sortedOrders = new List<Order>();
                sortedOrders = db.Orders.OrderBy(o => o.clientName).ToList();

                foreach (var order in sortedOrders)
                {
                    OrderListBox.Items.Add(order);

                }

                OrderListBox.DisplayMember = "clientName";
                orderscount.Text = OrderListBox.Items.Count + " orders";
                OrderListBox.SelectedIndex = lastSelectedIndex;
            }
        }
        public void LoadOrderListItemsByOrderedItems()
        {
            var lastSelectedIndex = OrderListBox.SelectedIndex;

            OrderListBox.Items.Clear();
            using (var db = new DataContext())
            {
                List<Order> sortedOrders = new List<Order>();
                sortedOrders = db.Orders.OrderByDescending(o => o.OrderedProducts.Length).ToList();

                foreach (var order in sortedOrders)
                {
                    OrderListBox.Items.Add(order);

                }

                OrderListBox.DisplayMember = "clientName";
                orderscount.Text = OrderListBox.Items.Count + " orders";
                OrderListBox.SelectedIndex = lastSelectedIndex;
            }
        }


        private void OrderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = (Order)OrderListBox.SelectedItem;
                
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SortingMode.SelectedIndex = 1;

            Timer RefreshTimer = new Timer();
            RefreshTimer.Interval = (1 * 60 * 100); // 45 mins
            RefreshTimer.Tick += new EventHandler(AutoRefresh);
            RefreshTimer.Start();
        }

        public void AutoRefresh(object sender, EventArgs e)
        {
            //ordering by date
            if (SortingMode.SelectedIndex == 0)
            {

            }
            //ordering by name
            if (SortingMode.SelectedIndex == 1)
            {
                LoadOrderListItems();
            }
            //ordering by number of ordered items
            if (SortingMode.SelectedIndex == 2)
            {
                LoadOrderListItemsByOrderedItems();
            }
            
           
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
           if(OrderListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select order first.");
            }
        }

        private void SortingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ordering by date
            if (SortingMode.SelectedIndex == 0)
            {

            }
            //ordering by name
            if (SortingMode.SelectedIndex == 1)
            {
                LoadOrderListItems();
            }
            //ordering by number of ordered items
            if (SortingMode.SelectedIndex == 2)
            {
                LoadOrderListItemsByOrderedItems();
            }
        }
    }
}
