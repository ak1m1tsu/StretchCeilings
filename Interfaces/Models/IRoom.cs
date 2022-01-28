namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IRoom
    {
        void Add();
        void Update();
        void Delete();
        string GetPlane();
        void SetPlane(string path);
    }
}
