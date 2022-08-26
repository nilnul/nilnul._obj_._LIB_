using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	///
	[Serializable]
	public class Box1<TOriginal>
	{
		private TOriginal _boxed;

		protected virtual TOriginal boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}


		public Box1(TOriginal val)
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


		static public implicit operator Box1<TOriginal>(TOriginal a)
		{
			return new Box1<TOriginal>(a);
		}

	}


}
