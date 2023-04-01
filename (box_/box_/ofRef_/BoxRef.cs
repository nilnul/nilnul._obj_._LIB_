using System;
using System.Net;

namespace nilnul.obj.box_.ref_
{

	/// <summary>
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public class Pub<TOriginal>
	{
		private  TOriginal _boxed;

		public virtual ref TOriginal boxed
		{
			get { return ref _boxed; }
		}


		public Pub(ref TOriginal val)
		{
			_boxed = val;
		}
		public Pub(TOriginal x):this(ref x)
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


		static public implicit operator Pub<TOriginal>( TOriginal a)
		{
			return new Pub<TOriginal>(ref a);
		}

		//static public implicit operator  TOriginal( Pub< TOriginal> a)
		//{
		//	return ( a.boxed);
		//}

	}


}
