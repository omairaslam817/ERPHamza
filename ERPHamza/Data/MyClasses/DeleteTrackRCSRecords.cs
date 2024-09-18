using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http;
using System.Text;

namespace ERPHamza.Data.MyClasses
{
    public static class DeleteTrackRCSRecords
    {
        public static async Task<bool> DeleteTRCSRecord(object data)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(data);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync(constant.DeleteTRCSRecords, content);

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
