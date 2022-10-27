using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Tests.setTests
{
    public class setStartPage : setDriver
    {
        public setStartPage(AltUnityDriver driver) : base(driver)
        {

            
        }

        public void Load()
        {
            Driver.LoadScene("Start");
        }
        public AltUnityObject StartButton { get => Driver.WaitForObject(By.NAME, "StartButton", timeout: 2); }
        public AltUnityObject StartText { get => Driver.WaitForObject(By.NAME, "StartText", timeout: 2); }
        public AltUnityObject LogoImage { get => Driver.WaitForObject(By.NAME, "LogoImage", timeout: 2); }
        public AltUnityObject UnityUrlButton { get => Driver.WaitForObject(By.NAME, "UnityURLButton", timeout: 2); }
        public bool IsDisplayed()
        {
            if (StartButton != null)
                return true;
            return false;
        }
        public void PressStart() //определение нажатия начала игры
        {
            StartButton.Tap();
        }

    }
}