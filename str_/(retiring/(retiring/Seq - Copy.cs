using nilnul.obj.seq.be_.finite.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{

	public class Seq<TEle> : nilnul.obj.seq_.GetEnumeratorA<TEle>, nilnul.obj.str_.SeqI<TEle>, nilnul.obj.str_.SeqI1<TEle>
	{
		private IEnumerable<TEle> _boxed;

		public IEnumerable<TEle> boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public Ee_beDyna<TEle> seq => new Ee_beDyna<TEle>(_boxed, new obj.seq.be_.Finite<TEle>()  );

		public Seq(IEnumerable<TEle> boxed)
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
		}
	}


}
