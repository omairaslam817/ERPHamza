using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
namespace ERPHamza.Data.MyClasses
{
    public class UpdateCHKL
    {
        public static async Task<bool> UpdateCHKList(object data)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync(constant.UpdateCHKL, content);

                    return response.IsSuccessStatusCode;
                }
                catch (Exception e)
                {
                    
                    return false;
                }
            }
        }


    }
}

