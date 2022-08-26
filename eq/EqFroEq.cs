using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	/// <summary>
	/// the T1 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="T1"></typeparam>
	public class EqFroEq<T,T1>:IEqualityComparer<T1>
	{
		private IEqualityComparer<T> _originalEq;

		public IEqualityComparer<T> originalEq
		{
			get { return _originalEq; }
			set { _originalEq = value; }
		}

		private System.Func<T1, T> _mapping;

		public Func<T1,T> mapping
		{
			get { return _mapping; }
			set { _mapping = value; }
		}

		public EqFroEq(IEqualityComparer<T> originalEq, System.Func<T1, T> mapping)
		{
			_originalEq = originalEq;
			_mapping = mapping;
		}

		public bool Equals(T1 x, T1 y)
		{
			return _originalEq.Equals( _mapping(x),_mapping(y));

			throw new NotImplementedException();
		}

		public int GetHashCode(T1 obj)
		{
			return _originalEq.GetHashCode(  _mapping(obj) );

			///throw new NotImplementedException();
		}
	}

	public class EqFroEq<T, TEq, T1> : EqFroEq<T, T1>
		where TEq : IEqualityComparer<T>, new()
	{
		public EqFroEq(System.Func<T1, T> mapping) : base(SingletonByDefault<TEq>.Instance, mapping)
		{
		}
	}
}
