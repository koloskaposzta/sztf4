using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using sztf4.Model;
using sztf4.ViewModels;

namespace sztf4
{
    /// <summary>
    /// Interaction logic for HeroEditor.xaml
    /// </summary>
    public partial class HeroEditor : Window
    {
        public HeroEditor()
        {
            InitializeComponent();
            var s = new SuperHero() { Name = "Dummy", Role = Role.Neutral, Speed = 5, Strength = 5 };

            var vm = new HeroEditorViewModel();
            vm.Setup(s);
            this.DataContext = vm;
        }
    }
}
