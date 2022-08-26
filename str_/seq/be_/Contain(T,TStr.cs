using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_
{


	 public class Contain<T>
		:
		nilnul.obj.str_.enumable.BeI<
			T
		>
	{
		

		private IEqualityComparer<T> _eq;
		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		private T _element;
		public T element
		{
			get { return _element; }
			set { _element = value; }
		}


		public Contain(IEqualityComparer<T> eq, T element)
		{
			_eq = eq;
			_element = element;
		}

		public bool be(nilnul.obj.str_.EnumableI2<T> obj)
		{
			return obj.Contains(_element, _eq);


		}

	}

}
