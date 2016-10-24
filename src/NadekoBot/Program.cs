using NLog;

namespace NadekoBot
{
    public class Program
    {
        private Logger _log { get; }
        public static void Main(string[] args) {
            try
            {
                new NadekoBot().RunAsync(args).GetAwaiter().GetResult();
            }
            catch (System.Exception e)
            {
                _log("NadekoBot Crashed with Exception: {0}", e);
            }
        }
    }
}
