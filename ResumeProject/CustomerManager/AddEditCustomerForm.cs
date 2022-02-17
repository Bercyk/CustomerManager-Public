using CustomerManager.Domain.DTOs;
using CustomerManager.Domain.Services;

namespace CustomerManager
{
    public partial class AddEditCustomerForm : Form
    {
        private readonly ICustomerService _customerService;

        private bool _isEditClicked;

        private int? _customerId;

        private CustomerListForm _customerListForm;

        private bool _isCorrectNIP = false;
        

        public AddEditCustomerForm(bool isEditClicked, int? customerId, ICustomerService customerService, CustomerListForm customerListForm)
        {
            InitializeComponent();

            _customerService = customerService;

            _customerListForm = customerListForm;

            _isEditClicked = isEditClicked;

            _customerId = customerId;


        }

        private void AddEditCustomerForm_Load(object sender, EventArgs e)
        {
            SetCustomerType();

            if (_isEditClicked)
            {
                LoadClientData();
            }
        }


        private void NIPTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetDataFromForm();
            if (_isCorrectNIP)
            {
                this.Close();
                _customerListForm.SetListView();
            }
        }    
        
        private void GetDataFromForm()
        {
            if (NIPTextbox.Text.Length < 10)
            {
                MessageBox.Show("Wprowadź poprawny NIP (10 cyfr)!", "Błąd", MessageBoxButtons.OK);
                _isCorrectNIP = false;
            }
            else
            {
                _isCorrectNIP=true;

                CustomerDTO customerDTO = new CustomerDTO();

                customerDTO.Name = CustomerNameTextbox.Text;

                customerDTO.NIP = NIPTextbox.Text;

                var comboBoxItem = ((ComboboxItem)CustomerTypeCombobox.SelectedItem);

                customerDTO.Type = new CustomerTypeDTO { Id = comboBoxItem.Value, Name = comboBoxItem.Text };

                customerDTO.Description = CustomerDescriptionRichTextbox.Text;
                customerDTO.Status = CustomerStatusCheckBox.Checked;

                if (_isEditClicked)
                {
                    customerDTO.Id = (int)_customerId;
                    _customerService.Update(customerDTO);
                }
                else
                {
                    _customerService.Create(customerDTO);
                }
            }   
        }

        private void SetCustomerType()
        {
            var customerTypes = _customerService.GetAllTypes();
            var comboboxItems = customerTypes.Select(x => new ComboboxItem() { Text = x.Name, Value = x.Id }).ToArray();

            CustomerTypeCombobox.Items.AddRange(comboboxItems);
        }

        private void LoadClientData()
        {
            var customerUpdate = _customerService.Get((int)_customerId);

            

            CustomerNameTextbox.Text = customerUpdate.Name;
            NIPTextbox.Text = customerUpdate.NIP;

            CustomerTypeCombobox.SelectedIndex = CustomerTypeCombobox.FindString(customerUpdate.Type.Name);

            CustomerDescriptionRichTextbox.Text = customerUpdate.Description;
            CustomerStatusCheckBox.Checked = customerUpdate.Status;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _customerListForm.SetListView();
        }
    }
}
