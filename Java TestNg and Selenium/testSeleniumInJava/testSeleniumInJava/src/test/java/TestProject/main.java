package TestProject;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import utils.ConfigUtils;

import java.util.Properties;

public class main {
    public static void main(String[] args) throws InterruptedException {
        LoginPage loginPage = new LoginPage();
        Properties properties = ConfigUtils.getProps("data");

        loginPage.url = properties.getProperty("URL");
        loginPage.Initialize();
        loginPage.login("admin","admin123");
        String text = loginPage.webDriver.findElement(By.xpath("//*[@id='content']/div/div[1]/h1")).getText();
        if (text.contains("Dashboard"))
            System.out.println("Login Successfully");
        loginPage.webDriver.navigate().refresh();
        loginPage.logout();
        String currentUrl = loginPage.webDriver.getCurrentUrl();
        if (currentUrl.contains("/login"))
            System.out.println("Logout successfully");
        loginPage.webDriver.quit();
    }
}
