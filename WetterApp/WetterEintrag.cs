using System.ComponentModel;

namespace WetterApp
{
    public class WetterEintrag : INotifyPropertyChanged
    {
        private string _stadtname;
        private double _temperatur;
        private string _iconURL;
        private bool _aktualisiert = false;
        private string _errorMessage = string.Empty;

        public string Stadtname
        {
            get => _stadtname; set
            {
                _stadtname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Stadtname)));
            }
        }
        public double Temperatur
        {
            get => _temperatur; set
            {
                _temperatur = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Temperatur)));
            }
        }
        public string IconURL
        {
            get => _iconURL; set
            {
                _iconURL = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IconURL)));
            }
        }
        public bool Aktualisiert
        {
            get => _aktualisiert; set
            {
                _aktualisiert = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Aktualisiert)));
            }
        }
        public string ErrorMessage
        {
            get => _errorMessage; set
            {
                _errorMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ErrorMessage)));
            }
        }


        public WetterEintrag(string stadtname, double temperatur, string iconURL)
        {
            Stadtname = stadtname;
            Temperatur = temperatur;
            IconURL = iconURL;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}