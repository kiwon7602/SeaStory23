using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeaStory 
{
    public class ClientWrapper
    {
        private static Lazy<Task<ClientWrapper>> _instance =
                    new Lazy<Task<ClientWrapper>>(() => CreateAsync(), true);

        private WebSocketClient webSocketClient;

        private ClientWrapper()
        {
            webSocketClient = new WebSocketClient("ws://3.38.221.167:8765");
        }
        public static Task<ClientWrapper> Instance => _instance.Value;

        public static async Task<ClientWrapper> CreateAsync()
        {
            var wrapper = new ClientWrapper();
            await wrapper.webSocketClient.ConnectAsync();
            return wrapper;
        }

        public async Task CloseAsync()
        {
            await webSocketClient.CloseAsync();
        }

        public async Task ReserveUserAsync(string user_id, int seat_num)
        {
            var message = new
            {
                command = "reserve",
                user_id = user_id,
                seat_num = seat_num
            };
            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        public async Task ActivateUserAsync(string user_id, int seat_num)
        {
            var message = new
            {
                command = "add",
                user_id = user_id,
                seat_num = seat_num
            };

            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }

        public async Task DeactivateUserAsync(string user_id, int seat_num)
        {
            var message = new
            {
                command = "delete",
                user_id = user_id,
                seat_num = seat_num
            };

            string jsonMessage = JsonSerializer.Serialize(message);
            await webSocketClient.SendAsync(jsonMessage);
        }
    }
}
