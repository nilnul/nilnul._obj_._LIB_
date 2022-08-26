using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp_.ovNuly_.nulMin_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComp"></typeparam>
	/// <remarks>
	/// </remarks>
	public  class CompDefault4Struct<T, TComp>
		:
		NulMinOvStruct<T>

		where TComp:IComparer<T>,new()
		where T:struct
	{

		public CompDefault4Struct( )
			:base(
				nilnul.obj_.Singleton<TComp>.Instance	 
			)
		{

		}


		static public CompDefault4Struct<T, TComp> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CompDefault4Struct<T, TComp>>.Instance;
			}
		}



	}

	
}
