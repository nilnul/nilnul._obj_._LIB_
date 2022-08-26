using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_.finite.vow
{
	public class Ee<T, TFinite>
		: nilnul.obj.seq.vow.Ee<T, finite.Vow<T, TFinite>>
		where TFinite : be_.FiniteI<T>, new()
	{
		public Ee(IEnumerable<T> val) : base(val)
		{
		}
	}

	public class Ee_beDyna<T, TBeFinite>
		: nilnul.obj.seq.vow.Ee_vowDyna<T, finite.Vow_beDynamic<T, TBeFinite>>
		where TBeFinite : be_.FiniteI<T>
	{
		public Ee_beDyna(IEnumerable<T> val, TBeFinite vow) : base(val,new Vow_beDynamic<T, TBeFinite>(vow))
		{
			_be = vow;
		}

		private TBeFinite _be;
		public TBeFinite be { get {
				return _be;
   } }
	}

	public class Ee<T>
		: Ee<T, Finite<T>>
	{
		public Ee(IEnumerable<T> val) : base(val)
		{
		}
	}

	public class Ee_beDyna<T>
		: Ee_beDyna<T, FiniteI<T>>
	{
		public Ee_beDyna(IEnumerable<T> val, FiniteI<T> be) : base(val,be)
		{
		}
	}


}
