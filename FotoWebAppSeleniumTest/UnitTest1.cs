using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace FotoWebAppSeleniumTest
{
    public class Tests
    {
        IWebDriver driver;


        public string username = "christian@christian.dk";
        public string pass = "Test123!";

        // Reuseable function to login to the page
        private void LoginUser()
        {
            driver.Navigate().GoToUrl("https://localhost:7120/Account/Login?ReturnUrl=%2F");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/div[1]/div/div/div/input")).SendKeys(username);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/div[2]/div/div/div/input")).SendKeys(pass);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/form/div/div[4]/button")).Click();
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test, Order(1)]
        public void LoginUserTest() 
        {
            LoginUser();

            // Check to see if user i navigated to dashboard
            Assert.That(driver.Url, Is.EqualTo("https://localhost:7120/"));
            

        }

        [Test, Order(2)]
        public void CreateProjectTest()
        {
            LoginUser();

            // find a tag to navigate to album
            driver.FindElement(By.XPath("/html/body/div[1]/aside/div/nav/div[2]/a")).Click();

            // check to see if navigation is correct
            Assert.That(driver.Url, Is.EqualTo("https://localhost:7120/albums"));

            // wait for albums to load
            Thread.Sleep(2000);

            // find the create button 
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div/button")).Click();

            // wait for the modal to pop up
            Thread.Sleep(2000);

            // create album
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[1]/div/div/input")).SendKeys("TestTitle");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[2]/div/div/input")).SendKeys("TestName");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[3]/div/div/input")).SendKeys("TestEmail@email.dk");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[4]/div/div/input")).SendKeys("21232345");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[5]/div/div/input")).SendKeys("50");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[1]/div[6]/div[1]/div/div/input")).SendKeys("22.01.2025");
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div[2]/div[4]/div[1]/form/div/div[2]/button")).Click();

            // wait for its creation
            Thread.Sleep(2000);

            // Assert that the new album appears in the list
            var albumList = driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]"));
            var albumExists = albumList.FindElements(By.XPath(".//h5[contains(text(), 'TestTitle')]")).Any();

            Assert.IsTrue(albumExists);

        }

        [Test, Order(3)]
        public void CustomerImagesSelectionSaveTest()
        {
            // REQUIRES A PROJECT WITH IMAGES UPLOADED TO TEST (CHANGE THE URL STRING ACCORDENTLY)

            string url = "https://localhost:7120/ChooseImages/73?Password=7dcf6710-3861-489c-b09a-7c05d16cd4a3";

            driver.Navigate().GoToUrl(url);

            // wait for page to load
            Thread.Sleep(2000);

            // find elements in list of albums
            var imageList = driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]"));

            var images = imageList.FindElements(By.XPath(".//button"));

            // Click the first button on the image
            images[0].Click();

            // wait for save button popup
            Thread.Sleep(2000);

            // Save selection
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[3]/button")).Click();

            // wait for pop up saved
            Thread.Sleep(2000);

            var savedElement = driver.FindElement(By.XPath("//div[contains(text(), 'Saved')]"));

            Assert.IsTrue(savedElement.Text.Contains("Saved"));
        }

        [Test, Order(4)] 
        public void DeleteProjectTest() 
        {

            LoginUser();

            // find a tag to navigate to album
            driver.FindElement(By.XPath("/html/body/div[1]/aside/div/nav/div[2]/a")).Click();

            // wait for albums to load
            Thread.Sleep(2000);

            var albumListPage = driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]"));
            var albumItem = albumListPage.FindElements(By.XPath(".//h5[contains(text(), 'TestTitle')]"));
            albumItem[0].Click();

            // wait for Project to load
            Thread.Sleep(2000);

            // find delete button
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div/div/div[5]/button")).Click();

            // wait for delete pop up
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[2]/div[2]/div[4]/div[2]/button[2]")).Click();

            // wait for navigation to album page
            Thread.Sleep(2000);

            // Assert that the user is redirected to album page
            Assert.That(driver.Url, Is.EqualTo("https://localhost:7120/albums"));

            // wait for albums to load if any
            Thread.Sleep(2000);

            var albumList = driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]"));
            var albumExists = albumList.FindElements(By.XPath(".//h5[contains(text(), 'TestTitle')]")).Any();
            // Assert that the album is not in the list anymore based on the title 
            Assert.IsTrue(!albumExists);

        }

        [TearDown]
        public void TearDown() 
        {
            driver.Quit(); 
        }
    }
}