using System;
class BatteryInfo
{
    private string battery;
    private string batteryLife;

    public string Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }
    public string BatteryLife
    {
        get { return batteryLife; }
        set { this.batteryLife = value; }
    }

    public BatteryInfo(string baterry, string batteryLife)
    {
        this.Battery = battery;
        this.BatteryLife = batteryLife;
    }
}