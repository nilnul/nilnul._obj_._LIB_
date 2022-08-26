using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_.ovComparer_
{
	public class ComparerDefault<T, TComparer>
		: eq_.OvComparer<T>
		where TComparer : IComparer<T>, new()
	{
		public ComparerDefault() : base(nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}
	}
}
