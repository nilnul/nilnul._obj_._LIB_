using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple.phrase_.join_
{
	public class Line<T, T1> : Join<T, T1>
	{
		public Line() : base(Environment.NewLine)
		{
		}

		static public Line<T, T1> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Line<T, T1>>.Instance;
			}
		}

	}
}
