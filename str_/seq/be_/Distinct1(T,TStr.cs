using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_
{
	public class Distinct1<T,TStr>
		: 
		nilnul.obj.str_.seq.BeI1<T,TStr>
		where TStr: nilnul.obj.str_.SeqI2<T>
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
		public bool be(IEnumerable<T> obj)
		{
			
			if (nilnul.obj.seq.be_._NoneX.None( obj) )
			{
				return true;
			}

			var tail=nilnul.obj.seq.op_.unary_._TailX.Enumable(obj);


			return be(
				tail)
				&&
				
				nilnul.obj.str_.seq.be_. contain._AntoX._NotContain( tail,  obj.First(), _eq );
			;
		}
		public bool be(SeqI2<T> obj)
		{

			return be((IEnumerable<T>)obj);
			;
		}

		public bool be(TStr obj)
		{
			return be((SeqI2<T> )obj);
		}

		
	}

	
	public class Distinct1<T>
		: 
		nilnul.obj.str_.seq.BeI1<T>
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
		public bool be(IEnumerable<T> obj)
		{
			
			if (nilnul.obj.seq.be_._NoneX.None( obj) )
			{
				return true;
			}

			var tail=nilnul.obj.seq.op_.unary_._TailX.Enumable(obj);


			return be(
				tail)
				&&
				
				nilnul.obj.str_.seq.be_. contain._AntoX._NotContain( tail,  obj.First(), _eq );
			;
		}


		public bool be(SeqI2<T> obj)
		{

			return be((IEnumerable<T>)obj);
			;
		}

		
	}

	public class Distinct_eqDefault<T,  TEq>
		: Distinct1<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct_eqDefault() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public Distinct_eqDefault<T,  TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Distinct_eqDefault<T,  TEq>>.Instance;
			}
		}

	}


}
