namespace LR_4_ZIMINA_BPI_24_01.Helper
{
    public class FindPerson
    {
        int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Model.Person person)
        {
            return person.Id == id;
        }
    }
}