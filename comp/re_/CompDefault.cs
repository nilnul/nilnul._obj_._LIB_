using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComp"></typeparam>
	/// <remarks>
	/// comp is deliberately named to innuendo:
	///		1) comparere
	///		2) complete. in regards to the fact that: a comparer itself doesn't make the releation "total order"; it only make it "complete" (in other words total). Note: a total order is not only compelte, it 's also order(reflexive, transitive, and antisymmetric)
	/// </remarks>
	public  class CompDefault<T, TComp>
		:
		nilnul.obj.comp.Re<T>

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
