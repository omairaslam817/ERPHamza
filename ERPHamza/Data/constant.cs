using Microsoft.AspNetCore.SignalR;
using static ERPHamza.Pages.JobsRow1.ListOfBookedSurvey;

namespace ERPHamza.Data
{
    public class constant
    {

        //public static string BaseUrl = "http://localhost/ERP_Hamza_API/api/";
        public static string BaseUrl = "https://localhost:44364/api/";

       // public static string BaseUrl = "https://api.energysaviour.software/api/";

        public static string Login = BaseUrl + "Auth/login";
        public static string Register = BaseUrl + "Auth/Register";

        public static string Addform1 = BaseUrl + "job/AddJob";


        public static string UpdateJob = BaseUrl + "job/UpdateJob"; //update status 2 
        public static string UpdateJobBooked = BaseUrl + "job/UpdateJobBooked"; //update status to 3
        public static string UpdateJobBooked4 = BaseUrl + "job/UpdateJobTo4"; //update status to 4
        public static string UpdateJobBooked5 = BaseUrl + "job/UpdateJobTo5"; //update status to 5
        public static string UpdateJobBooked6 = BaseUrl + "job/UpdateJobTo6"; //update status to 6
        public static string UpdateJobBooked7 = BaseUrl + "job/UpdateJobTo7"; //update status to 7
        public static string UpdateJobBooked8 = BaseUrl + "job/UpdateJobTo8"; //update status to 8
        public static string UpdateJobBooked9 = BaseUrl + "job/UpdateJobTo9"; //update status to 9
        public static string UpdateJobBooked10 = BaseUrl + "job/UpdateJobTo10"; //update status to 10
        public static string UpdateJobBooked17 = BaseUrl + "job/UpdateJobTo17"; //update status to 17
        public static string UpdateJobBooked18 = BaseUrl + "job/UpdateJobTo18"; //update status to 18
        public static string UpdateJobBooked19 = BaseUrl + "job/UpdateJobTo19"; //update status to 19
        public static string UpdateJobBooked20 = BaseUrl + "job/UpdateJobTo20"; //update status to 20
        public static string UpdateJobBooked21 = BaseUrl + "job/UpdateJobTo21"; //update status to 21
        public static string UpdateJobBooked22 = BaseUrl + "job/UpdateJobTo22"; //update status to 22
        public static string UpdateJobBooked23 = BaseUrl + "job/UpdateJobTo23"; //update status to 23
        public static string UpdateJobBooked24 = BaseUrl + "job/UpdateJobTo24"; //update status to 24
        public static string UpdateFullPaid50 = BaseUrl + "job/UpdateFullPaid50"; //update status to 50

        public static string UpdateJobToIPAD25 = BaseUrl + "job/UpdateJobToIPAD25"; //update status to 24
        public static string UpdateJobToIPAD26 = BaseUrl + "job/UpdateJobToIPAD26"; //update status to 24

        public static string Form1BySatId = BaseUrl + "job/Form1BySatId"; //
        public static string DeleteTRCSRecords = BaseUrl + "job/DeleteTRCSRecords"; //

        public static string UpdateCHKL = BaseUrl + "job/UpdateCHKL"; //
        public static string AutoIdsDelete = BaseUrl + "job/AutoIdsDelete"; //
        public static string UpdateJobFunderName2 = BaseUrl + "job/UpdateJobFunderName2"; //




        public static string AddFQ = BaseUrl + "FunderQ/AddFQ";
        public static string GetFQList = BaseUrl + "FunderQ/GetFQList";
        public static string FQUpdateStatus = BaseUrl + "FunderQ/UpdateStatus";
        public static string UpdateStatusToDone = BaseUrl + "FunderQ/UpdateStatusToDone";
        public static string SaveFQItemsList = BaseUrl + "FunderQ/SaveFQItemsList";
        public static string SaveTMQItemsList = BaseUrl + "job/SaveTMQItemsList"; //

        public static string GetRefAddress = BaseUrl + "job/GetRefAddress"; //



        #region Member APIs
        public static string SaveMemeber = BaseUrl + "Member/AddMember"; //update status to 24
        public static string GetMemberListByType = BaseUrl + "Member/GetMemberListByType";
        public static string GetMemberNamesByType = BaseUrl + "Member/GetMemberNamesByType";
        #endregion

