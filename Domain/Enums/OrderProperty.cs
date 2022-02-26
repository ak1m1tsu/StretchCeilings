using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Enums
{
    /// <summary>
    /// Presents <see cref="Order"/> properties
    /// </summary>
    public enum OrderProperty
    {
        Id,
        CustomerId,
        DatePlaced,
        PaidByCash,
        Status,
        Total
    }
}