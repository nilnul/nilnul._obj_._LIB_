using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj_.singleton_
{

	/// <summary>
	/// if a class inherits Singleton(), it's a singleton.
	/// your class must have a protected ctor.
	/// </summary>
	/// <typeparam name="YourClass"></typeparam>
	///
	[Obsolete("we encountered some issues(Intance NullReference) with this; further investigation needed to confirm. " +
			"we donot know whether adding a static ctor would sweep way the NullReferenceException." +
		"" +
		"use " + nameof(obj_.Singleton<YourClass>) + " instead for now")]
	public
		/*sealed*/  /// mark this in next major, not in this major, as mark this as sealed may break subtype implemented in subsequent assembly. 
		class
		Lazy	// consider changing this name (into like "ByLazy") to avoid conflict with system built-in namesake.
		<YourClass>
		where YourClass : new()
		//where YourClass:class
	{

		/// <summary>
		/// this might be null when default-initiazlizing.
		/// </summary>
		/// <remarks>
		/// cuz System.Lazy need to be constructed eagerly, so if YourClass construction is not time-consuming, to create a lazy class beforehand is not worthy the saved time by the slack/delay offered by lazily creating YourClass
		/// </remarks>

		static private System.Lazy<YourClass> _Instance = new System.Lazy<YourClass>(nilnul._obj.typ_.unison_._LazylyX.MODE);

		/// <summary>
		/// this might be null when _Instance is null. when void of static ctor, [beforeFieldInit] is applied, and the property/member access would requires no initialization of field, so the field might be null.
		/// </summary>
		static public YourClass Instance
		{
			get
			{
				///this has access to the static field, so field init would happen before ".Value". so the static constructor is not necessary.
				return _Instance.Value;
			}
		}

		[Obsolete("we encountered some issues(Intance NullReference) with this; further investigation needed to confirm. " +
			"we donot know whether adding a static ctor would sweep way the NullReferenceException." +
			"use " + nameof(obj_.Singleton<YourClass>) + " instead for now. ")]
		static Lazy()	//due to the "Intance" body has access to "_Instance", so "_Instance will be initalized". So maybe we can remove this static constructor?
		{ }

	}
}
