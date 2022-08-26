using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	[Obsolete()]
	public class Avow<T>
		:nilnul.obj.AssertI<T>
	{
		private BeI<T> _be;

		public BeI<T> be
		{
			get { return _be; }
			set { _be = value; }
		}


		public Avow(nilnul.obj.BeI<T> be)
		{
			_be = be;
		}

		public void assert(T obj)
		{

			nilnul.obj.AssertX.True( _be.be(obj));
			//throw new NotImplementedException();
		}
	}
}
