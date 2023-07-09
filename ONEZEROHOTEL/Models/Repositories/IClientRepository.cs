namespace ONEZEROHOTEL.Models.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> AllClient { get; }

        Client CreateClient(Client client);
        void WriteClient(Client client);
        
    }
}