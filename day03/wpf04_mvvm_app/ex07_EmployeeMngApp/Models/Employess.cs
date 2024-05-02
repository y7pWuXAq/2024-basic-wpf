using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07_EmployeeMngApp.Models
{
    public class Employess
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
        public string Addr { get; set; }

        public static readonly string SELECT_QUERY = @"SELECT [Id]
                                                            , [EmpName]
                                                            , [Salary]
                                                            , [DeptName]
                                                            , [Address]
                                                         FROM [dbo].[Employees]";

        public static readonly string INSERT_QUERY = @"INSERT INTO [dbo].[Employees]
                                                            ( [EmpName]
                                                            , [Salary]
                                                            , [DeptName]
                                                            , [Address])
                                                       VALUES
                                                            ( @EmpName
                                                            , @Salary
                                                            , @DeptName
                                                            , @Address)";

        public static readonly string UPDEATE_QUERY = @"UPDATE [dbo].[Employees]
                                                           SET [EmpName] = @EmpName
                                                             , [Salary] = @Salary
                                                             , [DeptName] = @DeptName
                                                             , [Address] = @Address
                                                         WHERE Id = @Id";

        public static readonly string DELETE_QUERY = @"DELETE FROM [dbo].[Employees] WHERE Id = @Id";
    }
}
