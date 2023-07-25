using ONEZEROHOTEL.Context;

namespace ONEZEROHOTEL.Models.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<vClient> AllClient { get; }

        //vClient CreateClient(vClient client);
        void WriteClient(vClient client);
        void AddClient(Client client);
    }
}