namespace HospitalProjectClasses
{
    public interface IAuthenticable
    {
        bool Login(string username, string password);
    }
}
