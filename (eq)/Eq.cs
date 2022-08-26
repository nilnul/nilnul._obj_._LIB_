using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// default eq of obj. This is defaultable.
	/// </summary>
	public class Eq3 :
		EqualityComparer<object>
		,
		IEq
		,
		EqI<object>

	{
		public override bool Equals(object x, object y)
		{
			return EqualityComparer<object>.Default.Equals(x,y);
		}

		public override int GetHashCode(object obj)
		{
			return EqualityComparer<object>.Default.GetHashCode(obj);
		}


		static public Eq3 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq3>.Instance;
			}
		}

	}


}
