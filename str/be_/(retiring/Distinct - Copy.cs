using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	[Obsolete()]
	public class Distinct<T> : BeI1<T>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}

		public Distinct(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;

		}
		public bool be(nilnul.ObjsI2<T> obj)
		{
			return _be(obj.toArr());
			//throw new NotImplementedException();
		}

		public bool _be(IEnumerable<T> obj) {

			if (obj.Any())
			{
				var skipped = obj.Skip(1);
				return _DisownX.Disown(skipped, obj.First(), _elementEq) && _be(skipped);
			}
			return true;
		}
	}

}
