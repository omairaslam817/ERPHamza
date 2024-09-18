using MudBlazor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ERPHamza.Data.MyClasses
{
    public static class AuditClasss
    {

      public  static async Task Audit(int formid, string ActionBy, DateTime Adate, string action)

        {

            using (var httpClient = new HttpClient())
                try
                {
                    var url = constant.BaseUrl + "job/audit?formid=" + formid + "&ActionBy=" + constant.LoginUserName + "&ADate=" + Adate + "&Action=" + action;
                    // var response = await httpClient.PostAsync(url, new { });
                    var response = await httpClient.PostAsJsonAsync(url, new { });
                    if (response.IsSuccessStatusCode)
                    {
                        var message = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        var errorMessage = await response.Content.ReadAsStringAsync();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

        }

    }
}
