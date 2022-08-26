using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete(nameof(Seq<TEle>))]
	public class Enumable<TEle> : nilnul.obj.seq_._enumable_.GetEnumeratorA<TEle>, nilnul.obj.str_.EnumableI1<TEle>

	{
		private IEnumerable<TEle> _boxed;

		public IEnumerable<TEle> boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public Enumable(IEnumerable<TEle> boxed)
		{
			_boxed = boxed;
		}
		public override IEnumerator<TEle> GetEnumerator()
		{
			return _boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		public TEle[] toArr()
		{
			return _boxed.ToArray();
			throw new NotImplementedException();
		}
	}


}
