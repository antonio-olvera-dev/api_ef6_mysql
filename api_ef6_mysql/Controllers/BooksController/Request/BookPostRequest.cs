namespace api_ef6_mysql.Controllers.BooksController.Request
{
    public class BookPostRequest
    {
        public string Name { get; set; } = null!;
        public DateTime Year { get; set; }
        public int UsersId { get; set; }

    }
}
