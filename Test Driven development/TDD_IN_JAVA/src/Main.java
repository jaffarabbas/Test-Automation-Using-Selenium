public class Main {
    public static void main(String[] args) {
        Account Rahim = new Account("Rahim", 12000, 2345, 23,"Samin", "tariq");
        //creating card object
        Rahim.addCard(new Card("VisaCard","123456789"));
        System.out.println(Rahim.card.getLimit());
        Rahim.card.useCard(110000);
    }
}