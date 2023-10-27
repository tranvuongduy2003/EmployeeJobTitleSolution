using EmployeeJobTitleLibrary.DataAccess;
using EmployeeJobTitleLibrary.Models;
using EmployeeJobTitleLibrary.Repository.Contracts;

namespace EmployeeJobTitleLibrary.Repository;

public class AuthRepository : IAuthRepository
{
    public Dbaccount Login(string username, string password) => AuthManagement.Instance.Login(username, password);
}