        #region Check List APIs
        public static string GetCheckList1 = BaseUrl + "CheckList/GetCheckList1";
        public static string GetCheckList2 = BaseUrl + "CheckList/GetCheckList2";
        public static string GetCheckList3 = BaseUrl + "CheckList/GetCheckList3";
        public static string GetCheckList4 = BaseUrl + "CheckList/GetCheckList4";
        public static string GetCheckList5 = BaseUrl + "CheckList/GetCheckList5";
        public static string GetCheckList6 = BaseUrl + "CheckList/GetCheckList6";
        public static string GetCheckList7 = BaseUrl + "CheckList/GetCheckList7";
        public static string GetCheckList8 = BaseUrl + "CheckList/GetCheckList8";

        public static string AddCheckLists = BaseUrl + "CheckList/AddCheckLists";// can be use for all Chk list
        public static string GetCheckListDataByFormId = BaseUrl + "CheckList/GetCheckListDataByFormId";// can be use for all Chk list

        #endregion


        #region JobStages
        public static string GetCheckListStatus = BaseUrl + "JobStages/GetCheckListStatus"; //get by status 3
        public static string UpdateCheckList = BaseUrl + "JobStages/UpdateCheckList";
        #endregion

        #region SideBar APIs
        public static string FindByLeadGen = BaseUrl + "SideBar/FindByLeadGen";
        public static string FindByPassInstaName = BaseUrl + "SideBar/FindByPassInstaName";
        public static string FindByLoftName = BaseUrl + "SideBar/FindByLoftName";
        public static string FindAshipName = BaseUrl + "SideBar/FindAshipName";
        public static string FindByBoilerName = BaseUrl + "SideBar/FindByBoilerName";
        public static string FindByEWIName = BaseUrl + "SideBar/FindByEWIName";
        public static string FindByHCName = BaseUrl + "SideBar/FindByHCName";
        public static string FindByIWIName = BaseUrl + "SideBar/FindByIWIName";
        public static string FindByRIRName = BaseUrl + "SideBar/FindByRIRName";
        public static string FindBySolarName = BaseUrl + "SideBar/FindBySolarName";
        public static string GetJobData = BaseUrl + "SideBar/GetJobData";//by id
        public static string UpdateJobNote = BaseUrl + "SideBar/UpdateJobNote";//by id
        public static string AddJobNote = BaseUrl + "SideBar/AddJobNote";//by id
        #endregion

        #region User Portal
        public static string AddRights = BaseUrl + "UserPortal/AddRights";

        #endregion





        public static string UpdateJobToPassInsta = BaseUrl + "job/UpdateJobToPassInsta";
        public static string UpdateJobToPassInstaTo28 = BaseUrl + "job/UpdateJobToPassInstaTo28";

        public static string UpdateJobToLOFT = BaseUrl + "job/UpdateJobToLOFT";
        public static string UpdateJobToLOFT29 = BaseUrl + "job/UpdateJobToLOFT29";

        public static string UpdateJobToRIR = BaseUrl + "job/UpdateJobToRIR";
        public static string UpdateJobToRIR30 = BaseUrl + "job/UpdateJobToRIR30";

        public static string UpdateJobToEWI = BaseUrl + "job/UpdateJobToEWI";
        public static string UpdateJobToEWITo27 = BaseUrl + "job/UpdateJobToEWITo27"; //update status to 24

        public static string UpdateJobToIWI = BaseUrl + "job/UpdateJobToIWI";
        public static string UpdateJobToIWITo31 = BaseUrl + "job/UpdateJobToIWITo31";

        public static string UpdateJobToBoiler = BaseUrl + "job/UpdateJobToBoiler";
        public static string UpdateJobToBoilerTo32 = BaseUrl + "job/UpdateJobToBoilerTo32";

        public static string UpdateJobToHC = BaseUrl + "job/UpdateJobToHC";
        public static string UpdateJobToHC33 = BaseUrl + "job/UpdateJobToHC33";

        public static string UpdateJobToSolar = BaseUrl + "job/UpdateJobToSolar";
        public static string UpdateJobToSolar34 = BaseUrl + "job/UpdateJobToSolar34";

