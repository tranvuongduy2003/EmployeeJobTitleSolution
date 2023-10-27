using EmployeeJobTitleLibrary.Models;

namespace EmployeeJobTitleLibrary.Repository.Contracts;

public interface IEmployeeRepository
{
    IEnumerable<EmployeeDto> GetEmployees();
    EmployeeDto GetEmployeeByID(string employeeId);
    void InsertEmployee(EmployeeDto employee);
    void DeleteEmployee(string employeeId);
    void UpdateEmployee(EmployeeDto employee);
}