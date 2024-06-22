using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FitnessTracker.Desktop.Util;
using System.Threading;
using FitnessTracker.Desktop.Forms;
using FitnessTracker.Desktop.Data.Context.DataSetFitnessTrackerTableAdapters;
using FitnessTracker.Desktop.Common;

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
                var message = $"{Constant.Message.UNHANDLE_THREAD_EXCEPTION}\n{exceptionFromEvent.Message}";
                CustomMessageBoxUtil.Error(message);
            }
            finally
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This method will inject all WinForms that will use
        /// </summary>
        /// <returns></returns>
        static IHostBuilder CreateHostBuiler()
        {
            return Host.CreateDefaultBuilder()
                 .ConfigureServices((context, services) =>
                 {
                     services.AddSingleton<tb_SystemUserTableAdapter>();
                     services.AddTransient<FrmLogin>();
                     services.AddTransient<FrmDashBorad>();
                     services.AddTransient<FrmUserRegister>();
                 });
        }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                // handle some hadleable exception
                var message = $"{Constant.Message.UNHANDLE_WINFORM_EXCEPTION}\n{e.Exception.Message}";
                CustomMessageBoxUtil.Error(message);
            }
            catch (Exception ex)
            {
                try
                {
                    CustomMessageBoxUtil.Error(Constant.Message.FATAL_UI_THREAD_EXCEPTION_MESSAGE);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}
