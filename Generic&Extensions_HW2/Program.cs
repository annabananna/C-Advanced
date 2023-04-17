namespace Generic_Extensions_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Lucy", "Angorka", 3, true, 5);
            Cat cat2 = new Cat("Tom", "Siberian", 5, false, 2);
            List<Cat> cats = new List<Cat>() { cat1, cat2 };

            Dog dog1 = new Dog("Max", "Buldog", 7, "meet");
            Dog dog2 = new Dog("Boo", "Pomerian", 6, "fish");
            List<Dog> dogs = new List<Dog>() { dog1, dog2 };

            Fish fish1 = new Fish("Eva", "Golden", 2, "gold", 3);
            Fish fish2 = new Fish("Moby", "Salmon", 1, "grey", 10);
            List<Fish> fishes = new List<Fish>() { fish1, fish2 };


            PetStore<Cat> catsStore = new PetStore<Cat>();
            PetStore<Dog> dogsStore = new PetStore<Dog>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            catsStore.PrintsPets(cats);
            dogsStore.PrintsPets(dogs);
            fishStore.PrintsPets(fishes);

            catsStore.BuyPet(cats,"Lucy");
            //catsStore.BuyPet(cats, "Jerry");  //throw exception

            dogsStore.BuyPet(dogs, "Boo");
        }
    }
}