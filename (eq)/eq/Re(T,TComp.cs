using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComp"></typeparam>
	/// <remarks>
	/// </remarks>
	public  class Re<T, TComp>
		:
		Re<T>

		where TComp:IEqualityComparer<T>,new()

	{

		public Re( )
			:base(
				nilnul._obj.Singleton<TComp>.Instance	 
			)
		{

		}

		static public  Re<T,TComp> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Re<T, TComp>>.Instance;
			}
		}



	}

	
}
