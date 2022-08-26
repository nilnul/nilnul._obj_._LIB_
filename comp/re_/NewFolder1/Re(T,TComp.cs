using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp
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
	///
	[Obsolete()]
	public  class Re<T, TComp>
		:
		Re<T>

		where TComp:IComparer<T>,new()

	{

		public Re( )
			:base(
				SingletonByDefault<TComp>.Instance	 
			)
		{

		}

		static public readonly Re<T,TComp> Singleton = nilnul.obj.SingletonByDefault<Re<T,TComp>>.Instance;



	}

	
}
