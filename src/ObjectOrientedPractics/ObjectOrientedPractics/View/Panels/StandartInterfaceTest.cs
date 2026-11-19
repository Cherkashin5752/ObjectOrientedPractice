using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class StandartInterfaceTest : UserControl
    {
        public StandartInterfaceTest()
        {
            InitializeComponent();

            FirstItemControl.CurrentItem = new Item();
            SecondItemControl.CurrentItem = new Item();
        }
        private void IsEqualButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Равны ли два товара: " + (FirstItemControl.CurrentItem.Equals(SecondItemControl.CurrentItem)
                                                        ? "Равны"
                                                        : "Не равны"));
        }

        private void MakeEqualButton_Click(object sender, EventArgs e)
        {
            SecondItemControl.CurrentItem = (Item)FirstItemControl.CurrentItem.Clone();
        }

        private void WhichGreaterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{FirstItemControl.CurrentItem.CompareTo(SecondItemControl.CurrentItem)}");
        }
    }
}
