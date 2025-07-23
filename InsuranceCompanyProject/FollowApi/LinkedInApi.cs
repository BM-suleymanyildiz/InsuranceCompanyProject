using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using InsuranceCompanyProject.Models;
using Newtonsoft.Json;


namespace InsuranceCompanyProject.FollowApi
{
    public class LinkedInApi
    {
        public async Task<int> GetLinkedInProfiles()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://linkedin-scraper-api-real-time-fast-affordable.p.rapidapi.com/profile/detail?username=USERNAME"),
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

                var result = JsonConvert.DeserializeObject<LinkedInViewModel.Rootobject>(body);


                return result?.data?.basic_info?.follower_count ?? 0;
            }
        }
    }
}