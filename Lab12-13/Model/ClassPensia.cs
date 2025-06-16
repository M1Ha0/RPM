using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lab12_13.Model
{
    public class ClassPensia:IDataErrorInfo, INotifyPropertyChanged
    {
        private string? surName;
        public string? SurName
        {
            get { return surName; }
            set 
            {
                surName = value;
                OnPropertyChanged(nameof(SurName));
            } 
        }
        private string? name;
        public string? Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private string? lastName;
        public string? LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        private string? pol;
        public string? Pol
        {
            get { return pol; }
            set
            {
                pol = value;
                OnPropertyChanged(nameof(Pol));
            }
        }
        private string? national;
        public string? National
        {
            get { return national; }
            set
            {
                national = value;
                OnPropertyChanged(nameof(National));
            }
        }

        private DateTime? data;
        public DateTime? Date
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        private string? phone;
        public string? Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        private string? homeAdress;
        public string? HomeAdress
        {
            get { return homeAdress; }
            set
            {
                homeAdress = value;
                OnPropertyChanged(nameof(HomeAdress));
            }
        }

        public ClassPensia(string? surName, string? name, string? lastName,  string? pol,  string? national, DateTime? date, string? phone, string? homeAdress)
        {           
            SurName = surName;            
            Name = name;            
            LastName = lastName;            
            Pol = pol;
            Date = date;
            National = national;          
            Phone = phone;            
            HomeAdress = homeAdress;
        }

        public ClassPensia()
        {
        }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "SurName":
                        if (SurName != null)
                        {
                            if (!Regex.IsMatch(SurName!, @"^[А-Яа-яЁё]+$"))
                                error = "Поле не должно содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "Name":
                        if (Name != null)
                        {
                            if (!Regex.IsMatch(Name!, @"^[А-Яа-яЁё]+$"))
                                error = "Поле не должна содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "LastName":
                        if (LastName != null)
                        {
                            if (!Regex.IsMatch(LastName!, @"^[А-Яа-яЁё]+$"))
                                error = "Поле не должен содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "Pol":
                        if (Pol != null)
                        {
                            if (!Regex.IsMatch(Pol!, @"^[А-Яа-яЁё]+$"))
                                error = "Поле не должен содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "National":
                        if (National != null)
                        {
                            if (!Regex.IsMatch(National!, @"^[А-Яа-яЁё]+$"))
                                error = "Поле не должен содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "Phone":
                        if (Phone != null)
                        {
                            if (!Regex.IsMatch(Phone!, @"^\+?[0-9]+$"))
                                error = "Поле не должен содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "HomeAdress":
                        if (HomeAdress != null)
                        {
                            if (!Regex.IsMatch(HomeAdress!, @"[А-Яа-яЁё0-9]+$"))
                                error = "Поле не должен содержать вспомогательных символов";
                        }
                        else
                        {
                            error = "Поле не должно быть пустым";
                        }
                        break;
                    case "Date": break;
                }
                return error;
            }
        }

        public override string? ToString()
        {
            return SurName + " "+ Name + " "+ LastName + " "+ Pol + " "+ National + " " + Date + " "+ Phone + " "+ HomeAdress;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
