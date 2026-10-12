using Service;
using Service.Dtos;

namespace View
{
    public partial class PersonForm : Form
    {
        private readonly PersonApplicationService _personApplicationService;
        private int _selectedPersonId;

        public PersonForm()
        {
            InitializeComponent();
            _personApplicationService = new PersonApplicationService();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            MessageBox.Show("Fetching is done!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                return;
            }

            var postPersonDto = new PostPersonDto()
            {
                FirstName = txtFName.Text.Trim(),
                LastName = txtLName.Text.Trim(),
            };
            _personApplicationService.Post(postPersonDto);
            RefreshGrid();
            MessageBox.Show("Saving is done!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsPersonSelected() || !IsInputValid())
            {
                return;
            }

            var updatePersonDto = new UpdatePersonDto()
            {
                Id = _selectedPersonId,
                FirstName = txtFName.Text.Trim(),
                LastName = txtLName.Text.Trim(),
            };
            _personApplicationService.Update(updatePersonDto);
            RefreshGrid();
            MessageBox.Show("Updating is done!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsPersonSelected())
            {
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this person?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            var deletePersonDto = new DeletePersonDto()
            {
                Id = _selectedPersonId,
            };
            _personApplicationService.Delete(deletePersonDto);
            RefreshGrid();
            MessageBox.Show("Deleting is done!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPerson.Rows[e.RowIndex].DataBoundItem is GetPersonDto person)
            {
                _selectedPersonId = person.Id;
                txtFName.Text = person.FirstName;
                txtLName.Text = person.LastName;
            }
        }

        private void RefreshGrid()
        {
            dgvPerson.DataSource = _personApplicationService.GetAllPerson();
            _selectedPersonId = 0;
            txtFName.Clear();
            txtLName.Clear();
        }

        private bool IsPersonSelected()
        {
            if (_selectedPersonId <= 0)
            {
                MessageBox.Show("Please select a person from the list first!");
                return false;
            }
            return true;
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("First name and last name are required!");
                return false;
            }
            return true;
        }
    }
}
