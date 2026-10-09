using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            try
            {
                string jsonPath = "\\Saved Data\\Store Object.json";

                Store tempStore = ProjectSerializer.DeserializeJsonStoreFile(jsonPath);

                if (tempStore == null)
                {
                    throw new Exception();
                }

                _store = tempStore;
            }
            catch { }


            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        /// <summary>
        /// Отбработчик события закрытия окна
        /// Сериализует экземпляр класса <see cref="Store">
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SerializeJsonStoreFile(_store, "\\Saved Data\\Store Object.json");
        }
    }
}
