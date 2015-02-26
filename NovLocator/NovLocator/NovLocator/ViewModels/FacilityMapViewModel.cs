using GalaSoft.MvvmLight;
using NovLocator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovLocator.ViewModels
{
	public class FacilityMapViewModel : ViewModelBase
	{

		private Facility _current;
		public Facility Current
		{
			get {return _current;}
			set {if(Set(() => Current, ref _current, value)){ RaisePropertyChanged(() => Current); }}
		}

	}
}
