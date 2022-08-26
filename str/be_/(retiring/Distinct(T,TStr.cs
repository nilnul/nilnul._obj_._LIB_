using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	[Obsolete()]
	public class Distinct<T, TStr>
		: nilnul.obj.str.BeI<T, TStr>
		
		where TStr : nilnul.obj.StrI<T>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}

		public bool be(TStr obj)
		{
			if (obj is str_.SansI)
			{
				return true;
			}
			var asStarted = obj as nilnul.obj.str_.StartedI<T,TStr>;

			return be(asStarted.tail) && new be_.Contain<T,TStr>(_eq,asStarted.head).be(asStarted.tail);
			;
		}
	}

	public class Distinct<T, TStr, TEq>
		: Distinct<T, TStr>
		where TStr : nilnul.obj.StrI<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct(IEqualityComparer<T> eq) : base(eq)
		{
		}
	}


}
