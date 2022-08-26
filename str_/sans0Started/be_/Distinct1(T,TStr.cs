using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started.be_
{
	public class Distinct<T,   TStr>
		: 
		
		nilnul.obj.BeI1<TStr>

		where TStr: nilnul.obj.StrI2<T>,
		obj.str_.Sans0StartedI<T>
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

		public bool be(nilnul.obj.str_.sans0Started_.StartedI<T, TStr> obj)
		{
			return be(
				obj.body
				)
				&&

				nilnul.obj.str_.sans0Started.be_.contain._AntoX.NotContain(obj.body, obj.head, _eq);
		}

		public bool be(TStr obj)
		{
			return (obj is nilnul.obj.str_.sans0Started_._sans_.BlankI)
				||
				be(
					(nilnul.obj.str_.sans0Started_.StartedI<T, TStr>)obj
				);

		}


	}
	public class Distinct<T>
		: 
		nilnul.obj.str_.sans0Started.BeI<T>
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

		public bool be(nilnul.obj.str_.sans0Started_.StartedI<T, str_.Sans0StartedI<T>> obj) {
			return  be(
				obj.body
				)
				&&

				nilnul.obj.str_.sans0Started.be_.contain._AntoX.NotContain(obj.body, obj.head, _eq);
		}

		public bool be(nilnul.obj.str_.Sans0StartedI<T> obj)
		{
			return (obj is nilnul.obj.str_.sans0Started_._sans_.BlankI)
				||
				be(
					(nilnul.obj.str_.sans0Started_.StartedI<T, str_.Sans0StartedI<T>>)obj
				);


			
		}
	}

	





}
