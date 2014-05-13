Wp8.1BackgroundTask
===================

The most awaited background task API for windows phones has been finally released in the 8.1 update. Now windows phones can run tasks in the background even when the apps are not in foreground. Unlike other versions of the phone's operating system, there are not many strings attached to this API. 

This example is based on Timer Trigger background task. Any application using this API can run in the background for about 10 minutes every 15 minutes as a scheduled cycle. The application has to register the background task and choose the scheudle time for the background task to run. 

Note: The timer trigger background task is a runtime component and not a silverlight project. Even though you have all the namespaces in the silverlight project to register and implement the IBackgroundTask interface, background task will not run as a silverlight project. The silverlight project will be the used only to register the background task. 


