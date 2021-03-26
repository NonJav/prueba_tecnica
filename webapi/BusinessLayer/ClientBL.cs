using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BusinessLayer.Implement
{
    public class ClientBL
    {
        public async Task<Client> CreateClient(Client client) 
        {

            using(var context = new ContextBD()) 
            {
                context.CLIENT.Add(client);
                await context.SaveChangesAsync();

                return client;
            }

        }

        public async Task<List<Client>> GetClients() 
        {
            using(var context = new ContextBD()) 
            {
                return await context.CLIENT.ToListAsync();
            }
        }

        public async Task<Client> GetClient(int clientId) {
            using(var context = new ContextBD())
            {
                return await context.CLIENT.FindAsync(clientId);
            }
        }

        public async Task<Client> UpdateClient(Client client) 
        {
            using(var context = new ContextBD()) 
            {
                var clientBD = await context.CLIENT.FindAsync(client.id);
                context.Entry(clientBD).CurrentValues.SetValues(client);
                await context.SaveChangesAsync();
                return clientBD;
            }
        }

        public async Task<bool> DeleteClient(Client client) 
        {
            using(var context = new ContextBD()) 
            {
                context.Remove(client);
                return await context.SaveChangesAsync() > 0;
            }
        }
    }
}
