using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_.join_
{

	/// <summary>
	/// </summary>
	public class Empty : Join
	{
		public Empty() : base("")
		{
		}


		static public Empty Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Empty>.Instance;
			}
		}

	}
}
