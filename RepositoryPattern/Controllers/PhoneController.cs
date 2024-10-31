using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Entities;
using RepositoryPattern.Repositories;

namespace RepositoryPattern.Controllers;

[Route("phone")]
public class PhoneController(IGenericRepository<PhoneEntity> phoneRepository) : ControllerBase
{
    [HttpGet]
    [Route("get-all")]
    public async Task<IReadOnlyList<PhoneEntity>> GetAll()
    {
        return await phoneRepository.GetAllAsync();
    }

    [HttpGet]
    [Route("get")]
    public async Task<PhoneEntity> GetAll(long id)
    {
        return await phoneRepository.GetByIdAsync(id);
    }

    [HttpPost]
    [Route("add")]
    public async Task Add(string brand, string model, decimal price)
    {
        await phoneRepository.AddAsync(new PhoneEntity { Brand = brand, Model = model, Price = price});
    }

    [HttpPost]
    [Route("update")]
    public async Task Update(PhoneEntity entity)
    {
        await phoneRepository.UpdateAsync(entity);
    }

    [HttpPost]
    [Route("delete")]
    public async Task Delete(long id)
    {
        await phoneRepository.DeleteAsync(id);
    }
}
