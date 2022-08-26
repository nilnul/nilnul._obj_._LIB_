using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.eq_
{


	public class EqFroComponents<T, T1>
		: IEqualityComparer<Tuple<T, T1>>
	{
		private IEqualityComparer<T> _leftEq;

		public IEqualityComparer<T> leftEq
		{
			get { return _leftEq; }
			set { _leftEq = value; }
		}

		private IEqualityComparer<T1> _rightEq;

		public IEqualityComparer<T1> rightEq
		{
			get { return _rightEq; }
			set { _rightEq = value; }
		}

		public EqFroComponents(
			IEqualityComparer<T> leftEq
			,
			IEqualityComparer<T1> rightEq
		)
		{
			_leftEq = leftEq;
			_rightEq = rightEq;
		}



		public bool Equals(Tuple<T, T1> x, Tuple<T, T1> y)
		{
			return leftEq.Equals(x.Item1, y.Item1) && rightEq.Equals(x.Item2, y.Item2);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Tuple<T, T1> obj)
		{
			return leftEq.GetHashCode(obj.Item1)
				&
				rightEq.GetHashCode(obj.Item2);

			//throw new NotImplementedException();
		}
	}


	public class EqFroComponents<T, T1, TDuo>
		: IEqualityComparer<TDuo>
	{

		private IEqualityComparer<T> _leftEq;

		public IEqualityComparer<T> leftEq
		{
			get { return _leftEq; }
			set { _leftEq = value; }
		}

		private IEqualityComparer<T1> _rightEq;

		public IEqualityComparer<T1> rightEq
		{
			get { return _rightEq; }
			set { _rightEq = value; }
		}

		private System.Func<TDuo, Tuple<T, T1>> _mapping;

		public Func<TDuo, Tuple<T, T1>> mapping
		{
			get { return _mapping; }
			set { _mapping = value; }
		}

		public EqFroComponents(
			IEqualityComparer<T> leftEq
			,
			IEqualityComparer<T1> rightEq
			,
			System.Func<TDuo, Tuple<T, T1>> mapping
		)
		{
			_leftEq = leftEq;
			_rightEq = rightEq;
			_mapping = mapping;
		}



		public bool Equals(TDuo a, TDuo b)
		{
			var x = _mapping(a);
			var y = _mapping(b);
			return leftEq.Equals(
				x.Item1,
				y.Item1
			) && rightEq.Equals(x.Item2, y.Item2);
			//throw new NotImplementedException();
		}

		public int GetHashCode(TDuo x)
		{
			var obj = _mapping(x);
			return leftEq.GetHashCode(obj.Item1)
					&
					rightEq.GetHashCode(obj.Item2);

			//throw new NotImplementedException();
		}

	}

	public class EqFroComponents<T, T1, TEq, T1Eq>
		: EqFroComponents<T, T1>
		where TEq : IEqualityComparer<T>, new()
		where T1Eq : IEqualityComparer<T1>, new()
	{
		public EqFroComponents() : base(SingletonByDefault<TEq>.Instance, SingletonByDefault<T1Eq>.Instance)
		{
		}
	}

	

}
