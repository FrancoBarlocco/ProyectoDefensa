using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public class MaterialType
    {
        public string Name { get; set; }

        public bool IsDangerous { get; set; }

        public MaterialType(string names, bool isDangerous)
        {
            this.Name = names;
            this.IsDangerous = isDangerous;
            
        }

        public string NameGet()
        {
            return this.Name;
        }

    }
}