using Lab12_13.Infractructure.Commands;
using Lab12_13.Model;
using Lab12_13.View;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Lab12_13.ViewModel
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private ClassPensia? selectedPensia;
        public ClassPensia? SelectedPensia
        {
            get { return selectedPensia; }
            set
            {
                selectedPensia = value;
                OnPropertyChanged(nameof(SelectedPensia));
            }
        }
        public ObservableCollection<ClassPensia> Pensias { get; set; }
        public ObservableCollection<Punkt> Punkts { get; set; }
        private int records;
        public int Records
        {
            get { return records; }
            set 
            { 
                records = value;
                OnPropertyChanged(nameof(Records));
            }
        }
        public MainViewModel()
        {
            Pensias = new ObservableCollection<ClassPensia>();
        }
        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      PensiaView view = new PensiaView(new ClassPensia());
                      if (view.ShowDialog() == true)
                      {
                          ClassPensia pensia = view.Pensia;
                          Pensias.Add(pensia);
                      }
                      Records = Pensias.Count;
                  }));
            }
        }
        private RelayCommand? addCommandBinary;
        public RelayCommand AddCommandBinary
        {
            get
            {
                return addCommandBinary ??
                  (addCommandBinary = new RelayCommand((o) =>
                  {
                      PunktView view = new PunktView(new Punkt());
                      if (view.ShowDialog() == true)
                      {
                          Punkt punkti = view.ThisPunkt;
                          Punkts.Add(punkti);
                      }
                  }));
            }
        }
        private RelayCommand? deletePensia;
        public RelayCommand DeletePensia
        {
            get
            {
                return deletePensia ??
                  (deletePensia = new RelayCommand((o) =>
                  {
                      Pensias.Remove(SelectedPensia!);
                      Records = Pensias.Count;
                  }));
            }
        }
        private RelayCommand? doubleCommand;
        public RelayCommand DoubleCommand
        {
            get
            {
                return doubleCommand ??
                  (doubleCommand = new RelayCommand((o) =>
                  {
                      PensiaView view = new PensiaView(SelectedPensia!);
                      if (view.ShowDialog() == true)
                      {
                          ClassPensia pensia = view.Pensia;
                          ClassPensia editPensia = Pensias.FirstOrDefault(pensia);
                          editPensia = pensia;
                      }
                      Records = Pensias.Count;
                  }));
            }
        }
        private RelayCommand? saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(async (o) =>
                  {
                      SaveFileDialog sfd = new SaveFileDialog();
                      sfd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                      if (sfd.ShowDialog() == true)
                      {
                          using (StreamWriter writer=new StreamWriter(sfd.FileName,false))
                          {
                              foreach(ClassPensia i in Pensias)
                              {
                                  await writer.WriteLineAsync(i.ToString());
                              }
                          }
                      }
                  }));
            }
        }
        private RelayCommand? clearCommand;
        public RelayCommand ClearCommand
        {
            get
            {
                return clearCommand ??
                  (clearCommand = new RelayCommand((o) =>
                  {
                      Pensias.Clear();
                      Records = Pensias.Count;
                  }));
            }
        }
        private RelayCommand? openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(async (o) =>
                  {
                      OpenFileDialog ofd = new OpenFileDialog();
                      ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                      if (ofd.ShowDialog() == true)
                      {
                          using (StreamReader reader = new StreamReader(ofd.FileName))
                          {
                              string? line;
                              while((line=await reader.ReadLineAsync()) != null)
                              {
                                  string[] mas = line.Split(" ");
                                  ClassPensia pensia = new ClassPensia
                                  (mas[0],
                                   mas[1],
                                   mas[2], 
                                   mas[3],
                                   mas[4],
                                   DateTime.Parse(mas[5]),
                                   mas[6], 
                                   mas[7]);
                                  Pensias.Add(pensia);
                              }
                              Records = Pensias.Count;
                          }
                      }
                  }));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
