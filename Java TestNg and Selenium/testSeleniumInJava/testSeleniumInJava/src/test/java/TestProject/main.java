package TestProject;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class main {
    public static void main(String[] args) throws InterruptedException {
        String webDriverExtension= "webdriver.chrome.driver";
        String webDriverPath = "J:\\softwares\\chromedriver_win32\\chromedriver.exe";
        String url = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";
        System.setProperty(webDriverExtension,webDriverPath);

        WebDriver webDriver = new ChromeDriver();
        webDriver.get(url);
        webDriver.manage().window().maximize();
        webDriver.findElement(By.id("txtUsername")).sendKeys("admin");
        webDriver.findElement(By.name("txtPassword")).sendKeys("admin123");
        webDriver.findElement(By.id("btnLogin")).click();
        String text = webDriver.findElement(By.xpath("//*[@id='content']/div/div[1]/h1")).getText();
        if (text.contains("Dashboard"))
            System.out.println("Login Successfully");
        webDriver.findElement(By.xpath("//*[@id='welcome']")).click();
        Thread.sleep(2000);
        webDriver.findElement(By.linkText("Logout")).click();
        webDriver.navigate().refresh();
        String title = webDriver.getTitle();
        System.out.println(title);
        String currentUrl = webDriver.getCurrentUrl();
        System.out.println(currentUrl);
        webDriver.quit();
    }
}
