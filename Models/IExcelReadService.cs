namespace EconomicPocTim.Models
{
    public interface IExcelReadService
    {
        public Task<List<IItem>> readFileAsync(IFormFile file);

    }
}
