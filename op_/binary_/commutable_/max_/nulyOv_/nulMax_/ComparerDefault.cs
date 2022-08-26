#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_.nulMax_
{
	public class ComparerDefault<T, TComparer> : NulMax<T>
		where TComparer : IComparer<T>, new()
		where T: class?
	{
		public ComparerDefault() : base(obj_.Singleton<TComparer>.Instance)
		{
		}


		static public ComparerDefault<T, TComparer> Singleton
		{
			get
			{
				return obj_.Singleton<ComparerDefault<T, TComparer>>.Instance;
			}
		}

	}
}
