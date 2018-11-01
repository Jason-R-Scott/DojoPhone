namespace DojoPhone {
    public class Galaxy : Phone, IRingable {
        public Galaxy (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring () {
            return RingTone;
        }

        public string Unlock () {
            return ($"Galaxy {VersionNumber} unlocked with fingerprint");
        }
        public override void DisplayInfo () {
            System.Console.WriteLine("##################");        
            System.Console.WriteLine($"Galaxy {VersionNumber}");        
            System.Console.WriteLine($"Battery Percentage: {BatteryPercentage}");        
            System.Console.WriteLine($"Carrier: {Carrier}");        
            System.Console.WriteLine($"Ring Tone: {RingTone}");        
            System.Console.WriteLine("##################");               
        }
    }

}