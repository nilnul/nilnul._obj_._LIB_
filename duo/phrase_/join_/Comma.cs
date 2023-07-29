using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_.join_
{
	public class Comma<T> : Join<T>
	{
		public Comma() : base(",")
		{
		}

		static public Comma<T> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Comma<T>>.Instance;
			}
		}

	}
}
