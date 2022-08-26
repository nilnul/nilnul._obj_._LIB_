using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comparer.converse_
{
	/// <summary>
	/// comparer defined a relation that is total, linear order.
	/// Converse of such relation means 
	/// </summary>
	///
	[Obsolete()]
	public class ComparerDefault<T,TComparer> :
		nilnul.obj.comparer.Converse<T>
		where TComparer:IComparer<T>,new()
	{
		public ComparerDefault() : base(nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}


		static public ComparerDefault<T,TComparer> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault<T,TComparer>>.Instance;
			}
		}



	}
}
