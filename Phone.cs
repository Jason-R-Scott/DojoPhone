namespace DojoPhone {
    public abstract class Phone 
    {
        private string _versionNumber;
        public string VersionNumber
        {
            get {return _versionNumber;}
            set {_versionNumber = value;}
        }

        private int _batteryPercentage;
        public string BatteryPercentage
        {
            get {return _versionNumber;}
            set {_versionNumber = value;}
        }

        private string _carrier;
        public string Carrier
        {
            get {return _carrier;}
            set {_carrier = value;}

        }

        private string _ringTone;
        public string RingTone
        {
            get {return _ringTone;}
            set {_ringTone = value;}
        }

        public Phone (string versionNumber, int batteryPercentage, string carrier, string ringTone) {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        
        public abstract void DisplayInfo ();
       
    }
}