using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	public class Distinct3<T>
		:
		nilnul.obj.str.BeI3<T>
	{



		private IEqualityComparer<T> _elEq;

		public IEqualityComparer<T> elEq
		{
			get { return _elEq; }
			set { _elEq = value; }
		}

		public Distinct3(IEqualityComparer<T> eq)
		{
			_elEq = eq;
		}

		public bool be(IEnumerable<T> obj)
		{
			return _DistinctX._IsDistinct_seqAssumeStr(obj,this.elEq);

		}


	}


}
