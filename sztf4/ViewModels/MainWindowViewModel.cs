using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using sztf4.Model;

namespace sztf4.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string s = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        public BindingList<SuperHero> superHeroes { get; set; }
        public BindingList<SuperHero> selectedSuperHeroes;
        public SuperHero selectedHero;

        


        public MainWindowViewModel()
        {
            superHeroes = new BindingList<SuperHero>();
            selectedSuperHeroes = new BindingList<SuperHero>();

            superHeroes.Add(new SuperHero(){ Name = "SuperMan", Speed = 8, Strength = 8, Role = Role.Good });
            superHeroes.Add(new SuperHero() { Name = "BatMan", Speed = 4, Strength = 10, Role = Role.Neutral });
        }




    }
}
