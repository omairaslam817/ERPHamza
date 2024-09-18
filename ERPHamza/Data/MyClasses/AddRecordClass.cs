using MudBlazor;
using MudBlazor.Interfaces;

namespace ERPHamza.Data.MyClasses
{
    public static class AddRecordClass
    {
        public static   async Task<bool> AddRecordInFormJob(int formid, int statusid)
        {

            using (var httpClient = new HttpClient())
                try
                {

                    var url = constant.BaseUrl + "job/AddRecordInFormJob?formid=" + formid + "&statusid=" + statusid;
                    var response = await httpClient.PostAsJsonAsync(url, new { });
                    if (response.IsSuccessStatusCode)
                    {
                       

                        var message = await response.Content.ReadAsStringAsync();
						return true;
					}
                    else
                    {
                        
                        var errorMessage = await response.Content.ReadAsStringAsync();
						return false;
					}


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
					return false;
				}

        }
    }
}
