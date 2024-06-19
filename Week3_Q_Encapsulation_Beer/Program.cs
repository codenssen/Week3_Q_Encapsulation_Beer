namespace Week3_Q_Encapsulation_Beer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avalaibleBeerVolume;
            int avalaibleBottles;
            int avalaibleCapsules;
            
            Console.WriteLine("Veuillez rentrer vos données :");
            Console.WriteLine("Volume de bière disponible (en centilitres) ?");
            avalaibleBeerVolume = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nombre de bouteille disponible ?");
            avalaibleBottles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de capsule disponible ?");
            avalaibleCapsules = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Voici votre demande : {avalaibleBeerVolume} litres de bière à embouteiller, {avalaibleBottles} bouteilles disponibles, {avalaibleCapsules} capsules disponibles");
            
            BeerEncapsulator usine1 = new BeerEncapsulator(avalaibleBeerVolume, avalaibleBottles, avalaibleCapsules);
            Console.WriteLine("");
            Console.WriteLine("Combien de bouteilles souhaitez vous");
            Console.WriteLine($"Status du stock : {usine1.GetBeerVolume} centilitres de bières, {usine1.GetBottles} bouteilles, {usine1.GetCapsules} capsules.");
            int bouteilles = Convert.ToInt32(Console.ReadLine());
            usine1.ProduceEncapsulatedBeerBottles(bouteilles);

        }
    }
}
