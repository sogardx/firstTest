using System.Threading;

namespace firstTest
{
    internal static class TestHelper
    {
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
