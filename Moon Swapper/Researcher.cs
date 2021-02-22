using System.Collections.Generic;
using System.IO;

public sealed class Researcher
{
    public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
    {
        List<long> searchResults = new List<long>();
        stream.Position = startIndex;

        while (true)
        {
            if (stream.Position == 5000000000)
            {
                return searchResults;
            }

            var latestbyte = stream.ReadByte();
            if (latestbyte == -1)
            {
                break;
            }

            if (latestbyte == searchPattern[searchPosition])
            {
                searchPosition++;
                if (searchPosition == searchPattern.Length)
                {
                    searchResults.Add(stream.Position - searchPattern.Length);
                    return searchResults;
                }
            }
            else
            {
                searchPosition = 0;
            }
        }

        return searchResults;
    }


    private static void smethod_1(Stream stream_0, long long_0)
    {
        stream_0.Position = long_0;


    }

    private static long smethod_2(Stream stream_0)
    {
        return stream_0.Position;
    }

    private static int smethod_3(Stream stream_0)
    {
        return stream_0.ReadByte();
    }

    // I leave a download link with the fully code in the description :) ( the next days there will come part 2 )
}


//thx for watching my video :) your Dex ( part 2 soon!! ) youtube.com/dexxotri