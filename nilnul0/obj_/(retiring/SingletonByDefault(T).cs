using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor to inherti this.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	/// 
	[Obsolete(nameof(nilnul._obj.Singleton<YourClass>))]
	public class SingletonByDefault<YourClass>
		where YourClass:new()
		//where YourClass:class
	{



		static private readonly  YourClass _Instance= new YourClass();
		static public YourClass Instance
		{
			get
			{
				return _Instance;
				// _Instance = _Instance ?? new YourClass();// some one online suggested this, but "error: ?? cannot be appplied on YourClass and YourClass"
				//return _Instance;
			}
		}

		private SingletonByDefault() {
		}
				
	}
}
