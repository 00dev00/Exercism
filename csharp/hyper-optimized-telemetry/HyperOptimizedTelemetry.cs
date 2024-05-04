using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading) => BitConverter.GetBytes(reading);

    public static long FromBuffer(byte[] buffer) => BitConverter.ToInt64(buffer);
}
