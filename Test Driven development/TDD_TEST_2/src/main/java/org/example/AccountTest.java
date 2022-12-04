package org.example;


import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotEquals;


public class TestAccount {



    // Checking New Account with Initial getBalance() annotation
    @Test
    public void NewAccountTest() {
        Account Rahim = new Account("Rahim", 12000, 2345, 23,"Samin", "tariq");
        Account Eibad = new Account("Eibad", 35000, 9876,"Samin", "tariq",);
        Account Ali = new Account("Ali", 55555, 5555, 237427,"Samin", "tariq");


//Rahim's Account
        assertEquals(12000, Rahim.getBalance());
        assertNotEquals(21000, Rahim.getBalance());

//Eibad's Account
        Assert.assertEquals(35000,Rahim.getBalance());
        Assert.assertNotEquals(21000, Eibad.getBalance());

//Ali's Account
        Assert.assertEquals(55555, Ali.getBalance());
        Assert.assertNotEquals(55000, Ali.getBalance());
    }

    // Verifying Account Pin
//Act & Assert
    @Test
    public void verifyPin() {
        Account Rahim = new Account("Rahim","Samin", "tariq",12000,2345);

//Rahim's Account
        Assert.assertEquals(true, Rahim.verifyPin(2345));
        Assert.assertNotEquals(true, Rahim.verifyPin(1234));

    }

    @Test
    public void verifyCNIC() {
        Account Rahim = new Account("Rahim", 12000, 2345,123,"samin","tariq");

//Rahim's Account
        Assert.assertEquals(true, Rahim.verifyCNIC(1234));


    }
    // Checking Current getBalance()
    @Test

    public void CheckBalTest() {

        Account Rahim = new Account("Rahim","Samin", "tariq" 12000, 2345);

        Assert.assertEquals(12000, Rahim.getBalance());
        Assert.assertNotEquals(23456, Rahim.getBalance());
    }

    //Checking Transfer Amount in Both Sender & Receiver Account
    @Test
    public void TransferTest() {
        Account Rahim = new Account("Rahim", 12000, 2345,"Samin", "tariq");
        Account Eibad = new Account("Eibad", 35000, 9876,"Samin", "tariq");
        Account Ali = new Account("Ali", 55555, 5555,"Samin", "tariq");

//Act
        Rahim.transferTo(Eibad, 1000);
//Assert
//Sender
        Assert.assertEquals(11000, Rahim.getBalance());

//Receiver
        Assert.assertEquals(36000, Eibad.getBalance());
        Rahim.transferTo(Ali, 2000);

//Sender
        Assert.assertEquals(9000, Rahim.getBalance());

//Receiver
        Assert.assertEquals(57555, Ali.getBalance());
        Ali.transferTo(Eibad, 50000);

//Sender
        Assert.assertEquals(86000, Eibad.getBalance());

//Receiver
        Assert.assertEquals(7555, Ali.getBalance());
    }
    @Test
    public void changePinTest(){
        Account Rahim = new Account("Rahim", 12000, 2345,"Samin", "tariq");
        Assert.assertTrue(Rahim.verifyPin(2345));
        Rahim.changePin(2345, 1234);
        Assert.assertFalse(Rahim.verifyPin(2340));
        Assert.assertTrue(Rahim.verifyPin(1234));
    }

    @Test
    public void debitTest(){
        Account Rahim = new Account("Rahim", 12000, 2345,"Samin", "tariq");
        Assert.assertTrue(Rahim.getBalance() == 12000);
        Rahim.debit(1000);
        Assert.assertFalse(Rahim.getBalance() == 12000);
        Assert.assertTrue(Rahim.getBalance() == 12000-1000);
    }
    @Test
    public void creditTest(){
        Account Rahim = new Account("Rahim", 12000, 2345,"Samin", "tariq");
        Assert.assertTrue(Rahim.getBalance() == 12000);
        Rahim.credit(1000);
        Assert.assertFalse(Rahim.getBalance() == 12000);
        Assert.assertTrue(Rahim.getBalance() == 12000+1000);
    }



}