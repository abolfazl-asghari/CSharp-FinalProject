using Service;
using Service.Dtos;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductApplicationService _productApplicationService;
        private int _selectedProductId;

        public ProductForm()
        {
            InitializeComponent();
            _productApplicationService = new ProductApplicationService();
        }

        private void ProductForm_Load(object sender, EventArgs e)
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
            if (!TryReadInput(out var unitPrice, out var quantity))
            {
                return;
            }

            var postProductDto = new PostProductDto()
            {
                Title = txtTitle.Text.Trim(),
                UnitPrice = unitPrice,
                Quantity = quantity,
            };
            _productApplicationService.Post(postProductDto);
            RefreshGrid();
            MessageBox.Show("Saving is done!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsProductSelected() || !TryReadInput(out var unitPrice, out var quantity))
            {
                return;
            }

            var updateProductDto = new UpdateProductDto()
            {
                Id = _selectedProductId,
                Title = txtTitle.Text.Trim(),
                UnitPrice = unitPrice,
                Quantity = quantity,
            };
            _productApplicationService.Update(updateProductDto);
            RefreshGrid();
            MessageBox.Show("Updating is done!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsProductSelected())
            {
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            var deleteProductDto = new DeleteProductDto()
            {
                Id = _selectedProductId,
            };
            _productApplicationService.Delete(deleteProductDto);
            RefreshGrid();
            MessageBox.Show("Deleting is done!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProduct.Rows[e.RowIndex].DataBoundItem is GetProductDto product)
            {
                _selectedProductId = product.Id;
                txtTitle.Text = product.Title;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtQuantity.Text = product.Quantity.ToString();
            }
        }

        private void RefreshGrid()
        {
            dgvProduct.DataSource = _productApplicationService.GetAllProduct();
            _selectedProductId = 0;
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
        }

        private bool IsProductSelected()
        {
            if (_selectedProductId <= 0)
            {
                MessageBox.Show("Please select a product from the list first!");
                return false;
            }
            return true;
        }

        private bool TryReadInput(out int unitPrice, out int quantity)
        {
            unitPrice = 0;
            quantity = 0;

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required!");
                return false;
            }

            if (!int.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit price must be a non-negative whole number!");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative whole number!");
                return false;
            }

            return true;
        }
    }
}
