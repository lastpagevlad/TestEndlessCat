using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Tests.setTests
{
    public class setRestart : setDriver 
    {
        public setRestart(AltUnityDriver driver) : base(driver)
        {
        }

        public AltUnityObject GameOverButton { get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/GameOver", timeout: 2); }
        public AltUnityObject PremiumButton { get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/ButtonLayout/Premium Button", timeout: 2); }
        public AltUnityObject AvailableCurrency { get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/PremiumDisplay/PremiumOwnCount", timeout: 2); }

        public bool IsDisplayed() //пока отображается
        {
            if (GameOverButton != null && PremiumButton != null && AvailableCurrency != null)
                return true;
            return false;
        }
        public void PressGameOver() //нажата кнопка законченный игры
        {
            GameOverButton.Tap();
        }
        

    }
}