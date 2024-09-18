using MudBlazor;

namespace ERPHamza.Data.MyClasses
{
    public static class DeleteRecordClass
    {
        public static async Task DeleteRecordInFormJob(int formid, int statusid)

        {

            using (var httpClient = new HttpClient())
                try
                {

                    var url = constant.BaseUrl + "job/DeleteRecordInFormJob?formid=" + formid + "&statusid=" + statusid;
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
