using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public  class Box_pub<TOriginal>
		:nilnul.obj.Box<TOriginal>
	{
		
		public Box_pub(TOriginal val):base(val)
		{
		}

		public  TOriginal boxed
		{
			get { return base.boxed; }
		}



		static public implicit operator TOriginal(Box_pub<TOriginal> a) {
			return a.boxed;
		}
		static public implicit operator Box_pub<TOriginal>(TOriginal a) {
			return new Box_pub<TOriginal>(a);
		}

	}

	
}
