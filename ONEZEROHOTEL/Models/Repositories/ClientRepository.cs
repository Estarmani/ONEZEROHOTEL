using Microsoft.AspNetCore.Identity;

namespace ONEZEROHOTEL.Models.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public IEnumerable<Client> AllClient = new List<Client>()
        {
            new Client()
            {
                 Id = 1, FirstName = "Lucky", LastName = "Otono", Email = "lucky@gmail.com", Password = "password@1", ConfirmPassword = "password@1"
            },
            new Client()
            {
                Id = 2, FirstName = "Lisa", LastName = "Paul", Email = "lisa@gmail.com", Password = "password@1", ConfirmPassword = "password@1"
            }

        };

        public void WriteClient()
        {
            using (StreamWriter writer = new StreamWriter("Clentdata.txt", true))
            {
                foreach (var item in AllClient)
                {
                    writer.WriteLine($"|  {item.Id,-10}  |  {item.FirstName,-10}  |  {item.LastName,-10}  |  {item.Email,-10}  |  {item.Password,-10}");
                }

            }
        }
    }
}
