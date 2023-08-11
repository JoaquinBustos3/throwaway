using System;
using Xamarin.Forms;
namespace Practice.ViewModels
{
	public class MainViewModel : MyBaseViewModel
	{
        private int counter = 1;
		public int Counter
		{
			get { return counter; }
			set
			{
				SetProperty(ref counter, value);
				OnPropertyChanged(nameof(counter));
			}
		}

		public Command IncrementCounter { get; }

        public MainViewModel()
		{
			IncrementCounter = new Command(incrementCounter);
		}

		private void incrementCounter()
		{
			Counter = this.counter+1;
		}
	}
}

