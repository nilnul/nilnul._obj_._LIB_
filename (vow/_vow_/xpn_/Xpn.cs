using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn
{
	public interface VowI
	{
		void vow(); //same as throw new T();
	}
	public interface VowI<T>:VowI
		where T:Exception
	{
	}

	public class Vow<T>
		:VowI<T>
		where T:Exception
	{
		private T _xpn;

		public T xpn
		{
			get { return _xpn; }
			set { _xpn = value; }
		}

		public Vow(T xpn)
		{
			this._xpn = xpn;
		}

		

		public void vow()
		{
			throw _xpn;
		}
	}

}
