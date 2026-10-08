namespace ObjectOrientedPractics
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            itemsTab1.SerializeItems();
            customersTab1.SerializeCustomers();
        }
    }
}
