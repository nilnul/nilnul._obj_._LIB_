using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.monotone_
{
	public class Ge<TEl>
		:
		MonotoneA<TEl>
	{
		public Ge(in obj.co.str.every.be_.comp_.Ge<TEl> val) : base(val)
		{
		}

		public Ge(obj.co.str.every.be_.comp_.Ge<TEl> x) : base(x)
		{
		}

		public Ge(in IComparer<TEl> val) : this(
			//in
			new obj.co.str.every.be_.comp_.Ge<TEl>(in val ))
		{
		}

		public Ge( IComparer<TEl> val) : this(in val )
		{
		}
		public Ge() : this(
			System.Collections.Generic.Comparer<TEl>.Default
		)
		{
		}


		static public Ge<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Ge<TEl>>.Unison;
			}
		}


	}
}
