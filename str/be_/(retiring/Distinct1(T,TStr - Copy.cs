using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	[Obsolete()]
	public class Distinct2<T,   TStr>
		: 
		
		nilnul.obj.BeI1<TStr>

		where TStr: nilnul.obj.StrI2<T>
	{
		private Distinct2<T> _ofStr;

		public Distinct2<T> ofStr
		{
			get { return _ofStr; }
			set { _ofStr = value; }
		}

		public Distinct2(IEqualityComparer<T> eq)
		{
			_ofStr = new Distinct2<T>(eq);
		}

		public bool be(TStr obj)
		{
			return _ofStr.be(obj);
		}
	}
	[Obsolete()]
	public class Distinct2<T>
		: 
		nilnul.obj.str.BeI2<T>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct2(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}

		public bool be(nilnul.obj.StrI2<T> obj)
		{
			if (obj is nilnul.obj.str_.SeqI2<T> seq1)
			{
				return new nilnul.obj.str_.seq.be_.Distinct<T>(_eq).be(seq1);
			}
			return new nilnul.obj.str_.sans0Started.be_.Distinct<T>(_eq).be(obj.toSans0Started());
		}
	}

	





}
