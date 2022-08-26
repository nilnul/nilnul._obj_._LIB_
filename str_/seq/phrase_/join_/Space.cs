using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_.join_
{

	/// <summary>
	/// </summary>
	public class Space : Join
	{
		public Space() : base( " ")
		{
		}


		static public Space Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Space>.Instance;
			}
		}

	}
}
