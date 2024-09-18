using Microsoft.AspNetCore.Components;
using MudBlazor;
using Newtonsoft.Json;
using static ERPHamza.Pages.JobsRow2.AvalMeasureCheckboxDialog;
using System.Text;

namespace ERPHamza.Data.MyClasses
{
    public class UpdateBookedClass
    {

        public static async Task UpdateBookedInstallStatus(int formid, int statusid, string name)

        {

            using (var httpClient = new HttpClient())
                try
                {

                    var url = constant.BaseUrl + "job/UpdateBooked?formid=" + formid + "&statusid=" + statusid + "&name="+ name;
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
                    //Snackbar.Add("try Catch Error: " + ex.Message, Severity.Error);
                }

        }

    }
}
