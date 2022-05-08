package TestProject;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class BaseClass {
    public String url;
    public String webDriverExtension= "webdriver.chrome.driver";
    public String webDriverPath = "J:\\softwares\\chromedriver_win32\\chromedriver.exe";
    public WebDriver webDriver;

    BaseClass(){
        System.setProperty(webDriverExtension,webDriverPath);
    }

    public void Initialize(){
        webDriver = new ChromeDriver();
        webDriver.get(url);
        webDriver.manage().window().maximize();
    }
}
