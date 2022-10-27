using NUnit.Framework;
using Altom.AltUnityDriver;
using System;

namespace Tests.setTests
{
    public class setPlay : setDriver
    {
        public setPlay(AltUnityDriver driver) : base(driver)
        {
        }

        public AltUnityObject PauseButton { get => Driver.WaitForObject(By.NAME, "Game/WholeUI/pauseButton", timeout: 2); }
        public AltUnityObject Character { get => Driver.WaitForObject(By.NAME, "PlayerPivot"); }

        public bool IsDisplayed() //скрыты кнопка паузы и персонаж
        {
            if (PauseButton != null && Character != null)
            {
                return true;
            }
            return false;
        }
        public void PressPause() //поставлена на паузу
        {
            PauseButton.Tap();
        }


    }
}