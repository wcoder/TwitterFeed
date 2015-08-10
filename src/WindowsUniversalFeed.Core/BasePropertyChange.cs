using System.ComponentModel;
using System.Runtime.CompilerServices;
using WindowsUniversalFeed.Core.Annotations;

namespace WindowsUniversalFeed.Core
{
	public class BasePropertyChange : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
