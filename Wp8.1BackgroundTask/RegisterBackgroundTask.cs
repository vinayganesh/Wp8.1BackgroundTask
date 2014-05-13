using Microsoft.Phone.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace Wp8._1BackgroundTask
{
    class RegisterBackgroundTask
    {
        #region BackgroundTask

        public async void registerTimerTrigger(uint time, string entryPoint)
        {
            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if (task.Value.Name == "TimerTriggeredTask")
                {
                    AttachProgressAndCompletedHandlers(task.Value);
                }
            }

            var _task = BackgroundTaskConfiguration.RegisterBackgroundTask(entryPoint, "TimerTriggeredTask", new TimeTrigger(time, false), null);

            await _task;

            AttachProgressAndCompletedHandlers(_task.Result);

            Debug.WriteLine(entryPoint + " Background task Registered");
        }


        private void AttachProgressAndCompletedHandlers(IBackgroundTaskRegistration task)
        {
            task.Progress += new BackgroundTaskProgressEventHandler(OnProgress);
            task.Completed += new BackgroundTaskCompletedEventHandler(OnCompleted);
        }


        private void OnProgress(IBackgroundTaskRegistration task, BackgroundTaskProgressEventArgs args)
        {
            var progress = "Progress: " + args.Progress + "%";
            BackgroundTaskConfiguration.TimeTriggeredTaskProgress = progress;
        }


        private void OnCompleted(IBackgroundTaskRegistration task, BackgroundTaskCompletedEventArgs args)
        {
            ShellToast toast = new ShellToast();
            toast.Title = "Sample Application";
            toast.Content = "Background Task Complete";
            toast.Show();
        }

        #endregion
    }
}
