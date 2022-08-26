using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public  class Adapter<TOriginal>
	{
		protected TOriginal _val;

		public Adapter(TOriginal val)
		{
			this._val = val;
		}
					

	


	}

}
