using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	/// 
	[Obsolete(nameof(nilnul._obj.singleton_.Lazy<YourClass>))]
	public class SingletonByLazy<YourClass>
		where YourClass:new()
		//where YourClass:class
	{


		static private Lazy<YourClass> _Lazy = new Lazy<YourClass>();
		static public YourClass Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


	}
}
