using Altom.AltUnityDriver;
using Tests.setTests;
using System;
using System.Threading;
using NUnit.Framework;

public class GameMove
{
    public class GameMovement : IDisposable
    {
        AltUnityDriver altUnityDriver;
        setMainMenu mainMenu;
        setPlay gamePlay;
        setPausePlay pausePlay;
        setRestart restart;
        public GameMovement()
        {

            altUnityDriver = new AltUnityDriver();
            mainMenu = new setMainMenu(altUnityDriver);
            mainMenu.LoadScene();
            mainMenu.PressRun();
            gamePlay = new setPlay(altUnityDriver);
            pausePlay = new setPausePlay(altUnityDriver);
            restart = new setRestart(altUnityDriver);

        }
        [Test]
        public void GameRunCorrectly() //��������� ��� ����
        {
            mainMenu.PressRun();
            Assert.True(gamePlay.IsDisplayed());
        }
        [Test]
        public void GameCanPauseAndResume() //���� �������� �� ����� � ������������ � ����
        {
            gamePlay.PressPause();
            Assert.True(pausePlay.IsDisplayed());
            pausePlay.PressResume();
            Assert.True(gamePlay.IsDisplayed());
        }
        [Test]
        public void GameCanPauseAndStop() //���� �������� �� ����� � ���������������
        {
            gamePlay.PressPause();
            pausePlay.PressMainMenu();
            Assert.True(mainMenu.IsDisplayed());
        }

       [Test]
       public void CatDiesBarrierNotAvoid() //������ �� ����������� 
        {
            altUnityDriver.LoadScene("Main");
            mainMenu.PressRun();
            float timeout = 30;
            while (timeout > 0)
            {
                try
                {
                    restart.IsDisplayed();
                    break;
                }
                catch (Exception)
                {
                   timeout -= 1;
                }
            }
            Assert.True(restart.IsDisplayed());
        }

        public void Dispose() //������ ������
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
    }

}