using MvvmHelpers;
using System;
using System.Collections.ObjectModel;
using virranproduct.Modules.AllTaskPage.ViewModel;
using virranproduct.Modules.Common;
using virranproduct.Modules.Login.View;
using virranproduct.Modules.MasterDetail.View;
using virranproduct.Modules.NewTimeSheet.View;
using virranproduct.Modules.SuperAdmin.Implementation;
using virranproduct.Modules.SuperAdmin.Implementation.Mock;
using virranproduct.Modules.SuperAdmin.SuperAdminLogin.View;
using virranproduct.Modules.TimeSheet.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace virranproduct
{
    public partial class App : Application
    {
        public static string SelectedProjectId;
        public static bool menuchoice;
        public static int Menu;
        public static string ImagePath;
        public static string updatevalue;
        public static string TASKPER;
        public static string subtaskid;
        public static string leavebackbutton;
        public static string Backbuttonnotworking;
        public static string NavigationControl;
        public static string ubdatetask;
        public static string PMRole;
        public static string getProjectlist;
        public static string tostmsg;
        public static string tostmsg1;
        public static string naigationprojects;
        public static string MenuBarName;
        public static string Projecttitle;
        public static string ProjectNameLabel;
        public static string getProjectlisteffstartdate;
        public static string getprojectenddate;
        public static string PM_projectid;
        public static DateTime Prominmumdate;
        public static DateTime promaxiumdate;
        // public static ObservableRangeCollection<TaskHeaderListViewmodel> Filterlist = new ObservableRangeCollection<TaskHeaderListViewmodel>();
        public static string filterapply;

        public App()
        {
            InitializeComponent();
            //if (Application.Current.Properties.ContainsKey(Constants.PM_Employee_Id) && Application.Current.Properties[Constants.PM_User_Id].ToString() != null)
            //{
            //    App.NavigationControl = "1";
            //    App.menuchoice = true;
            //    App.PMRole = "6";
            //    Application.Current.MainPage = new RootPage();
            //}
            //else if (Application.Current.Properties.ContainsKey(Constants.Employee_Id) && Application.Current.Properties[Constants.User_Id].ToString() != null)
            //{
            //    App.NavigationControl = "1";
            //    // App.PMRole = "6";
            //    App.menuchoice = true;
            //    Application.Current.MainPage = new RootPage();
            //}
            //else
            //{
            //    MainPage = new LoginPage();
            //}
            RegisterDependencies(true);
            MainPage = new SuperAdminRootPage();
        }

        private void RegisterDependencies(bool isMock = false)
        {
            if (isMock)
            {
                DependencyService.Register<MockDashBoardService>();
            }
            else
            {
                DependencyService.Register<DashBoardService>();
            }
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
