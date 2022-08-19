using System;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using System.Net;

namespace SimpleService
{
	[Service]
	public class SimpleStartedService : Service
	{
		static readonly string TAG = "X:" + typeof(SimpleStartedService).Name;
		static readonly int TimerWait = 500;
		Timer timer;
		DateTime startTime;
		bool isStarted = false;

		public override void OnCreate()
		{
			base.OnCreate();
		}

		public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
		{
			Log.Debug(TAG, $"OnStartCommand called at {startTime}, flags={flags}, startid={startId}");
			if (isStarted)
			{
				TimeSpan runtime = DateTime.UtcNow.Subtract(startTime);
				Log.Debug(TAG, $"This service was already started, it's been running for {runtime:c}.");
			}
			else
			{
				startTime = DateTime.UtcNow;
				Log.Debug(TAG, $"Starting the service, at {startTime}.");
				timer = new Timer(HandleTimerCallback, startTime, 0, TimerWait);
				isStarted = true;
			}
			return StartCommandResult.NotSticky;
		}

		public override IBinder OnBind(Intent intent)
		{
			// This is a started service, not a bound service, so we just return null.
			return null;
		}


		public override void OnDestroy()
		{			
			timer.Dispose();
			timer = null;
			isStarted = false;

			TimeSpan runtime = DateTime.UtcNow.Subtract(startTime);
			Log.Debug(TAG, $"Simple Service destroyed at {DateTime.UtcNow} after running for {runtime:c}.");
			base.OnDestroy();
		}

		void HandleTimerCallback(object state)
		{
			TimeSpan runTime = DateTime.UtcNow.Subtract(startTime);
			Log.Debug(TAG, $"This service has been running for {runTime:c} (since ${state}):");

            try
            {
                var url = "http://192.168.1.129:8080/SERVER/?par1=" + Math.Round(General.AcelX*10) + "&par2=" + Math.Round(General.AcelY*10) + "&par3=0&par4=0&par5=0";
                var textFromFile = (new WebClient()).DownloadString(url);
            }
            catch (Exception ex)
            { }
        }
	}
}