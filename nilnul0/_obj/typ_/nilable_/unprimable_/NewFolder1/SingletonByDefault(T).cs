using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj_
{
	/// <summary>
	/// a type is called singleton, if the type can create one and only one instance.
	/// inheriting this type doesnot make the child type a singleton, as inherited type decorates the instance (any instances created,possibly many), not the type. So this marker is only a marker to tip programmers, not typesafe.
	///		To solve this, there must be mechanisms to constrain the type. Generic parameter may be the way to go; <seealso cref="nameof(Singleton{YourClass})"/>; but the generic type cannot inherit the type parameter, so implicit type conversion may be utilized. 
	/// </summary>
	///
	//[Obsolete(nameof(nilnul._obj.typ_.nilable_.unprimable_))]
	//interface ISingleton
	//{

	//}

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor to inherti this.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	///
	#region not use

	//[ThreadStatic] , each thread has a copy,A static field marked with ThreadStaticAttribute is not shared between threads. so donot use this here.
	#endregion
	[Obsolete(nameof( nilnul._obj.typ_.nilable_.unprimable_.Singleton<YourClass> ))]
	public sealed class Singleton<YourClass>
		where YourClass : new()
		//where YourClass:class
	{



		static private readonly YourClass _Instance = new YourClass();
		static public YourClass Instance
		{
			get
			{
				return _Instance;
				// _Instance = _Instance ?? new YourClass();// some one online suggested this, but "error: ?? cannot be appplied on YourClass and YourClass"
				//return _Instance;
			}
		}

		/// <summary>
		/// with static constructor, the [beforeFieldInit] attribute is removed. the field would be initialized imediatly before this static constructor, before you call any static member including method.
		/// without static constructor, the [beforeFieldInit] attribute is applied. when you call a static non-field member such as method/property, the field might be not yet initalized and hence is still null.
		/// </summary>
		static Singleton(){
		}

		[Obsolete("make this type to be of single responsibility; and impelement extra features in new type, or in a new alternative")]
		private Singleton()
		{

		}

		/// <summary>
		/// always returns the same instance
		/// </summary>
		///
		[Obsolete("make this type to be of single responsibility; and impelement extra features in new type, or in a new alternative")]
		YourClass instance
		{
			get
			{
				return
				 nilnul._obj.typ_.nilable_.unprimable_.Singleton<YourClass>.Instance;


				//return _Instance;
			}
		}

		[Obsolete("make this type to be of single responsibility; and impelement extra features in new type, or in a new alternative")]
		static public implicit operator YourClass(Singleton<YourClass> x)
		{
			return x.instance;
		}



	}


}
