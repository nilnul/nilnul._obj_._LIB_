﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow_
{
	/// <summary>
	/// this guy is cynical and is not satifiable with anything.
	/// </summary>
	public class None<TXpn>
		where TXpn:Exception,new()
	{


		private TXpn _exception;

		public virtual TXpn exception
		{
			get { return _exception; }
			set { _exception = value; }
		}

		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="src"></param>
		public None(string src)
		{
			_exception = new TXpn(){Source = src};
		}

		public None(TXpn exception) {
			_exception = exception;
		}
		public None():this("")
		{

		}

		public void vow()
		{
				throw _exception;
		
			//throw new NotImplementedException();
		}

		static public void Vow() {
				throw new _none.UnacceptableException();

		}

		static public void Vow(Exception exception) {
				throw exception;

		}




		/// <summary>
		/// if this aver is used once.
		/// However if the aver would be used later, you may prefer to instantiate a new instance.
		/// </summary>
		/// <param name="err"></param>
		static public void Vow(string err="") {
				throw new _none.UnacceptableException(err);

		}

		static public None Singleton
		{
			get
			{
				return nilnul._obj.Singleton<None>.Instance;
			}
		}


	}
}
