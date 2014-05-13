using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Wp8._1BackgroundTask.Resources;
using Windows.ApplicationModel.Background;

namespace Wp8._1BackgroundTask
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterBackgroundTask _rct = new RegisterBackgroundTask();
            _rct.registerTimerTrigger(15, "Tasks.TimerTrigger");
        }

        private void btnUnRegister_Click(object sender, RoutedEventArgs e)
        {
            BackgroundTaskConfiguration.UnregisterBackgroundTasks("TimerTriggeredTask");
        }

       

        
    }
}