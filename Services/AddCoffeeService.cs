namespace ApplicationDevelopmentCW.Services;

public class AddCoffeeService : IAddCoffeeService
{
    private readonly IList<AddCoffee> _addCoffee;

    public AddCoffeeService()
    {
        _addCoffee = new List<AddCoffee> {
            new AddCoffee("Wash Clothes"),
            new AddCoffee("Clean Desk")
        };
    }
    public void Add(AddCoffee item)
    {
        _addCoffee.Add(item);
    }

    public IEnumerable<AddCoffee> GetAll()
    {
        return _addCoffee.ToList();
    }

    public void Delete(AddCoffee item)
    {
        _addCoffee.Remove(item);
    }

    public void Complete(AddCoffee item)
    {
        item.Completed = true;
    }

    public void Uncomplete(AddCoffee item)
    {
        item.Completed = false;
    }
}

