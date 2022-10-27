using Altom.AltUnityDriver;
using Tests.setTests;
using System;
using System.Threading;
using NUnit.Framework;

namespace Tests.voidTests
{
    public class StartPageTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private setMainMenu mainMenu;
        private setStartPage startPage;
        public StartPageTests()
        {
            altUnityDriver = new AltUnityDriver();
            startPage = new setStartPage(altUnityDriver);
            startPage.Load();
            mainMenu = new setMainMenu(altUnityDriver);

        }
        [Test]
        public void CorrectStartVoid() // стартовая страница запускается
        {
            Assert.True(startPage.IsDisplayed());
        }
        [Test]
        public void LoadMainMenu() // происходит переход на главное меню
        {
            startPage.PressStart();
            Assert.True(mainMenu.IsDisplayed());
        }

        public void Dispose() //чистка мусора
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }

    }
}