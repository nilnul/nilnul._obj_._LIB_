using System;
using System.Net;

namespace nilnul.obj.box_
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public class NoCast<TOriginal>
	{
		private TOriginal _boxed;

		protected virtual TOriginal boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}


		public NoCast(TOriginal val)
		{
			_boxed = val;
		}

	
		/// <summary>
		/// can be overriden 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return boxed.ToString();
		}


		static public implicit operator NoCast<TOriginal>(TOriginal a)
		{
			return new NoCast<TOriginal>(a);
		}

	}


}
