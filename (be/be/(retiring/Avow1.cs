using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	[Obsolete(nameof(Vow<T>))]
	public class Avow1<T>
		:nilnul.obj._avow_.AvowI<T>
	{
		private BeI<T> _be;

		public BeI<T> be
		{
			get { return _be; }
			set { _be = value; }
		}


		public Avow1(nilnul.obj.BeI<T> be)
		{
			_be = be;
		}

		public void avow(T obj)
		{

			nilnul.obj.AssertX.True( _be.be(obj));
			//throw new NotImplementedException();
		}
	}
	[Obsolete(nameof(Vow_beDefault<T,TBe>))]

	public class Avow_beDefault<T,TBe> : Avow1<T>
		where TBe : BeI<T>, new()
	{
		public Avow_beDefault( ) : base(SingletonByDefault<TBe>.Instance)
		{
		}
	}
}
