namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            using (var personForm = new PersonForm())
            {
                personForm.StartPosition = FormStartPosition.Manual;
                personForm.Location = Location;
                personForm.Size = Size;
                personForm.ShowDialog();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            using (var productForm = new ProductForm())
            {
                productForm.StartPosition = FormStartPosition.Manual;
                productForm.Location = Location;
                productForm.Size = Size;
                productForm.ShowDialog();
            }
        }
    }
}
