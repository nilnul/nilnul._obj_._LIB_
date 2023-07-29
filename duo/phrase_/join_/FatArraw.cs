using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_.join_
{
	public class FatArraw<T> : Join<T>
	{
		public FatArraw() : base("=>")
		{
		}

		static public FatArraw<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<FatArraw<T>>.Unison;
			}
		}

	}
}
