using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul._obj.typ_.nilable_.unprimable_
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor to inherti this.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	#region not use

	//[ThreadStatic] , each thread has a copy,A static field marked with ThreadStaticAttribute is not shared between threads. so donot use this here.
	#endregion

	[Obsolete(nameof(typ_._UnisonX<YourClass>))]
	static public  class Singleton<YourClass>
		where YourClass : new()
		//where YourClass:class
	{
		
		static public readonly YourClass Instance
		 //;
		 = new YourClass();

		//[MethodImpl(MethodImplOptions.Synchronized)]
		//private Singleton() { }

		/// without static constructor, the [beforeFieldInit] attribute is applied. when you call a static non-field member such as method/property, the field might be not yet initalized and hence is still null.
		/// <summary>
		/// with static constructor, the [beforeFieldInit] attribute is removed. the field would be initialized (imediatly before this static constructor) before you call any static member including method.
		/// </summary>
		///
		static Singleton()
		{
			//_Instance = new YourClass();
		}

		//[ThreadStatic]
		//static public YourClass GetInstance() {
		//	return _Instance;
		//}


		//static public YourClass Instance
		//{
		//	get
		//	{
		//		return _Instance;
		//		// _Instance = _Instance ?? new YourClass();// some one online suggested this, but "error: ?? cannot be appplied on YourClass and YourClass"
		//		//return _Instance;
		//	}
		//}

	}
}