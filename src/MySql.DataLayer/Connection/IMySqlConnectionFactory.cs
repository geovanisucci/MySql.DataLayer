namespace MySql.DataLayer.Connection
{
    using System.Threading.Tasks;
    using MySql.Data.MySqlClient;
    /// <summary>
    /// Interface that will represents the MySql connection factory..
    /// </summary>
    public interface IMySqlConnectionFactory
    {
        /// <summary>
        /// Open connection asynchronous.
        /// </summary>
        /// <returns>MySqlConnection completed.</returns>
        Task<MySqlConnection> GetAsync(string databaseName = null);
    }
}
