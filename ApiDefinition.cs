using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestFlightBinding {

	[BaseType (typeof (NSObject))]
	public partial interface TestFlight {

		[Static, Export ("addCustomEnvironmentInformation:forKey:")]
		void AddCustomEnvironmentInformation (string information, string key);

		[Static, Export ("takeOff:")]
		void TakeOff (string applicationToken);

		//		[Static, Export ("options"), Verify ("ObjC method massaged into setter property", "/Users/ghigh/Downloads/TestFlightSDK1.2.6/TestFlight.h", Line = 55)]
		//		NSDictionary Options { set; }
		//		[Static, Export ("setOptions:")]
		//		void SetOptions (string checkpointName);

		[Static, Export ("passCheckpoint:")]
		void PassCheckpoint (string checkpointName);

		[Static, Export ("openFeedbackView")]
		void OpenFeedbackView ();

		//		[Static, Export ("deviceIdentifier"), Verify ("ObjC method massaged into setter property", "/Users/ghigh/Downloads/TestFlightSDK1.2.6/TestFlight.h", Line = 97)]
		//		string DeviceIdentifier { set; }
		[Static, Export ("setDeviceIdentifier:")]
		void SetDeviceIdentifier (string deviceIdentifer);

		[Static, Export ("submitFeedback:")]
		void SubmitFeedback (string feedback);

		[Field ("TFOptionAttachBacktraceToFeedback", "__Internal")]
		NSString TFOptionAttachBacktraceToFeedback { get; }

		[Field ("TFOptionDisableInAppUpdates", "__Internal")]
		NSString TFOptionDisableInAppUpdates { get; }

		[Field ("TFOptionLogToConsole", "__Internal")]
		NSString TFOptionLogToConsole { get; }

		[Field ("TFOptionLogToSTDERR", "__Internal")]
		NSString TFOptionLogToSTDERR { get; }

		[Field ("TFOptionReinstallCrashHandlers", "__Internal")]
		NSString TFOptionReinstallCrashHandlers { get; }

		[Field ("TFOptionSendLogOnlyOnCrash", "__Internal")]
		NSString TFOptionSendLogOnlyOnCrash { get; }
	}
}