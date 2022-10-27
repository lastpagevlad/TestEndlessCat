using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Tests.setTests
{
    public class setPausePlay : setDriver
    {
        public setPausePlay(AltUnityDriver driver) : base(driver)
        {
        }

        public AltUnityObject ResumeButton { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Resume", timeout: 2); }
        public AltUnityObject MainMenuButton { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Exit", timeout: 2); }
        public AltUnityObject Title { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Text", timeout: 2); }

        public bool IsDisplayed() //пока отображается вход в меню
        {
            if (ResumeButton != null && MainMenuButton != null && Title != null)
                return true;
            return false;
        }
        public void PressResume() //прожат возврат в игру
        {
            ResumeButton.Tap();
        }
        public void PressMainMenu() //прожато возвращение в игру
        {
            MainMenuButton.Tap();
        }

    }
}