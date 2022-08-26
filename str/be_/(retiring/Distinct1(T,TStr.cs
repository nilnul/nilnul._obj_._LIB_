using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	[Obsolete()]
	public class Distinct1<T>
		: 
		nilnul.obj.str.BeI1<T>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct1(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}

		public bool be(nilnul.obj.StrI1<T> obj)
		{
			if (obj is nilnul.obj.str_.EnumableI2<T>)
			{
				return new nilnul.obj.str_.enumable.be_.Distinct<T>(_eq).be((nilnul.obj.str_.EnumableI2<T>)obj);
			}
			return new nilnul.obj.str_.enumable.be_.Distinct<T>(_eq).be(obj.toArr());
		}
	}

	public class Distinct1<T,  TEq>
		: 
		Distinct1<T >
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct1(IEqualityComparer<T> eq) : base(eq)
		{
		}
	}

	public class Distinct_str<T,   TStr>
		: 
		
		nilnul.obj.BeI1<TStr>

		where TStr: nilnul.obj.StrI1<T>
	{
		private Distinct1<T> _ofStr;

		public Distinct1<T> ofStr
		{
			get { return _ofStr; }
			set { _ofStr = value; }
		}

		public Distinct_str(IEqualityComparer<T> eq)
		{
			_ofStr = new Distinct1<T>(eq);
		}

		public bool be(TStr obj)
		{
			return _ofStr.be(obj);
		}

		
	}

	public class Distinct1<T,  TEq, TStr>
		: 
		Distinct_str<T,TStr >
		,
		nilnul.obj.str.BeI1<T,TStr>

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.StrI1<T>
	{
		public Distinct1(IEqualityComparer<T> eq) : base(eq)
		{
		}

		
	}



}
