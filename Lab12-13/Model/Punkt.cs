using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12_13.Model
{
    public class Punkt : IDataErrorInfo, INotifyPropertyChanged
    {
        private string? namePunkt;
        public string? NamePunkt
        {
            get { return namePunkt; }
            set
            {
                namePunkt = value;
                OnPropertyChanged(nameof(NamePunkt));
            }
        }
        private int chel;
        public int Chel
        {
            get { return chel; }
            set
            {
                chel = value;
                OnPropertyChanged(nameof(Chel));
            }
        }
        private double rast;
        public double Rast
        {
            get { return rast; }
            set
            {
                rast = value;
                OnPropertyChanged(nameof(Rast));
            }
        }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "NamePunkt":
                        if (NamePunkt != null)
                        {
                            if (!Regex.IsMatch(NamePunkt!, @"[A-Za-z]+$"))
                                error = "Имя не должно содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Имя не должно быть пустым";
                        }
                        break;
                    case "Chel":
                        if (Chel <= 0)
                            error = "Поле не должно быть равно нулю или отрицательным";
                        break;
                    case "Rast":
                        if (Rast <= 0)
                            error = "Поле не должно быть равно нулю или отрицательным";
                        break;

                }
                return error;
            }
        }

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
