using EmployeeJobTitleLibrary.DataAccess;
using EmployeeJobTitleLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeJobTitleLibrary.DataAccess;

public class EmployeeManagement
{
    // Using Singleton Pattern
    private static EmployeeManagement instance = null;
    private static readonly object instanceLock = new object();
    private EmployeeManagement() { }

    public static EmployeeManagement Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new EmployeeManagement();
                }

                return instance;
            }
        }
    }

    public IEnumerable<EmployeeDto> GetEmployeeList()
    {
        List<EmployeeDto> employeesDto = new List<EmployeeDto>();
        try
        {
            var myStockDB = new EmployeeJobTitleContext();
            List<Employee> employees = myStockDB.Employees.ToList();

            foreach (var item in employees)
            {
                JobTitle jobTitle = myStockDB.JobTitles.SingleOrDefault(jt => jt.JobTitleId == item.JobTitleId);

                employeesDto.Add(new EmployeeDto
                {
                    EmployeeId = item.EmployeeId,
                    EmployeeName = item.EmployeeName,
                    YearOfBirth = item.YearOfBirth,
                    DepartmentName = item.DepartmentName,
                    JobTitleName = jobTitle.JobTitleName,
                    JobTitleDescription = jobTitle.JobTitleDescription,
                });
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return employeesDto;
    }

    public EmployeeDto GetEmployeeByID(string employeeID)
    {
        EmployeeDto employeeDto = null;
        try
        {
            var myStockDB = new EmployeeJobTitleContext();
            Employee employee = myStockDB.Employees.SingleOrDefault(e => e.EmployeeId == employeeID);

            if (employee == null)
            {
                return null;
            }

            JobTitle jobTitle = myStockDB.JobTitles.SingleOrDefault(jt => jt.JobTitleId == employee.JobTitleId);

            employeeDto = new EmployeeDto
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                YearOfBirth = employee.YearOfBirth,
                DepartmentName = employee.DepartmentName,
                JobTitleName = jobTitle.JobTitleName,
                JobTitleDescription = jobTitle.JobTitleDescription,
            };
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return employeeDto;
    }

    public void AddNew(EmployeeDto employee)
    {
        try
        {
            var myStockDB = new EmployeeJobTitleContext();

            myStockDB.Employees.Add(new Employee
            {
                EmployeeName = employee.EmployeeName,
                YearOfBirth = employee.YearOfBirth,
                DepartmentName = employee.DepartmentName
            });

            myStockDB.JobTitles.Add(new JobTitle
            {
                JobTitleName = employee.JobTitleName,
                JobTitleDescription = employee.JobTitleDescription,
            });

            myStockDB.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(EmployeeDto employee)
    {
        try
        {
            var myStockDB = new EmployeeJobTitleContext();
            Employee _employee = myStockDB.Employees.SingleOrDefault(e => e.EmployeeId == employee.EmployeeId);

            if (_employee == null)
            {
                throw new Exception("The employee does not already exist.");
            }

            _employee.EmployeeId = employee.EmployeeId;
            _employee.EmployeeName = employee.EmployeeName;
            _employee.YearOfBirth = employee.YearOfBirth;
            _employee.DepartmentName = employee.DepartmentName;

            JobTitle jobTitle = myStockDB.JobTitles.SingleOrDefault(jt => jt.JobTitleId == _employee.JobTitleId);

            jobTitle.JobTitleName = employee.JobTitleName;
            jobTitle.JobTitleDescription = employee.JobTitleDescription;

            myStockDB.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Remove(string employeeId)
    {
        try
        {
            var myStockDB = new EmployeeJobTitleContext();
            Employee _employee = myStockDB.Employees.SingleOrDefault(e => e.EmployeeId == employeeId);

            if (_employee == null)
            {
                throw new Exception("The employee does not already exist.");
            }

            myStockDB.Employees.Remove(_employee);
            myStockDB.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}