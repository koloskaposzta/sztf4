using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf4.Model
{
  public  class SuperHero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }

        public Role Role { get; set; }
        
        public SuperHero Masol()
        {
            return new SuperHero()
            {
                Name = this.Name,
                Strength = this.Strength,
                Speed = this.Speed,
                Role = this.Role
                
            };
        }
    }
}
