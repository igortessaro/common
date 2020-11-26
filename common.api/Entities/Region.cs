namespace common.api.Entities
{
    public sealed class Region
    {
        public Region(string name)
        {
            this.Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
    }
}
