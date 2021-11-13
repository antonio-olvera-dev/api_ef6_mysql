namespace api_ef6_mysql.Controllers.BooksController.Request
{
    public class BookPatchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int UsersId { get; set; }

    }
}
