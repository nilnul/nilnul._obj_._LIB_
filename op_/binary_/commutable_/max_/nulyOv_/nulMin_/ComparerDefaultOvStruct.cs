#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_.nulMin_
{
	public class ComparerDefaultOvStruct<T, TComparer> : NulMinOvStruct<T>
		where TComparer : IComparer<T>, new()
		where T: struct
	{
		public ComparerDefaultOvStruct() : base(obj_.Singleton<TComparer>.Instance)
		{
		}


		static public ComparerDefaultOvStruct<T, TComparer> Singleton
		{
			get
			{
				return obj_.Singleton<ComparerDefaultOvStruct<T, TComparer>>.Instance;
			}
		}

	}
}
