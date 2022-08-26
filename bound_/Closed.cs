using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.duo.be_.le.vow;

namespace nilnul.obj.range_
{
	public class Closed<T, TComparer>

		:
		nilnul.obj.duo.be_.le.vow.ed.LowerUpper<T>
		,
		nilnul.obj._collection_.ContainI<T>
		, ClosedI<T>
		where TComparer : IComparer<T>
	{

		public Closed(
			TComparer comparer
			, Duo<T> val


		) : this(
				new comp.Re<T>(comparer)

			,
				val




		)
		{

			_comparer = comparer;

		}

		private Closed(comp.Re<T> re
			, Duo<T> val


		) : this(


					new duo.be_.Le<T>(
						(re)
					)

			,
				val

		)
		{

			_re = re;

		}


		private Closed(duo.be_.Le<T> comparer
			, Duo<T> val


		) : base(

			new Ed<T>(
				val
				,
				new duo.be_.le.Vow<T>(
					comparer
				)
			)

		)
		{

			_le = comparer;

		}


		private duo.be_.Le<T> _le;
		private comp.Re<T> _re;

		private TComparer _comparer;

		public TComparer comparer
		{
			get { return _comparer; }
			//set { _comparer = value; }
		}


		public override string ToString()
		{
			return $"[{lower},{upper}]";
		}


		public bool contain(T element)
		{
			return _re.ge(element, lower) && _re.le(element, upper);
			//throw new NotImplementedException();
		}

		static public Closed<T, TComparer> CreateSingleton(TComparer comp,  Duo<T> x) {
			return new Closed<T, TComparer>(comp, x);
		}
	}
	public class Closed_compDefault<T, TComparer> : Closed<T, TComparer>
		where TComparer : IComparer<T>, new()
	{
		public Closed_compDefault( Duo<T> val) : base(SingletonByDefault<TComparer>.Instance, val)
		{

		}
	}

}
