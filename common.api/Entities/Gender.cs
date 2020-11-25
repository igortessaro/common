namespace common.api.Entities
{
    public sealed class Gender
    {
        public Gender(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
