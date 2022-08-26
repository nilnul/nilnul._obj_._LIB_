using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.aver_
{
	/// <summary>
	/// this guy is cynical and is not satifiable with anything.
	/// </summary>
	public class None1
		: nilnul.obj._aver_.AcceptNoneI
	{


		private Exception _exception;

		public Exception exception
		{
			get { return _exception; }
			set { _exception = value; }
		}

		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="exceptionMsg"></param>
		public None1(string exceptionMsg)
		{
			_exception = new _none.UnacceptableException(exceptionMsg);
		}

		public None1(Exception exception) {
			_exception = exception;
		}
		public None1():this("")
		{

		}

		public void aver()
		{
				throw _exception;
		
			//throw new NotImplementedException();
		}
		static public void Aver() {
				throw new _none.UnacceptableException();

		}

		static public void Aver(Exception exception) {
				throw exception;

		}


		/// <summary>
		/// if this aver is used once.
		/// However if the aver would be used later, you may prefer to instantiate a new instance.
		/// </summary>
		/// <param name="err"></param>
		static public void Aver(string err="") {
				throw new _none.UnacceptableException(err);

		}

		static public readonly None1 Singleton = SingletonByDefault<None1>.Instance;

	}
}
