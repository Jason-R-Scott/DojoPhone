namespace DojoPhone {
    public class Nokia : Phone, IRingable {
        public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring () {
            return RingTone;
        }
        public string Unlock () {
            return ($"Nokia {VersionNumber} unlocked with passcode");
        }
        public override void DisplayInfo () {
            System.Console.WriteLine("##################");        
            System.Console.WriteLine($"Nokia {VersionNumber}");        
            System.Console.WriteLine($"Battery Percentage: {BatteryPercentage}");        
            System.Console.WriteLine($"Carrier: {Carrier}");
            System.Console.WriteLine($"Ring Tone: {RingTone}");        
            System.Console.WriteLine("##################");        
        }
    }

}