using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace NovLocator.ViewModels
{
	public class ViewModelLocator
	{

		static ViewModelLocator()
		{

			ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

			SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<FacilityMapViewModel>();

		}

		/// <summary>
		/// Gets the Main property.
		/// </summary>
		public MainViewModel Main { get { return ServiceLocator.Current.GetInstance<MainViewModel>(); } }

		public FacilityMapViewModel FacilityMap { get { return ServiceLocator.Current.GetInstance<FacilityMapViewModel>(); } }

	}
}
