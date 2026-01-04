using InterfaceAssignmentOne.Interface;

namespace InterfaceAssignmentOne.Model
{
    internal class Animal : IMammals
    {
        // method implementation
        public int GetBodyTemp(string animalName)
        {
           
            if (animalName.ToLower() == "cat")
                return 38;
            else if (animalName.ToLower() == "dog")
                return 39;
            else
                return 37; 
        }
    }
}
