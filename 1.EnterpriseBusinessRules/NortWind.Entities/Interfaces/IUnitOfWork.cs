namespace NortWind.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        ValueTask SaveChanges();
    }
}