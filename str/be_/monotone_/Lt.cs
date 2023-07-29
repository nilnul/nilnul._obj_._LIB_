using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.monotone_
{
	public class Lt<TEl>
		:
		MonotoneA<TEl>
	{
		public Lt(in obj.co.str.every.be_.comp_.Lt<TEl> val) : base(val)
		{
		}

		public Lt(obj.co.str.every.be_.comp_.Lt<TEl> x) : base(x)
		{
		}


		public Lt(in IComparer<TEl> val) : this(
			//in
			new obj.co.str.every.be_.comp_.Lt<TEl>(in val))
		{
		}

		public Lt(IComparer<TEl> val) : this(in val)
		{
		}

		public Lt():this(
			System.Collections.Generic.Comparer<TEl>.Default
		)
		{
		}


		static public Lt<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Lt<TEl>>.Unison;
			}
		}


	}
}
