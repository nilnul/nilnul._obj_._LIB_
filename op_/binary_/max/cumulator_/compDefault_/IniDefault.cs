using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.max.cumulator_.compDefault_
{
	public class IniDefault<T, TComparer>
		: ComparerDefault<T,TComparer>
		where TComparer : IComparer<T>, new()
		where T:new()
	{
		public IniDefault()
			:
			base( nilnul.obj_.Singleton<T>.Instance)
		{
		}

		static public IniDefault<T, TComparer> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<IniDefault<T, TComparer>>.Instance;
			}
		}

	}
}
