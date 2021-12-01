using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }
        List<Material> Matdangerous = new List<Material>();

        public bool IsDangerous{get; set;}


        public Material(string name, MaterialType type)
        {
            this.Name = name;

            if(IsDangerous is true)
            {
                this.IsDangerous = true;
            }

        }

        public bool Dangerous(Material material)
        {
            if (Matdangerous.Contains(material))
            {
                return this.IsDangerous = true;
            }
            return this.IsDangerous = false;

            
        }
    }

}