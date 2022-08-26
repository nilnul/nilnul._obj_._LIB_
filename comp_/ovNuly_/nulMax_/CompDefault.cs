using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp_.ovNuly_.nulMax_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComp"></typeparam>
	/// <remarks>
	/// </remarks>
	public  class CompDefault<T, TComp>
		:
		NulMax<T>

		where TComp:IComparer<T>,new()

	{

		public CompDefault( )
			:base(
				nilnul.obj_.Singleton<TComp>.Instance	 
			)
		{

		}


		static public CompDefault<T, TComp> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CompDefault<T, TComp>>.Instance;
			}
		}



	}

	
}
