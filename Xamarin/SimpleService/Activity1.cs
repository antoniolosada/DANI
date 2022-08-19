using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Hardware;

namespace SimpleService
{
    [Activity(Label = "Simple Service Demo", MainLauncher = true)]
    public class Activity1 : Activity, ISensorEventListener
    {
		bool isServiceRunning = false;
		Button startButton;
		Button stopButton;

        static readonly object _syncLock = new object();
        SensorManager _sensorManager;
        TextView _sensorTextView;

        public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
        {
            // We don't want to do anything here.
        }

        public void OnSensorChanged(SensorEvent e)
        {
            lock (_syncLock)
            {
                _sensorTextView.Text = string.Format("x={0:f}, y={1:f}, z={2:f}", e.Values[0], e.Values[1], e.Values[2]);
                General.AcelX = e.Values[0];
                General.AcelY = e.Values[1];
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

			startButton = FindViewById<Button>(Resource.Id.startService);
			startButton.Click += Start_Click; 

			stopButton = FindViewById<Button>(Resource.Id.stopService);
			stopButton.Click += Stop_Click;
			stopButton.Enabled = false;

            _sensorManager = (SensorManager)GetSystemService(SensorService);
            _sensorTextView = FindViewById<TextView>(Resource.Id.accelerometer_text);
            _sensorTextView.Text = "Servicio iniciado";

        }

        protected override void OnPause()
		{
            // Clean up: shut down the service when the Activity is no longer visible.
            //StopService(new Intent(this, typeof(SimpleStartedService)));
            
            //_sensorManager.UnregisterListener(this);
            base.OnPause();
		}

		void Start_Click(object sender, System.EventArgs e)
		{
			StartService(new Intent(this, typeof(SimpleStartedService)));
			isServiceRunning = true;
			startButton.Enabled = false;
			stopButton.Enabled = true;
		}


		void Stop_Click(object sender, System.EventArgs e)
		{
			StopService(new Intent(this, typeof(SimpleStartedService)));
			isServiceRunning = false;
			startButton.Enabled = true;
			stopButton.Enabled = false;
		}
        protected override void OnResume()
        {
            base.OnResume();
            _sensorManager.RegisterListener(this,
                                            _sensorManager.GetDefaultSensor(SensorType.Accelerometer),
                                            SensorDelay.Ui);
        }


    }
}