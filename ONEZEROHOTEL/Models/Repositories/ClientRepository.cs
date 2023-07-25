using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ONEZEROHOTEL.Context;
using ONEZEROHOTEL.Helper;

namespace ONEZEROHOTEL.Models.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IConfiguration _configuration;
        private readonly StayCationDbContext _stayCationDbContext;
        public ClientRepository(IConfiguration configuration, StayCationDbContext stayCationDbContext)
        {
            _configuration = configuration;
            _stayCationDbContext = stayCationDbContext;
        }

        public IEnumerable<vClient> AllClient => new List<vClient>()
        {
            new vClient()
            {
                 Id = 1, FirstName = "Lucky", LastName = "Otono", Email = "lucky@gmail.com", Password = "password@1", ConfirmPassword = "password@1"
            },
            new vClient()
            {
                Id = 2, FirstName = "Lisa", LastName = "Paul", Email = "lisa@gmail.com", Password = "password@1", ConfirmPassword = "password@1"
            }

        };
        public void AddClient(Client client)
        {
            var ClientId = IncrementID.GetNextId();
            _stayCationDbContext.Clients.Add(client);
            _stayCationDbContext.SaveChanges();
        }
       /* public vClient CreateClient(vClient client)
        {
            var ClientId = IncrementID.GetNextId();
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            using(var con = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Client(Id, FirstName, LastName, Email, Password)" + "VALUES (@Id, @FirstName, @LastName, @Email, @Password)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Id", ClientId);
                cmd.Parameters.AddWithValue("@FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("@LastName", client.LastName);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Password", client.Password);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return client;
        }*/

        public void WriteClient(vClient client)
        {
            using (StreamWriter writer  = new StreamWriter("Clentdata.txt", true))
            { 
                foreach (var item in AllClient)
                {
                    writer.Write($"|  {item.Id,-10}  |  {item.FirstName,-10}  |  {item.LastName,-10}  |  {item.Email,-10}  |  {item.Password,-10}");
                }

            }
        }
    }
}
