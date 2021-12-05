using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MahAppsTest.Annotations;

namespace MahAppsTest
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Desc { get; set; }
    }

    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Character> Data { get; set; } = new List<Character>()
        {
            new Character()
            {
                Name = "Klee", Gender = "Female", Desc = "Red"
            },

            new Character()
            {
                Name = "Xingqiu", Gender = "Male", Desc = "Blue"
            }
        };

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
