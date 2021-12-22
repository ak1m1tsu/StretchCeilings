namespace stretch_ceilings_app.Interfaces
{
    public interface IRoom
    {
        string GetPlane();
        string AddPlane(string path);
        string ChangePlane(string path);
    }
}
