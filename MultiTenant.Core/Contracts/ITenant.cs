namespace MultiTenant.Core.Contracts;

public interface ITenant
{
    public string TenantId { get; set; }
}
