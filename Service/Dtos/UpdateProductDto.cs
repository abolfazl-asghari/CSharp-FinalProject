namespace Service.Dtos
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
