using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul._obj.singleton_
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	///
	[Obsolete(nameof(nilnul._obj.typ_.nilable_.unprimable_.Singleton<YourClass>))]

	public class Lazy<YourClass>
		where YourClass:new()
		//where YourClass:class
	{


		static private System.Lazy<YourClass> _Instance = new System.Lazy<YourClass>(nilnul._obj.typ_.unison_._LazylyX.MODE);
		static public YourClass Instance
		{
			get
			{
				return _Instance.Value;
			}
		}


	}
}
