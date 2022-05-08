package TestProject.tests;

import TestProject.LoginPage;
import org.openqa.selenium.By;
import org.testng.Assert;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;
import utils.ConfigUtils;

import java.util.Properties;

public class LoginTest {
    LoginPage loginPage;
    Properties properties;
    @BeforeClass
    public void Initialize(){
        loginPage = new LoginPage();
        properties = ConfigUtils.getProps("data");
        loginPage.url = properties.getProperty("URL");
    }

    @Test(description = "Login test",priority = 1,suiteName = "Login")
    public void login(){
        loginPage.Initialize();
        loginPage.login("admin","admin123");
        String text = loginPage.webDriver.findElement(By.xpath("//*[@id='content']/div/div[1]/h1")).getText();
        Assert.assertEquals(text,"Dashboard");
    }

    @Test(description = "Logout test",priority = 2,suiteName = "Login")
    public void logout() throws InterruptedException {
        loginPage.logout();
        String currentUrl = loginPage.webDriver.getCurrentUrl();
        Assert.assertTrue(currentUrl.contains("/login"));
    }

    @AfterClass
    public void cleanUp(){
        loginPage.webDriver.quit();
    }
}
