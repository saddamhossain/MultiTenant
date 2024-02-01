namespace MultiTenant.Core.Entities;

public class Product : BaseEntity, ITenant
{
    public Product(string name, string description, int rate)
    {
        Name = name;
        Description = description;
        Rate = rate;
    }

    protected Product()
    {
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Rate { get; private set; }
    public string TenantId { get; set; }
}
