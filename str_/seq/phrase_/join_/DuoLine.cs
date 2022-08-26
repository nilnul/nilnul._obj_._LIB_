using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_.join_
{

	/// <summary>
	/// </summary>
	public class DuoLine : Join
	{
		public DuoLine() : base( Environment.NewLine + Environment.NewLine)
		{
		}


		static public DuoLine Singleton
		{
			get
			{
				return nilnul._obj.Singleton<DuoLine>.Instance;
			}
		}

	}
}
