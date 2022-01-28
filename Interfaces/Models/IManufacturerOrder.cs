namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IManufacturerOrder
    {
        void Add();
        void Update();
        void Delete();
        void CalculateTotal();
    }
}
