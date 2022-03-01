using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sztf4.Model;

namespace sztf4.ViewModels
{
    public class HeroEditorViewModel
    {
        public SuperHero   Actual { get; set; }

        public HeroEditorViewModel(SuperHero actual)
        {
            Actual = actual;
        }

        public HeroEditorViewModel()
        {
        }

        public void Setup(SuperHero superHero)
        {
            this.Actual = superHero;
        }
    }
}
