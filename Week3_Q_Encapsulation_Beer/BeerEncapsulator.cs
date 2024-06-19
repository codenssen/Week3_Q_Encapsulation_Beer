namespace Week3_Q_Encapsulation_Beer
{
    public class BeerEncapsulator
    {
        // Propriétés
        private double _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;
        public BeerEncapsulator(double avalaibleBeerVolume, int avalaibleBottles, int avalaibleCapsules)
        {
            _avalaibleBeerVolume = avalaibleBeerVolume;
            _avalaibleBottles = avalaibleBottles;
            _avalaibleCapsules = avalaibleCapsules;
        }

        public double GetBeerVolume
        {
            get { return _avalaibleBeerVolume; }
        }
        public int GetBottles
        {
            get { return _avalaibleBottles; }
        }
        public int GetCapsules
        {
            get { return _avalaibleCapsules; }
        }
        public double AddBeer(double beer)
        {
            _avalaibleBeerVolume += beer;
            return _avalaibleBeerVolume;
        }
        public int ProduceEncapsulatedBeerBottles(int numberOfBottles)
        {
            if (_avalaibleBeerVolume < numberOfBottles * 33)
            {
                Console.WriteLine($"Pas assez de bière. Rajouter {(numberOfBottles * 33) - _avalaibleBeerVolume} centilitres de bière.");
                return 0;
            }
            else if (_avalaibleBottles < numberOfBottles)
            {
                Console.WriteLine($"Pas assez de bouteilles. Rajouter {numberOfBottles - _avalaibleBottles} bouteilles.");
                return 0;
            }
            else if (_avalaibleCapsules < numberOfBottles)
            {
                Console.WriteLine($"Pas assez de capsules. Rajouter {numberOfBottles - _avalaibleCapsules} capsules.");
                return 0;
            }
            else
            {
                _avalaibleBeerVolume -= numberOfBottles * 33;
                _avalaibleBottles -= numberOfBottles;
                _avalaibleCapsules -= numberOfBottles;
                return numberOfBottles;
            }


        }
    }
}
