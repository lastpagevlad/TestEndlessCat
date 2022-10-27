using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Tests.setTests
{
    public class setDriver
    {
        AltUnityDriver driver;

        public AltUnityDriver Driver { get => driver; set => driver = value; }
        public setDriver(AltUnityDriver driver)
        {
            Driver = driver;
        }

    }
}