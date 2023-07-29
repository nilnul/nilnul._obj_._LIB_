using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.monotone_
{
	public class Le<TEl>
		:
		MonotoneA<TEl>
	{
		public Le(in obj.co.str.every.be_.comp_.Le<TEl> val) : base(val)
		{
		}

		public Le(obj.co.str.every.be_.comp_.Le<TEl> x) : base(x)
		{
		}

		public Le(in IComparer<TEl> val) : this(
			//in
			new obj.co.str.every.be_.comp_.Le<TEl>(in val))
		{
		}

		public Le(IComparer<TEl> val) : this(in val)
		{
		}
		public Le() : this(
			System.Collections.Generic.Comparer<TEl>.Default
		)
		{
		}


		static public Le<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Le<TEl>>.Unison;
			}
		}


	}
}
