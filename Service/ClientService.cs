using PestControlUts.Data;
using PestControlUts.Model;

namespace PestControlUts.Service
{
    public class ClientService
    {
        private readonly AppDbContext _db;
        public ClientService(AppDbContext db) => _db = db;
        public List<object> SetDropdown()
        {
            var list = _db.Clients.OrderBy(m => m.ClientName)
                .Select(m => new
                {
                    m.Id,
                    DisplayName = m.ClientId + " - " + m.ClientName
                })
                .ToList<object>();
            return list;
        }

        public Client? FindById(int id)
        {
            return _db.Clients.FirstOrDefault(x => x.Id == id);
        }

        public List<Clients> SetGrid()
        {
            return 
                _db.Clients.OrderByDescending(m=> m.ModDate).ToList<Client>();
        }

        public async void Update(Client client)
        {
            _db.Clients.Update(client);
            await _db.SaveChangesAsync();
        }
    }
}
