using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.monotone_
{
	public class Eq<TEl>
		:
		MonotoneA<TEl>
	{
		public Eq(in obj.co.str.every.be_.comp_.Eq<TEl> val) : base(val)
		{
		}

		public Eq(obj.co.str.every.be_.comp_.Eq<TEl> x) : base(x)
		{
		}

		public Eq(in IComparer<TEl> val) : this(
			//in
			new obj.co.str.every.be_.comp_.Eq<TEl>(in val ))
		{
		}

		public Eq( IComparer<TEl> val) : this(in val )
		{
		}

		public Eq() : this(
	System.Collections.Generic.Comparer<TEl>.Default
)
		{
		}


		static public Eq<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq<TEl>>.Unison;
			}
		}


	}
}
