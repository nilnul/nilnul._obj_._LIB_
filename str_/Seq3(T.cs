using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	
	public class Seq3<TEle> :
		nilnul.obj._seq_.GetEnumeratorA<TEle>
		//, nilnul.obj.StrI2<TEle>
		, SeqI3<TEle>
	{
		private IEnumerable<TEle> _boxed;

		public IEnumerable<TEle> boxed
		{
			get { return _boxed; }
			set { _boxed = value; }
		}

		public Seq3(IEnumerable<TEle> boxed)
		{
			_boxed = boxed;
		}
		public override IEnumerator<TEle> GetEnumerator()
		{
			return _boxed.GetEnumerator();
			//throw new NotImplementedException();
		}


		
	}





}
