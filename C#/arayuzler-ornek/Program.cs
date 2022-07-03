namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Interface **************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("**********************");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("************** Abstract ***************");
            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe().ToString());
        }
    }
}