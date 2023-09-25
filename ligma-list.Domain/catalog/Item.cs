using System;

namespace ligma_list.Domain.catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int IsNeeded { get; set; }

        public Item(string name, int isNeeded)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(name);
            }

            if (isNeeded < 0 || isNeeded > 1)
            {
                throw new ArgumentException("Must be 0 or 1");
            }

            Name = name;
            IsNeeded = isNeeded;
        }
    }
}