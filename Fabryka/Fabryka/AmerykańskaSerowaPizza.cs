namespace Fabryka
{
    internal class AmerykańskaSerowaPizza : Pizza
    {

        public AmerykańskaSerowaPizza()
        {
            nazwa = "Amerykańska Pizza Serowa";
            ciasto = "Extra grube chrupkie ciasto";
            sos = "Sos z pomidorów śliwkowych";
            dodatki.Add("Grubo tarty ser Mozarella");
        }

        public void  Krojenie()
        {
            System.Console.WriteLine("Krojenie na 8 kawałków");
        }
    }
}