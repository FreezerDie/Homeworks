namespace Library.DTO.Requests.Author;

public record AuthorUpdateRequest
    (string FindByName, string NewFullName);