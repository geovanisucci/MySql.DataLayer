using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql.DataLayer.UnitTest.GivenRepository.When_CreateAsync_Is_Called
{
    [TestClass]
    public class And_Create_Happens
    {
        [TestMethod]
        public void Should_Return_Success()
        {
            int result = 0;

            string sqlCommand = "SELECT IFNULL((SELECT 1 FROM information_schema.tables WHERE table_schema = 'mysqlcoretest' AND table_name = 'foo' LIMIT 1),0) as TableExist;";

            //Execute SQL Query
            //using (var c = _connectionFactory.GetAsync().Result)
            //{
            //    result = c.ExecuteScalarAsync<int>(sqlCommand.ToString()).Result;
            //}

            Assert.IsTrue(result == 1);
        }
    }
}
