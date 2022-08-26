using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	[Obsolete("means not all the same")]
	public class Diff<T> : BeI<T>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}

		public Diff(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;

		}
		public bool be(IEnumerable<T> obj)
		{
			if (obj.Any())
			{
				var skipped = obj.Skip(1);
				return _DisownX.Disown(skipped, obj.First(), _elementEq) && be(skipped);
			}
			return true;
			//throw new NotImplementedException();
		}
	}


	public class Diff<T,TEq>:Diff<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Diff():base(SingletonByDefault<TEq>.Instance)
		{

		}

		static public readonly Diff<T,TEq> Singleton = SingletonByDefault<Diff<T,TEq>>.Instance;

	}
}
