using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];

        int bytesUsed = 0;
        byte prefix = 0;

        if (reading <= long.MaxValue && reading > uint.MaxValue)
        {
            bytesUsed = 8;
            prefix = (byte)(256-8);
        }
        if (reading <= uint.MaxValue && reading > int.MaxValue)
        {
            bytesUsed = 4;
            prefix = 4;
        }
        if (reading <= int.MaxValue && reading > ushort.MaxValue)
        {
            bytesUsed = 4;
            prefix = (byte)(256-4);
        }
        if (reading <= ushort.MaxValue && reading >= 0)
        {
            bytesUsed = 2;
            prefix = 2;
        }
        if (reading < 0 && reading >= short.MinValue)
        {
            bytesUsed = 2;
            prefix = (byte)(256-2);
        }
        if (reading < short.MinValue && reading >= int.MinValue)
        {
            bytesUsed = 4;
            prefix = (byte)(256-4);
        }
        if (reading < int.MinValue && reading >= long.MinValue)
        {
            bytesUsed = 8;
            prefix = (byte)(256-8);
        } 
        
        buffer[0] = prefix;

        byte[] valueBytes = BitConverter.GetBytes(reading);

        Array.Copy(valueBytes, 0, buffer, 1, bytesUsed);

        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        return (prefix) switch
        {
                256 - 8 or 4 or 2 => BitConverter.ToInt64(buffer, 1),
                256 - 4 => BitConverter.ToInt32(buffer, 1),
                256 - 2 => BitConverter.ToInt16(buffer, 1),
                _ => 0,
        };

        /*switch (prefix)
        {
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case 4:
                if (buffer[1]>127)
                {
                    return (long)BitConverter.ToUInt32(buffer, 1);
                }
                else 
                {
                    return BitConverter.ToInt32(buffer, 1);
                }
            case 8:
                if (buffer[1]>127)
                {
                    return (long)BitConverter.ToUInt64(buffer, 1);
                }
                else 
                {
                    return BitConverter.ToInt64(buffer, 1);
                }
            case 254:
                return BitConverter.ToInt16(buffer, 1);
            case 252:
                return BitConverter.ToInt32(buffer, 1);
            case 248:
                return BitConverter.ToInt64(buffer, 1);
            default:
                return 0;
        }*/
    }
}
