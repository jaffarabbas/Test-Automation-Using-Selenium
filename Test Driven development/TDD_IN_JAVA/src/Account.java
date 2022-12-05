public class Account {

    private String owner;
    private long balance;
    private int pin;
    private double CNIC;
    String fname;
    String  lname;

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

}
