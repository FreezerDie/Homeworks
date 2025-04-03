namespace Library.DTO.Requests.Book;

public record AddBookRequest
    (string AuthorName, string GenreName, string Title, string Publisher);