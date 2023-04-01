using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public class BoxRef<TOriginal>
	{
		private  TOriginal _boxed;

		protected virtual ref TOriginal boxed
		{
			get { return ref _boxed; }
		}


		public BoxRef(ref TOriginal val)
		{
			_boxed = val;
		}
		public BoxRef(TOriginal x):this(ref x)
		{

		}

	
		/// <summary>
		/// can be overriden 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return boxed.ToString();
		}


		static public implicit operator BoxRef<TOriginal>( TOriginal a)
		{
			return new BoxRef<TOriginal>(ref a);
		}

	}


}
