using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_.join_
{
	public class Line<T> : Join<T>
	{
		public Line() : base(",")
		{
		}

		static public Line<T> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Line<T>>.Instance;
			}
		}

	}
}
