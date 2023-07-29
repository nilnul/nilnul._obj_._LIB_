using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_.join_
{
	public class ThinArraw<T> : Join<T>
	{
		public ThinArraw() : base("->")
		{
		}

		static public ThinArraw<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ThinArraw<T>>.Unison;
			}
		}

	}
}
