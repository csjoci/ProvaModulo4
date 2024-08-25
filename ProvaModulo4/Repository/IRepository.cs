namespace ProvaModulo4.CleanArch.Domain.Repository;

public interface IRepository<T>
{

    public void Add(T entity);
    public void Update(T entity);
    public void Delete(int id);
    public List<T> GetAll();
    public T GetById(int id);
}
