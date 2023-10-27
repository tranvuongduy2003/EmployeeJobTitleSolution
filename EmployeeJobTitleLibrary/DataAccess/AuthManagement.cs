using EmployeeJobTitleLibrary.DataAccess;
using EmployeeJobTitleLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EmployeeJobTitleLibrary.DataAccess;

public class AuthManagement
{
    // Using Singleton Pattern
    private static AuthManagement instance = null;
    private static readonly object instanceLock = new object();
    private AuthManagement() { }

    public static AuthManagement Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new AuthManagement();
                }

                return instance;
            }
        }
    }

    public Dbaccount Login(string username, string password)
    {
        Dbaccount account = null;
        try
        {
            var myStockDB = new EmployeeJobTitleContext();
            account = myStockDB.Dbaccounts.SingleOrDefault(a => a.AccountId == username);
            if (account == null)
            {
                throw new Exception("The account does not already exist.");
            }
            if (account.AccountPassword != password)
            {
                throw new Exception("Password is wrong");
            }
            return account;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}