using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkerAnt;

namespace WorkerAnt.Test
{
    [TestClass]
    public class CountdownTest
    {
        [TestMethod]
        public void ProgressInPercentageTest()
        {

            // Arrange
            Countdown.LastUserInput = (1000, 100, 3);
            Countdown.Set();
            Countdown.LastUserInput = (3000, 300, 3);
            



            var expectedWork = 67;
            var expectedBreak = 33;
            var expectedEndBreak = 100;
            var expectedPaused = 0;


            // Act
            var actualWork = Countdown.GetProgressInPercentage(SegmentNames.Work);
            var actualBreak = Countdown.GetProgressInPercentage(SegmentNames.Break);
            var actualEndBreak = Countdown.GetProgressInPercentage(SegmentNames.EndBreak);
            var actualPaused = Countdown.GetProgressInPercentage(SegmentNames.Paused);


            //Assert
            Assert.AreEqual(expectedWork, actualWork);
            Assert.AreEqual(expectedBreak, actualBreak);
            Assert.AreEqual(expectedEndBreak, actualEndBreak);
            Assert.AreEqual(expectedPaused, actualPaused);

        }

        [TestMethod]
        public void GetSettingGetSattingsLapPackagesTest()
        {
            // Arrange
            decimal workRecovery = Properties.Settings.Default.recoveryWorkTime / 60;
            decimal breakRecovery = Properties.Settings.Default.recoveryBreakTime / 60;
            decimal workSmart = Properties.Settings.Default.smartWorkTime / 60;
            decimal breakSmart = Properties.Settings.Default.smartBreakTime / 60;
            decimal workProgress = Properties.Settings.Default.progressWorkTime / 60;
            decimal breakProgress = Properties.Settings.Default.progressBreakTime / 60;
            decimal lapCounter = Properties.Settings.Default.lapCounter;


            var expected = ((workRecovery, breakRecovery), (workSmart, breakSmart), (workProgress, breakProgress), lapCounter);

            // Act
            var actual = GetSetSettingsData.GetSattingsLapPackages();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SaveLastUsedLapPackageTest()
        {
            // Arrange
            LapPackageNames.Recovery.SaveLastUsedLapPackage();

            var expected = Properties.Settings.Default.lastUsedLapPackage;
            // Act

            var actual = (int)LapPackageNames.Recovery;

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
