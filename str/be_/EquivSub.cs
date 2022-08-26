using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	/// <summary>
	/// empty set is considered a subset of an equiv class.
	/// Sometimes empty set is not considered equiv class; in that case , use nilnul.objs.slated.
	/// </summary>
	public class Equiv<T >
		: nilnul.obj.BeI1<IEnumerable<T>>
 	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}


		public Equiv(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;
		}

		private bool _be_ofStarted(IEnumerable<T> obj) {
				var skipped = obj.Skip(1);

				if (skipped.Any())
				{
					return _elementEq.Equals(obj.First(), skipped.First()) && be(skipped);
				}
				return true;

		}
		public bool be(IEnumerable<T> obj)
		{

			if (obj.Any())
			{
				return _be_ofStarted(obj);

			}

			return true;

			//throw new NotImplementedException();
		}
	}
	public class Equiv<T, TEq>
		:
		Equiv<T>
		,
		nilnul.obj.BeI<IEnumerable<T>>
		where TEq : IEqualityComparer<T>,new()
	{
		

		public Equiv( ):base(SingletonByDefault<TEq>.Instance)
		{
			
		}
	}
}
