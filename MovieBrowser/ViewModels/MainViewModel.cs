using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MovieBrowser.IService.IServices;
using MovieBrowser.Models;
using Prism.Navigation;

namespace MovieBrowser.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IMovieService movieService;
        private ObservableCollection<MovieObject> _moviesList;

        public ObservableCollection<MovieObject> MoviesList
        {
            get
            {
                return _moviesList;
            }
            set
            {
                SetProperty(ref _moviesList, value);
                RaisePropertyChanged(nameof(MoviesList));
            }
        }

        public MainViewModel(INavigationService navigationService, IMovieService movieService) : base(navigationService)
        {
            this.movieService = movieService;
            MoviesList = new ObservableCollection<MovieObject>();
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (!IsBusy)
            {
                IsBusy = true;
                var result = await movieService.GetListOfMovies(1);
                if (result != null && result.results.Count > 0)
                {
                    MoviesList = new ObservableCollection<MovieObject>(result.results);
                }
            }
            IsBusy = false;
        }

    }
}
