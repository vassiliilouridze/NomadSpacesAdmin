using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadSpacesAdmin.ViewModels
{
    public class ViewModelLocator
    {
        private MainPageViewModel _MainPageViewModel;
        public MainPageViewModel MainPageViewModel =>
                _MainPageViewModel ?? (_MainPageViewModel = new MainPageViewModel());

        private AddedSpacesViewModel _AddedSpacesViewModel;
        public AddedSpacesViewModel AddedSpacesViewModel =>
                _AddedSpacesViewModel ?? (_AddedSpacesViewModel = new AddedSpacesViewModel());

        private PendingSpacesViewModel _PendingSpacesViewModel;
        public PendingSpacesViewModel PendingSpacesViewModel =>
                _PendingSpacesViewModel ?? (_PendingSpacesViewModel = new PendingSpacesViewModel());
    }
}
