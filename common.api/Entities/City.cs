namespace common.api.Entities
{
    public sealed class City
    {
        public City(string name, int stateId)
        {
            this.Name = name;
            this.StateId = stateId;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public int StateId { get; private set; }
    }
}
