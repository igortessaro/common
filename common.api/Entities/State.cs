﻿namespace common.api.Entities
{
    public sealed class State
    {
        public State(string name, string initials, int regionId)
        {
            this.Name = name;
            this.Initials = initials;
            this.RegionId = regionId;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Initials { get; private set; }

        public int RegionId { get; private set; }
    }
}
