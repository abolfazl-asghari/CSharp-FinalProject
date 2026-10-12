namespace Service.Dtos
{
    public class PostProductDto
    {
        public string Title { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
