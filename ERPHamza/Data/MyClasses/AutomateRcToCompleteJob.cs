using MudBlazor;
using Newtonsoft.Json;
using static ERPHamza.Pages.JobsRow5.RCInstructed;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
namespace ERPHamza.Data.MyClasses
{
    public class AutomateRcToCompleteJob
    {

        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _httpClient;

        public AutomateRcToCompleteJob(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }


        public List<ModelRoot> formList = new List<ModelRoot>();
        public class JobFormRecord
        {
            public int Id { get; set; }
            public string RefNo { get; set; }
            public string LeadGenerator { get; set; }
            public string Scheme { get; set; }
            public string Surname { get; set; }
            public string Forename { get; set; }
            public string DOB { get; set; }
            public string PropertyNo { get; set; }
            public string AddressLine1 { get; set; }
            public string Town { get; set; }
            public string Postcode { get; set; }
            public object JobNote { get; set; } // Adjust the type as per actual JSON structure
        }

        public class TrackRCSRecord
        {
            public int Id { get; set; }
            public int FormNo { get; set; }
            public int StateId { get; set; }
            public object CurrentSId { get; set; } // Adjust the type as per actual JSON structure
            public bool IsBooked { get; set; }
            public string Name { get; set; }
        }

        public class ModelRoot
        {
            public int Id { get; set; }
            public int FormId { get; set; }
            public int Status { get; set; }
            public JobFormRecord JobFormRecord { get; set; }
            public List<TrackRCSRecord> TrackRCSRecords { get; set; }
        }

        public static DateTime londonTime ;
        public static void CountTrackRCSRecords(List<ModelRoot> formList)
        {
            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
            londonTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, londonTimeZone);

            foreach (var form in formList)
            {
                int totalRecords = form.TrackRCSRecords.Count;
                int bookedRecords = form.TrackRCSRecords.Count(record => record.IsBooked);
                if (totalRecords == bookedRecords)
                    {
                        var myid = form.FormId;
                        var dataToSend = form.TrackRCSRecords.Select(q => new { q.Id }).ToList();
                    
                        DeleteTrackRCSRecords.DeleteTRCSRecord(dataToSend);

                        DeleteRecordClass.DeleteRecordInFormJob(myid, 17);
                        AddRecordClass.AddRecordInFormJob(myid, 18);
                        AuditClasss.Audit(myid, constant.LoginUserName, londonTime, "Project Complete");
                    }

            }
        }
        public  async Task Form1BySat17()
        {
            try
            {
                var response = await _httpClient.GetAsync(constant.GetJobForRcInst);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var formList = JsonConvert.DeserializeObject<List<ModelRoot>>(jsonString).ToList();

                    CountTrackRCSRecords(formList);
                    _navigationManager.NavigateTo("/RCInstructed", forceLoad: true);
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                // Handle the exception
            }
        }

    }
}
