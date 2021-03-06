using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Tools
{
    public class MyScreenshot
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            Screenshot screenshot = driver.TakeScreenshot();

            string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string screenshotDirectory = Path.GetFullPath(Path.Combine(projectDirectory, @"..\..\"));

            string screenshotFolder = Path.Combine(screenshotDirectory, "Screenshot");
            Directory.CreateDirectory(screenshotFolder);

            string screenshotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH_mm_ss}.png";
            string screenshotPath = Path.Combine(screenshotFolder, screenshotName);

            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        } 
    }
}
