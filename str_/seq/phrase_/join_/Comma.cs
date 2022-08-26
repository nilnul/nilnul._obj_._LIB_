using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_.join_
{

	/// <summary>
	/// </summary>
	public class Comma : Join
	{
		public Comma() : base(",")
		{
		}


		static public Comma Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Comma>.Instance;
			}
		}

	}
}
