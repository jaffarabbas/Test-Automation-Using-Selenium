import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Account {

    private String owner;
    private long balance;
    private int pin;
    private double CNIC;
    String fname;
    String  lname;
    Card card;

    public Account(String owner, long balance, int pin, int CNIC, String fname, String lname) {
        this.owner = owner;
        this.balance = balance;
        this.pin = pin;
        this.CNIC = CNIC;
        this.fname = fname;
        this.lname = lname;
    }
    public long getBalance() {
        return balance;
    }

    public boolean verifyPin(int pin) {
        if (this.pin == pin) {
            return true;
        }
        return false;
    }

    public boolean verifyCNIC(int CNIC) {
        if (this.CNIC == CNIC) {
            return true;
        }
        return false;
    }

    public void transferTo(Account toAcc, long amount) {
        if (amount >= 500 && amount <= balance) {
            balance -= amount;
            toAcc.balance += amount;
        }
    }

    public void changePin(int oldPin, int newPin){
        if (this.pin == oldPin)
            this.pin=newPin;
    }

    public void debit(long amount){
        if (this.balance >= amount)
            this.balance-=amount;
    }

    public void credit(long amount){
        if (amount > 0)
            this.balance+=amount;
    }

    public void addCard(Card card){
        this.card = card;
        setCardValue();
    }
    //generalized method for assigning limits to card
    //note
    //card type must equal to map value
    public void setCardValue(){
        card.cardTypes.forEach((cardValue, limit) -> {
            if(card.getCardType().equals(cardValue)){
                card.setLimit(limit);
            }
        });
    }
}

//create seprate instances of card
class Card{
    private String cardType;
    private String cardNumber;
    private int limit;

    //dynamically get card data
    public HashMap<String, Integer> cardTypes = new HashMap<>() {
        {
            put("VisaCard", 100000);
            put("MasterCard", 50000);
        }
    };

    public Card(String cardType, String cardNumber) {
        this.cardType = cardType;
        this.cardNumber = cardNumber;
    }

    public String getCardType() {
        return cardType;
    }

    public String getCardNumber() {
        return cardNumber;
    }

    public long getLimit() {
        return limit;
    }

    public void setLimit(int limit) {
        this.limit = limit;
    }

    public void setNewCardInCardsMap(String cardType, int limit){
        cardTypes.put(cardType, limit);
    }
    public void useCard(int value){
        if (value <= limit){
            limit-=value;
            System.out.println("Transaction Successful Of Amount: "+value+"\n Remaining Limit: "+limit);
        }else{
            System.out.println("You have exceeded your limit you can only use: "+limit);
        }
    }
}
