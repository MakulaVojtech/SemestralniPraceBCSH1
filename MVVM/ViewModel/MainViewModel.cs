using Makula_semestralni_prace.Core;
using Makula_semestralni_prace.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makula_semestralni_prace.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set
            { 
                currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel( )
        {
            CompetitorsViewModel = new CompetitorsViewModel();

            CurrentView = CompetitorsViewModel;

            BaseModel bm = new BaseModel();
        }



        #region viewModels
        public CompetitorsViewModel CompetitorsViewModel { get; set; }




        #endregion
    }
}
