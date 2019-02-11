using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WetterApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _zuletztAusgewählt;

        public ObservableCollection<string> Städteliste { get; set; } = new ObservableCollection<string>()
        {
            "Nürnberg",
            "Bamberg",
            "Schongau",
            "Leipzig",
            "Stuttgart",
            "Sevilla",
            "New York",
            "Chicago"
        };

        public ObservableCollection<WetterEintrag> Wettereinträge { get; set; } = new ObservableCollection<WetterEintrag>();


        public DelegateCommand UpdateCommand { get; set; }
        public DelegateCommand NeuesWetterCommand { get; set; }
        public DelegateCommand DeleteCommand { get; set; }
        public DelegateCommand DeleteCityCommand { get; set; }

        public string ZuletztAusgewählt
        {
            get => _zuletztAusgewählt;
            set
            {
                _zuletztAusgewählt = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ZuletztAusgewählt)));
            }
        }

        private string _eingegebeneStadt;

        public string EingegebeneStadt
        {
            get { return _eingegebeneStadt; }
            set
            {
                if (value.Length < 3)
                {
                    throw new FormatException("Zu wenige Buchstaben!");
                }
                _eingegebeneStadt = value;
            }
        }




        public void DeleteStadt()
        {
            if (ZuletztAusgewählt != null)
                Städteliste.Remove(ZuletztAusgewählt);
        }

        public MainWindowViewModel()
        {
            UpdateCommand = new DelegateCommand(p => Update(), p => Wettereinträge.Count > 0);
            NeuesWetterCommand = new DelegateCommand(p => FügeNeuenWetterEintragHinzu(p?.ToString()), p =>
            {
                if (p == null || p.ToString().Length < 3)
                    return false;
                return true;
            });
            DeleteCommand = new DelegateCommand(p => Delete(p as WetterEintrag));
            DeleteCityCommand = new DelegateCommand(p => DeleteStadt());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Delete(WetterEintrag eintrag)
        {
            if (eintrag == null)
                return;

            if (!Städteliste.Contains(eintrag.Stadtname) && string.IsNullOrWhiteSpace(eintrag.ErrorMessage))
            {
                Städteliste.Add(eintrag.Stadtname);
            }
            Wettereinträge.Remove(eintrag);
        }

        public void Update()
        {
            foreach (var item in Wettereinträge)
            {
                WetterAPIService.ErmittleWetter(item);
            }
        }

        public void FügeNeuenWetterEintragHinzu(string stadt)
        {
            WetterEintrag eintrag = new WetterEintrag(stadt, 0, string.Empty);

            //Lambda-Ausruck für anonyme Methode
            if(Wettereinträge.Any(wetter => wetter.Stadtname == stadt))
            {
                return;
            }

            Wettereinträge.Add(eintrag);

            //API Aufruf
            WetterAPIService.ErmittleWetter(eintrag);
        }

    }
}
