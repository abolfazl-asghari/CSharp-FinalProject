using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace Service
{
    public class ProductApplicationService
    {
        private readonly ProductServiceModel _productServiceModel;

        #region [- ctor -]
        public ProductApplicationService()
        {
            _productServiceModel = new ProductServiceModel();
        }
        #endregion

        #region [- GetAllProduct() -]
        public List<GetProductDto> GetAllProduct()
        {
            var products = _productServiceModel.SelectAll();
            var getProductDtos = new List<GetProductDto>();
            foreach (var item in products)
            {
                var getProductDto = new GetProductDto()
                {
                    Id = item.Id,
                    Title = item.Title,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                };
                getProductDtos.Add(getProductDto);
            }
            return getProductDtos;
        }
        #endregion

        #region [- Post() -]
        public void Post(PostProductDto postProductDto)
        {
            var product = new Product()
            {
                Title = postProductDto.Title,
                UnitPrice = postProductDto.UnitPrice,
                Quantity = postProductDto.Quantity,
            };
            _productServiceModel.Insert(product);
        }
        #endregion

        #region [- Update() -]
        public void Update(UpdateProductDto updateProductDto)
        {
            var product = new Product()
            {
                Id = updateProductDto.Id,
                Title = updateProductDto.Title,
                UnitPrice = updateProductDto.UnitPrice,
                Quantity = updateProductDto.Quantity,
            };
            _productServiceModel.Update(product);
        }
        #endregion

        #region [- Delete() -]
        public void Delete(DeleteProductDto deleteProductDto)
        {
            var product = new Product()
            {
                Id = deleteProductDto.Id,
            };
            _productServiceModel.Delete(product);
        }
        #endregion
    }
}