        public static string UpdateJobToAshp = BaseUrl + "job/UpdateJobToAshp";
        public static string UpdateJobToAshp35 = BaseUrl + "job/UpdateJobToAshp35";

        //public static string GetAllform1 = BaseUrl + "job/AllForm";

        public static string AllFormsCount = BaseUrl + "job/AllFormsCount";
        public static string SingleFormsCount = BaseUrl + "job/SingleFormsCount";
        public static string form1refno = BaseUrl + "job/form1refno";
        public static string FindByRefNo = BaseUrl + "job/FindByRefNo";
        public static string FindByRefNo2 = BaseUrl + "job/FindByRefNo2";
        public static string AddMeasures = BaseUrl + "job/AddMeasures";

        public static string AssignToInspection = BaseUrl + "job/AssignToInspection";
        public static string UpdateAssignedJobStatus = BaseUrl + "job/UpdateAssignedJobStatus";

        public static string GetMemberList = BaseUrl + "Member/GetMemberList";
        public static string GetLDGen = BaseUrl + "Member/GetLDGen";
        public static string GetMeasure = BaseUrl + "Member/GetMeasure";
        public static string GetSurveyorName = BaseUrl + "Member/GetSurveyorName";
        public static string GetPASSInstallerName = BaseUrl + "Member/GetPASSInstallerName";
        public static string GetLOFTInstallerName = BaseUrl + "Member/GetLOFTInstallerName";
        public static string GetRIRInstallerName = BaseUrl + "Member/GetRIRInstallerName";
        public static string GetIWIInstallerName = BaseUrl + "Member/GetIWIInstallerName";
        public static string GetEWIInstallerName = BaseUrl + "Member/GetEWIInstallerName";
        public static string GetBoilerInstallerName = BaseUrl + "Member/GetBoilerInstallerName";
        public static string GetHCInstallerName = BaseUrl + "Member/GetHCInstallerName";
        public static string GetSolarPvInstallerName = BaseUrl + "Member/GetSolarPvInstallerName";
        public static string GetASHPInstallerName = BaseUrl + "Member/GetASHPInstallerName";
        public static string GetRetrifitAssessorName = BaseUrl + "Member/GetRetrifitAssessorName";
        public static string GetRetrofitCoordinator = BaseUrl + "Member/GetRetrofitCoordinator";
        public static string GetFunderName = BaseUrl + "Member/GetFunderName";
        public static string GetCompanyName = BaseUrl + "Member/GetCompanyName";

        public static string AddMultipleRecordInFormJob = BaseUrl + "job/AddMultipleRecordInFormJob";

