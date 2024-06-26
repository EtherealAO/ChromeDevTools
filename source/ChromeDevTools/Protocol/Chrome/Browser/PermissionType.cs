using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionType
	{
			AccessibilityEvents,
			AudioCapture,
			BackgroundSync,
			BackgroundFetch,
			ClipboardReadWrite,
			ClipboardSanitizedWrite,
			DisplayCapture,
			DurableStorage,
			Flash,
			Geolocation,
			IdleDetection,
			LocalFonts,
			Midi,
			MidiSysex,
			Nfc,
			Notifications,
			PaymentHandler,
			PeriodicBackgroundSync,
			ProtectedMediaIdentifier,
			Sensors,
			StorageAccess,
			TopLevelStorageAccess,
			VideoCapture,
			VideoCapturePanTiltZoom,
			WakeLockScreen,
			WakeLockSystem,
			WindowManagement,
	}
}
