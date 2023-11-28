using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace SeaStory.UI.AdminFoodManagement
{
    public class ImageDownloader
    {
        public static async Task<Image> LoadImageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Asynchronously get the response from the passed URL
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Throw an exception if not successful

                    // Asynchronously read the response as a Stream
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        // Create an Image from the stream and return it
                        return Image.FromStream(stream);
                    }
                }
                catch (HttpRequestException e)
                {
                    // Log the exception, handle it, or rethrow as needed
                    throw new InvalidOperationException("Error downloading image.", e);
                }
            }
        }
    }
}