        public static string Form1BySat1 = BaseUrl + "job/Form1BySat1";
        public static string Form1BySat2 = BaseUrl + "job/Form1BySat2";
        public static string Form1BySat3 = BaseUrl + "job/Form1BySat3";
        public static string Form1BySat4 = BaseUrl + "job/Form1BySat4";
        public static string Form1BySat5 = BaseUrl + "job/Form1BySat5";
        public static string Form1BySat6 = BaseUrl + "job/Form1BySat6";
        public static string Form1BySat7 = BaseUrl + "job/Form1BySat7";
        public static string Form1BySat8 = BaseUrl + "job/Form1BySat8";
        public static string Form1BySat9 = BaseUrl + "job/Form1BySat9";
        public static string Form1BySat10 = BaseUrl + "job/Form1BySat10";
        public static string Form1BySat11 = BaseUrl + "job/Form1BySat11";
        public static string Form1BySat12 = BaseUrl + "job/Form1BySat12";
        public static string Form1BySat13 = BaseUrl + "job/Form1BySat13";
        public static string Form1BySat14 = BaseUrl + "job/Form1BySat14";
        public static string Form1BySat15 = BaseUrl + "job/Form1BySat15";
        public static string Form1BySat16 = BaseUrl + "job/Form1BySat16";
        public static string Form1BySat17 = BaseUrl + "job/Form1BySat17";
        public static string Form1BySat18 = BaseUrl + "job/Form1BySat18";
        public static string Form1BySat19 = BaseUrl + "job/Form1BySat19";
        public static string Form1BySat20 = BaseUrl + "job/Form1BySat20";
        public static string Form1BySat21 = BaseUrl + "job/Form1BySat21";
        public static string Form1BySat22 = BaseUrl + "job/Form1BySat22";
        public static string Form1BySat23 = BaseUrl + "job/Form1BySat23";
        public static string Form1BySat24 = BaseUrl + "job/Form1BySat24";
        public static string Form1BySat25 = BaseUrl + "job/Form1BySat25";
        public static string Form1BySat26 = BaseUrl + "job/Form1BySat26";
        public static string Form1BySat28 = BaseUrl + "job/Form1BySat28";
        public static string Form1BySat30 = BaseUrl + "job/Form1BySat30";
        public static string Form1BySat31 = BaseUrl + "job/Form1BySat31";
        public static string Form1BySat32 = BaseUrl + "job/Form1BySat32";
        public static string Form1BySat34 = BaseUrl + "job/Form1BySat34";
        public static string Form1BySat36 = BaseUrl + "job/Form1BySat36";
        public static string Form1BySat38 = BaseUrl + "job/Form1BySat38";
        public static string Form1BySat40 = BaseUrl + "job/Form1BySat40";
        public static string Form1BySat42 = BaseUrl + "job/Form1BySat42";
        public static string Form1BySat43 = BaseUrl + "job/Form1BySat43";
        public static string Form1BySat44 = BaseUrl + "job/Form1BySat44";
        public static string Form1BySat45 = BaseUrl + "job/Form1BySat45";
        public static string Form1BySat46 = BaseUrl + "job/Form1BySat46"; // asgn job to inpection
        public static string Form1BySat47 = BaseUrl + "job/Form1BySat47";
        public static string Form1BySat48 = BaseUrl + "job/Form1BySat48";
        public static string Form1BySat49 = BaseUrl + "job/Form1BySat49";
        public static string Form1BySat50 = BaseUrl + "job/Form1BySat50";
        public static string Form1BySat51 = BaseUrl + "job/Form1BySat51";

        public static string GetJobForRcInst = BaseUrl + "job/GetJobForRcInst";





        public static string DeleteRecordInFormJob = BaseUrl + "job/DeleteRecordInFormJob";
        public static string Audit = BaseUrl + "job/Audit";
        public static string GetUserList = BaseUrl + "job/GetUserList";
        public static string PostTrackRCInstState = BaseUrl + "job/PostTrackRCInstState";
        public static string UpdateBooked = BaseUrl + "job/UpdateBooked";




        public static string LoginUserName = "";
        public static int LoginUserId = 0;
        public static string UserRole = "";

        public static string DateApi = "https://timeapi.io/api/Time/current/zone?timeZone=Europe/London"; //get ki api hai

        public static DateTime DateTimeOnly;
        public static DateTime dateTime2;
        public static string DateAndTime;
        public static DateTime DateOnly;
        public static string OnlyTime;
        public static string refno;
        public static int FormId = 0;
        public static int status45Count = 0;
        public static int status3Count = 0;
        public static bool success = false;






        public static List<string> title = new List<string> { "Mr", "Mrs", "Ms", "Miss" };
        public static List<string> month = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public static List<string> inspection = new List<string> { "C1", "C2", "C3" };
        public static List<string> tenure = new List<string> { "Owner Occupied", "Tenant" };
        public static List<string> scheme = new List<string> { "ECO4/Main", "ECO4/SM", "ECO4 CHB", "ECO4 Flex", "ECO3/BB", "GBIS GE", "GBIS LI", "HUG", "LAD", "SHDF" };
        public static List<string> members = new List<string> { "Lead Generator", "Surveyor", "PAS Installer",
    "LOFT Installer","RIR Installer","EWI Installer","IWI Installer","Boiler Installer","HC Installer","Solar Pv Installer","ASHP Installer",
    "Retrifit Assessor","Retrofit Coordinator","Funder Name","Measure","Company"};
        public static List<string> jobTypes = new List<string> { "ASHP","B/UP","B/BR","EWI","FTCH","HC/S","HC/N",
            "IWI","RIR","Loft","S/PV","PRV"
        };



    }
}
