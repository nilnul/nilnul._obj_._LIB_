using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.enumable.be_
{
	/// <summary>
	/// empty set is considered a subset of an equiv class.
	/// Sometimes empty set is not considered equiv class; in that case , use nilnul.objs.slated.
	/// </summary>
	public class EquivSub<T >
		: nilnul.obj.BeI1<IEnumerable<T>>
 	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}


		public EquivSub(IEqualityComparer<T> elementEq)
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
	public class EquivSub<T, TEq>
		:
		EquivSub<T>
		
		where TEq : IEqualityComparer<T>,new()
	{
		

		public EquivSub( ):base(nilnul._obj.Singleton<TEq>.Instance)
		{
			
		}


		static public EquivSub<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<EquivSub<T,TEq>>.Instance;
			}
		}

	}
}
