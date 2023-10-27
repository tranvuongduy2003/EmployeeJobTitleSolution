using EmployeeJobTitleLibrary.DataAccess;
using EmployeeJobTitleLibrary.Models;
using EmployeeJobTitleLibrary.Repository.Contracts;

namespace EmployeeJobTitleLibrary.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    public IEnumerable<EmployeeDto> GetEmployees() => EmployeeManagement.Instance.GetEmployeeList();

    public EmployeeDto GetEmployeeByID(string employeeId) => EmployeeManagement.Instance.GetEmployeeByID(employeeId);

    public void InsertEmployee(EmployeeDto employee) => EmployeeManagement.Instance.AddNew(employee);

    public void DeleteEmployee(string employeeId) => EmployeeManagement.Instance.Remove(employeeId);

    public void UpdateEmployee(EmployeeDto employee) => EmployeeManagement.Instance.Update(employee);
}