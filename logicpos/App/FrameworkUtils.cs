namespace Quickpos.App
{
    public class FrameworkUtils  : quickpos.financial.library.App.FrameworkUtils
    {
        //Log4Net
        private static log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
