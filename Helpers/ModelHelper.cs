using StretchCeilings.Models;

namespace StretchCeilings.Helpers
{
    public static class ModelHelper
    {
        public static bool AreFieldsNullOrWitherSpace(this Manufacturer manufacturer)
        {
            return string.IsNullOrWhiteSpace(manufacturer.Address) ||
                   string.IsNullOrWhiteSpace(manufacturer.Name) ||
                   manufacturer.Country is null;
        }
    }
}
