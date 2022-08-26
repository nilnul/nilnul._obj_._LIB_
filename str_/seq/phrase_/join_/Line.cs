using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_.join_
{

	/// <summary>
	/// </summary>
	public class Line : Join
	{
		public Line() : base(Environment.NewLine)
		{
		}


		static public Line Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Line>.Instance;
			}
		}

	}
}
