namespace Library.DTO.Requests.Book;

public record UpdateBookRequest
    (string FindByTitle, string NewTitle, string Publisher);