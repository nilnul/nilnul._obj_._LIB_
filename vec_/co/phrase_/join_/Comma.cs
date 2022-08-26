using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple.phrase_.join_
{
	public class Comma<T, T1> : Join<T, T1>
	{
		public Comma() : base(",")
		{
		}

		static public Comma<T, T1> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Comma<T, T1>>.Instance;
			}
		}

	}
}
