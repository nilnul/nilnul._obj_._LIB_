using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.monotone_
{
	public class Gt<TEl>
		:
		MonotoneA<TEl>
	//,
	//MonotoneI<TEl>
	{
		public Gt(in obj.co.str.every.be_.comp_.Gt<TEl> val) : base(val)
		{
		}

		public Gt(obj.co.str.every.be_.comp_.Gt<TEl> x) : base(x)
		{
		}

		public Gt(in IComparer<TEl> val) : this(
			//in
			new obj.co.str.every.be_.comp_.Gt<TEl>(in val))
		{
		}

		public Gt(IComparer<TEl> val) : this(in val)
		{
		}

		public Gt() : this(
			System.Collections.Generic.Comparer<TEl>.Default
		)
		{
		}


		static public Gt<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Gt<TEl>>.Unison;
			}
		}



	}
}
