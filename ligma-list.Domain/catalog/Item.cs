using System;

namespace ligma_list.Domain.catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(name);
            }

            Name = name;
        }
    }
}