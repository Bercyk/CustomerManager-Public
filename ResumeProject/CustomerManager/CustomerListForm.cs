using CustomerManager.Domain.Services;

namespace CustomerManager
{ 
    public partial class CustomerListForm : Form
    {
        private readonly ICustomerService _customerService;

        private static bool _isEditClicked;

        private static int? _customerId = null;

        private static CustomerListForm _customerListForm = null;

        public CustomerListForm(ICustomerService customerService)
        {
            _customerService = customerService;

            _customerListForm = this;

            InitializeComponent();

            SetListView();


        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _isEditClicked = false;
            AddEditCustomerForm addEditCustomerForm = new AddEditCustomerForm(_isEditClicked, _customerId, _customerService, _customerListForm);
            addEditCustomerForm.Show();
        }
        internal void SetListView()
        {
            var list = _customerService.GetAll();

            CustomerListView.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                CustomerListView.Items.Add(new ListViewItem(new[] {list[i].Name, list[i].NIP, list[i].Id.ToString()}));
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems == null || CustomerListView.SelectedItems.Count != 1)
            {
                MessageBox.Show("Wybierz klienta do edycji!", "B³¹d", MessageBoxButtons.OK);
            }
            else
            {
                _customerId = int.Parse(CustomerListView.SelectedItems[0].SubItems[2].Text);
                _isEditClicked = true;
                AddEditCustomerForm addEditCustomerForm = new AddEditCustomerForm(_isEditClicked, _customerId, _customerService, _customerListForm);
                addEditCustomerForm.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}