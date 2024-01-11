namespace ApplicationDevelopmentCW.Services;

public interface IAddCoffeeService
{
    public void Add(AddCoffee item);
    public IEnumerable<AddCoffee> GetAll();
    public void Delete(AddCoffee item);
    public void Complete(AddCoffee item);
    public void Uncomplete(AddCoffee item);
}