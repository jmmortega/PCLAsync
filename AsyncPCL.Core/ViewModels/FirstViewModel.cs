using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace AsyncPCL.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private string _hello;
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public ICommand SayHello
        {
            get
            {
                return new MvxCommand(() =>
                {

                });
            }
        }

    }
}
