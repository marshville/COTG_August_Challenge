using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COTGPetshop.PosApp
{
    public class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SynchronizationContext.SetSynchronizationContext(
                new WindowsFormsSynchronizationContext());

            var p = new Program();
            p.ExitRequested += p_ExitRequested;

            Task programStart = p.StartAsync();
            HandleExceptions(programStart);

            Application.Run();
        }


        static void p_ExitRequested(object sender, EventArgs e)
        {
            Application.ExitThread();
        }


        private readonly PosForm _mainForm;
        public event EventHandler<EventArgs> ExitRequested;
        private Program()
        {            
            _mainForm = new PosForm();
            _mainForm.FormClosed += _mainForm_FormClosed;
        }

        void _mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnExitRequested(EventArgs.Empty);
        }

        private static async void HandleExceptions(Task task)
        {
            try
            {
                await Task.Yield();
                await task;
            }
            catch (Exception ex)
            {
                //ToDo: log start up exception
                Application.Exit();
            }
        }

        public async Task StartAsync()
        {

            using (SplashScreen splashScreen = new SplashScreen())
            {
                splashScreen.Owner = _mainForm;                
                splashScreen.FormClosed += _mainForm_FormClosed;
                splashScreen.Invalidate();
                splashScreen.Show();
               
                var model = new POSModel();
                
                Task initModel = model.InitialiseAsync();
                Task showProgress = splashScreen.ShowProgressAsync();
                

                await initModel;                
                _mainForm.Initialise(model);
                await showProgress;
                
                _mainForm.Show();

                splashScreen.FormClosed -= _mainForm_FormClosed;
                splashScreen.Close();
            }

        }

        protected virtual void OnExitRequested(EventArgs e)
        {
            if (ExitRequested != null)
            {
                ExitRequested(this, e);
            }
        }
    }
}
