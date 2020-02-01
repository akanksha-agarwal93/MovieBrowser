using System;
using System.Collections.ObjectModel;
using MovieBrowser.Models;
using Prism.Navigation;

namespace MovieBrowser.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<MovieModel> _moviesList;

        public ObservableCollection<MovieModel> MoviesList
        {
            get => _moviesList;
            set
            {
                SetProperty(ref _moviesList, value);
            }
        }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            MoviesList = new ObservableCollection<MovieModel>() { new MovieModel(), new MovieModel() };
        }
    }
}
