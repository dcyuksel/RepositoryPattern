using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Entities;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Controllers;

[Route("book")]
public class BookController(IGenericRepository<BookEntity> bookRepository) : ControllerBase
{
    [HttpGet]
    [Route("get-all")]
    public async Task<IReadOnlyList<BookEntity>> GetAll()
    {
        return await bookRepository.GetAllAsync();
    }

    [HttpGet]
    [Route("get")]
    public async Task<BookEntity> GetAll(long id)
    {
        return await bookRepository.GetByIdAsync(id);
    }

    [HttpPost]
    [Route("add")]
    public async Task Add(string name, string author, decimal price)
    {
        await bookRepository.AddAsync(new BookEntity { Name = name, Author = author, Price = price});
    }

    [HttpPost]
    [Route("update")]
    public async Task Update(BookEntity entity)
    {
        await bookRepository.UpdateAsync(entity);
    }

    [HttpPost]
    [Route("delete")]
    public async Task Delete(long id)
    {
        await bookRepository.DeleteAsync(id);
    }
}
