using EmployeeJobTitleLibrary.Models;

namespace EmployeeJobTitleLibrary.Repository.Contracts;

public interface IAuthRepository
{
    Dbaccount Login(string username, string password);
}