using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{
	[Obsolete()]

	public class Duo<T, TBorder>
		: nilnul.obj.Adapter< nilnul.obj.Duo<TBorder>>

		where TBorder:nilnul.obj.BorderI<T>
	{

		

		public TBorder left
		{
			get { return _val.Item1; }
		}

		public TBorder right
		{
			get { return _val.Item2; }
		}

		public Duo(TBorder item1, TBorder item2) : base(new Duo<TBorder>( item1, item2))
		{
			

		}
	}
}
