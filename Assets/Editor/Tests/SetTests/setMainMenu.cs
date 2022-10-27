using NUnit.Framework;
using Altom.AltUnityDriver;
namespace Tests.setTests
{ 
public class setMainMenu : setDriver 
{
        public setMainMenu(AltUnityDriver driver) : base(driver)
        {
        }
        public void LoadScene()
        {
            Driver.LoadScene("Main");
        }

        public AltUnityObject StoreButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/StoreButton", timeout: 10); }
        public AltUnityObject LeaderBoardButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/OpenLeaderboard", timeout: 10); }
        public AltUnityObject SettingsButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/SettingButton", timeout: 10); }
        public AltUnityObject MissionButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/MissionButton", timeout: 10); }
        public AltUnityObject RunButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/StartButton", timeout: 10); }
        public AltUnityObject CharacterName { get => Driver.WaitForObject(By.NAME, "CharName", timeout: 10); }
        public AltUnityObject ThemeName { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/ThemeZone", timeout: 10); }
        public bool IsDisplayed()
        {
            if (StoreButton != null && LeaderBoardButton != null && SettingsButton != null && MissionButton != null && RunButton != null && CharacterName != null && ThemeName != null)
                return true;
            return false;
        }
        public void PressRun() //������ ����������� ���� � GameMove
        {
            RunButton.Tap();
        }

    }
}