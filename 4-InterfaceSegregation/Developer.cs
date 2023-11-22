namespace InterfaceSegregation
{
    public class Developer : IWorkTeamActivities,IDevelopActivities
    {
        public Developer()
        {
            
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            Console.WriteLine("Implementaciones de Interface para Desarrollador");
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
    }
}