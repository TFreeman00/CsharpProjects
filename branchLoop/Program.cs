string anotherPet = "y";
int petCount = 0;


for (int i = 0; i < maxPets; i++)
{
  if (ourAnimals[i, 0] != "ID #: ")
  {
    petCount += 1;
  }
}