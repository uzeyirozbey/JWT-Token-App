using JwtAuthExampleApp.Models.Book;

namespace JwtAuthExampleApp.Interfaces
{
    public interface IBookService
    {
        public Task<List<BookTitle>> GetBookTitlesAsync();
        public Task<BookInformation> GetBookInformationByIdAsync(GetBookInformationByIdRequest request);
    }
}
