using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nilnul._obj.typ_.unison_
{

	/// <summary>
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	#region not use

	//[ThreadStatic] , each thread has a copy,A static field marked with ThreadStaticAttribute is not shared between threads. so donot use this here.
	#endregion
	static public  class _StaticCtorX<YourClass>
		where YourClass : new()
		//where YourClass:class
	{
		/// <summary>
		/// the leading "_" means this field is initialized outside ctor;
		/// </summary>
		
		static public readonly YourClass _Unison
		 //;
		 = new YourClass();

		//[MethodImpl(MethodImplOptions.Synchronized)]
		//private Singleton() { }

		///
		/// without static constructor, the [beforeFieldInit] attribute is applied. when you call a static non-field member such as method/property, the field might be not yet initalized and hence is still null.
		/// <summary>
		/// with static constructor, the [beforeFieldInit] attribute is removed. the field would be initialized (imediatly before this static constructor) before you call any static member including method.
		/// </summary>
		///
		static _StaticCtorX()
		{
			//_Instance = new YourClass();
		}/*
		  * learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
		  A static constructor is called automatically. It initializes the class before the first instance is created or any static members declared in that class (not its base classes) are referenced


If static field variable initializers are present in the class of the static constructor, they're executed in the textual order in which they appear in the class declaration. The initializers run immediately prior to the execution of the static constructor.

		  */

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