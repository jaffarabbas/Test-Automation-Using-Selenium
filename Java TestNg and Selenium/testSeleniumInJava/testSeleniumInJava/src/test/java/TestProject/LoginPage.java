package TestProject;

import org.openqa.selenium.By;

public class LoginPage extends BaseClass{
    By userId = new By.ById("txtUsername");
    By passId = new By.ByName("txtPassword");
    By btnId = new By.ById("btnLogin");
    By menu = new By.ByXPath("//*[@id='welcome']");
    By logoutLink = new By.ByLinkText("Logout");
    public void login(String username,String password){
        webDriver.findElement(userId).sendKeys(username);
        webDriver.findElement(passId).sendKeys(password);
        webDriver.findElement(btnId).click();
    }
    public void logout() throws InterruptedException {
        webDriver.findElement(menu).click();
        Thread.sleep(2000);
        webDriver.findElement(logoutLink).click();
    }
}
