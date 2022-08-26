using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public class Box_ofIn<TOriginal>
	{
		private  TOriginal _boxed;

		protected virtual ref TOriginal boxed
		{
			get { return ref _boxed; }
		}


		public Box_ofIn(in TOriginal val)
		{
			_boxed = val;
		}
		public Box_ofIn(TOriginal x):this(in x)
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


		static public implicit operator Box_ofIn<TOriginal>( TOriginal a)
		{
			return new Box_ofIn<TOriginal>(in a);
		}

	}


}
