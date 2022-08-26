using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple.phrase_.join_
{
	public class Empty<T, T1> : Join<T, T1>
	{
		public Empty() : base("")
		{
		}

		static public Empty<T, T1> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Empty<T, T1>>.Instance;
			}
		}

	}
}
