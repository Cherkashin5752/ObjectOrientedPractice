using ObjectOrientedPractics.Model;
using System.ComponentModel;
using WinControl = System.Windows.Forms.Control;
using WinTextBox = System.Windows.Forms.TextBox;

namespace ObjectOrientedPractics.View.Control
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с адресами покупателей
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес текуще-выбранного покупателя
        /// </summary>
        private Address _currentAddress;

        /// <summary>
        /// должны ли все TextBox элементы в пользовательском элементе быть ReadOnly
        /// </summary>
        private bool _readOnly;

        /// <summary>
        /// Событие. Возникает при изменении любого поля класса
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Возвращает и задаёт значение текуще-выбранного покупателя
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address CurrentAddress
        {
            get
            {
                return _currentAddress;
            }
            set
            {
                _currentAddress = value;

                if (value == null)
                {
                    ClearTextBoxAddress();
                    return;
                }

                RefreshAddressInfo();
            }
        }

        /// <summary>
        /// Возвращает и задаёт поле ReadOnly. Также переводит на пользовательском элементе все TextBox элементы в соответствующее состояние ReadOnly
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                _readOnly = value;
                SetTextBoxesReadOnly(this, value);
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// <summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывает событие <see cref="AddressChanged">
        /// </summary>
        public void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Меняет значения текстовых полей Address в форме на значения текуще-выбранного покупателя
        /// </summary>
        private void RefreshAddressInfo()
        {
            PostIndexTextBox.Text = CurrentAddress.Index.ToString();
            CountryTextBox.Text = CurrentAddress.Country;
            CityTextBox.Text = CurrentAddress.City;
            StreetTextBox.Text = CurrentAddress.Street;
            BuildingTextBox.Text = CurrentAddress.Building;
            ApartmentTextBox.Text = CurrentAddress.Apartment;
        }

        /// <summary>
        /// Обработчик события изменения текста в поле индекса адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.Index = int.Parse(PostIndexTextBox.Text);
                    OnAddressChanged();
                    PostIndexTextBox.BackColor = Color.White;
                }
                catch { PostIndexTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле страны/региона адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.Country = CountryTextBox.Text;
                    OnAddressChanged();
                    CountryTextBox.BackColor = Color.White;
                }
                catch { CountryTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле города адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.City = CityTextBox.Text;
                    OnAddressChanged();
                    CityTextBox.BackColor = Color.White;
                }
                catch { CityTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле улицы адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.Street = StreetTextBox.Text;
                    OnAddressChanged();
                    StreetTextBox.BackColor = Color.White;
                }
                catch { StreetTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле номера дома адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.Building = BuildingTextBox.Text;
                    OnAddressChanged();
                    BuildingTextBox.BackColor = Color.White;
                }
                catch { BuildingTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле номера квартиры/помещения адреса покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentAddress != null && !ReadOnly)
            {
                try
                {
                    CurrentAddress.Apartment = ApartmentTextBox.Text;
                    OnAddressChanged();
                    ApartmentTextBox.BackColor = Color.White;
                }
                catch { ApartmentTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Переводит все TextBox элементы в соответствующее состояние ReadOnly.
        /// </summary>
        /// <param name="parent">Текущий пользовательский элемент.</param>
        /// <param name="isReadOnly">В какой состояние ReadOnly перевести все TextBox элементы</param>
        private void SetTextBoxesReadOnly(WinControl parent, bool isReadOnly)
        {
            foreach (WinControl control in parent.Controls)
            {
                if (control is WinTextBox textBox)
                {
                    textBox.ReadOnly = isReadOnly;
                    textBox.BackColor = isReadOnly ? SystemColors.Control : Color.White;
                }

                if (control.HasChildren)
                {
                    SetTextBoxesReadOnly(control, isReadOnly);
                }
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы о адресе покупателя
        /// </summary>
        private void ClearTextBoxAddress()
        {
            PostIndexTextBox.Text = "";
            CountryTextBox.Text = "";
            CityTextBox.Text = "";
            StreetTextBox.Text = "";
            BuildingTextBox.Text = "";
            ApartmentTextBox.Text = "";

            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
        }
    }
}
