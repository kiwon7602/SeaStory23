using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace SeaStory
{
    public class WebSocketClient
    {
        private readonly ClientWebSocket _webSocket = new ClientWebSocket();
        private readonly Uri _serverUri;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        public event Action<string> MessageReceived;


        public WebSocketClient(string uri)
        {
            _serverUri = new Uri(uri);
        }

        public async Task ConnectAsync()
        {
            await _webSocket.ConnectAsync(_serverUri, _cancellationTokenSource.Token);
            StartListening();
        }

        private async void StartListening()
        {
            var buffer = new byte[1024 * 4];

            try
            {
                while (_webSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), _cancellationTokenSource.Token);
                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    OnMessageReceived(message);
                }
            }
            catch (WebSocketException)
            {
                // Handle the exception (e.g., reconnect logic)
            }
        }

        protected virtual void OnMessageReceived(string message)
        {
            MessageReceived?.Invoke(message);
        }

        public async Task SendAsync(string message)
        {
            if (_webSocket.State != WebSocketState.Open)
            {
                throw new InvalidOperationException("Connection is not open.");
            }

            var bytes = Encoding.UTF8.GetBytes(message);
            await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, _cancellationTokenSource.Token);
        }

        public async Task CloseAsync()
        {
            if (_webSocket != null && _webSocket.State == WebSocketState.Open)
            {
                // Close the WebSocket connection gracefully
                await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Client closing the connection", CancellationToken.None);
            }

            // Dispose the WebSocket only after it has been closed
            _webSocket?.Dispose();

            // Cancel any ongoing tasks (like listening for messages)
            _cancellationTokenSource.Cancel();
        }
    }
}
