using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CustomerApi.Repositories
{
    public class CustomerRepository
    {
        public void Create(string forename, string surname, string title, int age)
        {
            using (var connection =
                new SqlConnection("Server=(LocalDb)\\MSSQLLocalDB;Database=Customers;User Id=jamilTest;Password=test123;"))
            {
                connection.Open();
//                var sqlStatement = @"
//INSERT INTO [dbo].[Users]
//           ([Forename]
//           ,[Surname]
//           ,[Title]
//           ,[Age])
//     VALUES
//           (@Forename
//           ,@Surname
//           ,@Title
//           ,@Age)";
                var sqlStatement = @$"
                    INSERT INTO [dbo].[Users]
                               ([Forename]
                               ,[Surname]
                               ,[Title]
                               ,[Age])
                         VALUES
                               ('{forename}'
                               ,'{surname}'
                               ,'{title}'
                               ,{age})";
                connection.Execute(sqlStatement);
            }
        }
    }
}
