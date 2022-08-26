using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.min_
{
	public class ComparerDefault<T, TComparer> : Min<T>
		where TComparer : IComparer<T>, new()
	{
		public ComparerDefault() : base(nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}


		static public ComparerDefault<T, TComparer> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault<T, TComparer>>.Instance;
			}
		}

	}
}
