using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FitnessTracker.Desktop.Util;
using System.Threading;
using FitnessTracker.Desktop.Forms;
using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Data.Context;
using FitnessTracker.Desktop.Data.SqlClient;
using FitnessTracker.Desktop.Domain.Interface;
using FitnessTracker.Desktop.Data.Repository;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Presentation.Forms;

namespace FitnessTracker.Desktop
{
    internal static class App
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static IServiceProvider MyServiceProvider { get; private set; }
        public static FrmLogin LoginFrom { get; private set; }

        [STAThread]
        static void Main()
        {
            // must call first
            Application.SetCompatibleTextRenderingDefault(false);

            // set default exception behavior to catch all with handler 
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //  set up dependency injection 
            MyServiceProvider = CreateHostBuiler().Build().Services;

            LoginFrom = MyServiceProvider.GetRequiredService<FrmLogin>();

            // handle UI thread related exception
            Application.ThreadException += Application_ThreadException;

            // handle non-UI thread related exception
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();

            Application.Run(LoginFrom);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var exceptionFromEvent = (Exception)e.ExceptionObject;
                var message = $"{Constant.AppMessage.UNHANDLE_THREAD_EXCEPTION}\n{exceptionFromEvent.Message}";
                CustomMessageBoxUtil.Error(message);
            }
            finally
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This method will inject all WinForms requried class
        /// </summary>
        /// <returns></returns>
        static IHostBuilder CreateHostBuiler()
        {
            return Host.CreateDefaultBuilder()
                 .ConfigureServices((context, services) =>
                 {
                     services.AddSingleton<DataContext>();
                     services.AddSingleton<DbClient>();
                     services.AddScoped<IUserRepository, UserRepository>();
                     services.AddScoped<UserUseCase>();
                     // add forms
                     services.AddTransient<FrmLogin>();
                     services.AddTransient<FrmUserDashBorad>();
                     services.AddTransient<FrmUserRegister>();
                     services.AddTransient<FrmUserProfile>();
                 });
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                // handle some hadleable exception
                var message = $"{Constant.AppMessage.UNHANDLE_WINFORM_EXCEPTION}\n{e.Exception.Message}";
                CustomMessageBoxUtil.Error(message);
            }
            catch (Exception ex)
            {
                try
                {
                    CustomMessageBoxUtil.Error(Constant.AppMessage.FATAL_UI_THREAD_EXCEPTION_MESSAGE);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}
