using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	 public class Contain<T,TStr>
		:nilnul.obj.str.BeI<T,TStr>
		where TStr:nilnul.obj.StrI<T>
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

		public bool be(TStr obj)
		{

			if (obj is SansI)
			{
				return false;
			}
			var started = obj as str_.StartedI<T,TStr>;

			return eq.Equals(started.head, element) || be( obj);

			//throw new NotImplementedException();
		}
	}
}
