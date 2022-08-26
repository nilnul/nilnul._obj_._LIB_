using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_.join_
{
	public class Empty<T> : Join<T>
	{
		public Empty() : base("")
		{
		}

		static public Empty<T> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Empty<T>>.Instance;
			}
		}

	}
}
