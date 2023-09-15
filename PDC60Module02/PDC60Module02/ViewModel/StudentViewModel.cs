using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PDC60Module02.Model;
using Xamarin.Forms;

namespace PDC60Module02.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }

        public string SubjectCodeEntry { get; set; }
        public string SubjectCodeDisplay { get; set; }

        public string SubjectTitleEntry { get; set; }
        public string SubjectTitleDisplay { get; set; }

        public string SubjectUnitEntry { get; set; }
        public string SubjectUnitDisplay { get; set; }

        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    SubjectCode = SubjectCodeEntry,
                };
                SubjectCodeDisplay = SubjectCodeEntry;
                SubjectTitleDisplay = SubjectTitleEntry;
                SubjectUnitDisplay = SubjectUnitEntry;

                OnPropertyChanged(nameof(SubjectCodeDisplay));
                OnPropertyChanged(nameof(SubjectCodeEntry));

                OnPropertyChanged(nameof(SubjectTitleDisplay));
                OnPropertyChanged(nameof(SubjectTitleEntry));

                OnPropertyChanged(nameof(SubjectUnitDisplay));
                OnPropertyChanged(nameof(SubjectUnitEntry));
            });
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
    }
}
