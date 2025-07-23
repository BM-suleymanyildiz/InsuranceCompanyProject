using InsuranceCompanyProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace InsuranceCompanyProject.FollowApi
{
    public class InstagramApi
    {
        public async Task<int> GetInstagramProfileId(string username)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://instagram-api-fast-reliable-data-scraper.p.rapidapi.com/user_id_by_username?username={username}"),
                Headers =
        {
            { "x-rapidapi-key", "YOUR_RAPIDAPI_KEY" },
            { "x-rapidapi-host", "YOUR_RAPIDAPI_HOST" },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<InstagramUserIdViewModel.Rootobject>(body);
                return result.UserID; 
            }
        }

        public async Task<int> GetInstagramProfileData(int userId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://instagram-api-fast-reliable-data-scraper.p.rapidapi.com/profile?user_id={userId}"),
                Headers =
        {
            { "x-rapidapi-key", "YOUR_RAPIDAPI_KEY" },
            { "x-rapidapi-host", "YOUR_RAPIDAPI_HOST" },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<InstagramUserDataViewModel.Rootobject>(body);
                return result.follower_count; 
            }
        }



    }
}