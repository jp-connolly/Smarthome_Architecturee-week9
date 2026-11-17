using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        // private fields
        private string resolutionStatus;
        private bool recordingStatus;

        // Public properties
        public string ResolutionStatus
        {
            get { return resolutionStatus; }
            set { resolutionStatus = value; }
        }

        public bool RecordingStatus
        {
            get { return recordingStatus; }
            set {  recordingStatus = value; }
        }

        // Constructor
        public SmartSecurityCamera(string resolutionStatus,
            bool recordingStatus,
            int smartDeviceID,
            string smartDeviceName,
            bool smartDeviceStatus)
            : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {

        }
            

        // Methods

        public void StartRecording()
        {

        }

        public void StopRecording()
        {

        }

        public override void GetStatus()
        {
            
        }

    }
}
