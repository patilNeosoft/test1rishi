using UserRegistration1.Model;

namespace UserRegistration1.Repository
{
    internal interface IFile1
    {
        void WriteData(User user, string filename);
       List<string> ReadData(string filename);

       bool IsRegister(string username, string filename);
    }
}