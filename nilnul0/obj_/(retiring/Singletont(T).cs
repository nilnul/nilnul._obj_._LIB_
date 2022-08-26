using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._obj
{

	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete()]
	public class Singleton<T>
		where T:new()
		//where YourClass:class
	{



		static private readonly  T _Instance= new T();
		static public T Instance
		{
			get
			{
				return _Instance;
				// _Instance = _Instance ?? new YourClass();// some one online suggested this, but "error: ?? cannot be appplied on YourClass and YourClass"
				//return _Instance;
			}
		}

		private Singleton() {
		}
				
	}
}
