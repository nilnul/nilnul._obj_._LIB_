using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	///
	[Obsolete()]
	[Serializable]

	public class Box<TOriginal>
	{
		private TOriginal _boxed;

		protected virtual TOriginal boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}


		public Box(TOriginal val)
		{
			_boxed = val;
		}
					
		//[Obsolete()]. this is public
		public TOriginal toOriginal() {

			return _boxed;
		}

		public override string ToString()
		{
			return boxed.ToString();
		}

		/// <summary>
		/// this is overkill. in some case we may don't want this. for example, when boxing a txt that is the arg, we may want the txt casted as an escaped one other than the boxed one.
		/// </summary>
		/// <param name="a"></param>
		static public implicit operator TOriginal(Box<TOriginal> a) {
			return a.boxed;
		}
		static public implicit operator Box<TOriginal>(TOriginal a) {
			return new Box<TOriginal>(a);
		}

	}

	
}
