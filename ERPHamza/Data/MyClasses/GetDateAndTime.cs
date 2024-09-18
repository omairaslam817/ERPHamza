using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Reflection.Metadata;

namespace ERPHamza.Data.MyClasses
{
    public class GetDateAndTime
    {
        public static async Task Dateapi()
        {
            using (var httpClient = new HttpClient())
                try
                {
                    var response = await httpClient.GetAsync(constant.DateApi);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    JObject jsonObject = JObject.Parse(responseContent);

                    string time = (string)jsonObject["time"];
                    int day = (int)jsonObject["day"];
                    int month = (int)jsonObject["month"];
                    int year = (int)jsonObject["year"];
                    DateTime dateTime2=(DateTime)jsonObject["dateTime"];
                    DateTime dateTime = new DateTime(year, month, day);
                    string formattedDate = dateTime.ToString("dd/MM/yyyy");

                    constant.DateAndTime = formattedDate + time;
                    constant.OnlyTime =  time;
                    constant.DateOnly = dateTime;
                    constant.dateTime2 = dateTime2;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    
                }




        }
    }
}
