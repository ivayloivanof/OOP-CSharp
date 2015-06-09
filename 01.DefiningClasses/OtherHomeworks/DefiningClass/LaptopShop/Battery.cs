using System;
public static class BatteryInfo
{
    private static string battery;
    private static string batteryLife;

    public static string Battery
    {
        get { return battery; }
        set { battery = value; }
    }
    public static string BatteryLife
    {
        get { return batteryLife; }
        set { batteryLife = value; }
    }
}