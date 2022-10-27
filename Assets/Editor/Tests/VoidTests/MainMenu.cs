using Altom.AltUnityDriver;
using Tests.setTests;
using System;
using System.Threading;
using NUnit.Framework;

public class MainMenu
{
    public class MainMenuTests : IDisposable
    {
        AltUnityDriver altUnityDriver;
        setMainMenu mainMenu;

    
        public MainMenuTests()
        {
            altUnityDriver = new AltUnityDriver();
            mainMenu = new setMainMenu(altUnityDriver);
            mainMenu.LoadScene();

        }

        [Test]
        public void CorrectMainMenuVoid() //успешно зашло в главное меню
        {
            Assert.True(mainMenu.IsDisplayed());
        }
        public void Dispose() //чистка мусора
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
    }


}