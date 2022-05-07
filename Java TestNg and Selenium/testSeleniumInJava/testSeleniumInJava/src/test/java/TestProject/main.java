package TestProject;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class main {
    public static void main(String[] args) throws InterruptedException {
        LoginPage loginPage = new LoginPage();
        loginPage.url = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";
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