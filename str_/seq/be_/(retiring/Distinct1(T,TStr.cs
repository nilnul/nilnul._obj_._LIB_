using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable.be_
{
	[Obsolete(nameof(nilnul.obj.str_.seq.be_.Distinct1<T>))]
	public class Distinct<T>
		: 
		nilnul.obj.str_.enumable.BeI<T>
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
				
				contain._AntoX._NotContain( tail,  obj.First(), _eq );
			;
		}


		public bool be(EnumableI2<T> obj)
		{

			return be((IEnumerable<T>)obj);
			;
		}

	}

	

	public class Distinct<T,  TEq>
		: Distinct<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public Distinct<T,  TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Distinct<T,  TEq>>.Instance;
			}
		}

	}


}
