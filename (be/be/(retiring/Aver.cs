using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{

	public class Aver<T>
		:nilnul.obj._aver_.AverI<T>
	{
		private BeI<T> _be;

		public BeI<T> be
		{
			get { return _be; }
			set { _be = value; }
		}


		public Aver(nilnul.obj.BeI<T> be)
		{
			_be = be;
		}

		public void aver(T obj)
		{

			nilnul.obj.aver_.True.Aver( _be.be(obj));
			//throw new NotImplementedException();
		}
	}

	public class Aver<T,TBe> : Aver<T>
		where TBe : BeI<T>, new()
	{
		public Aver( ) : base(SingletonByDefault<TBe>.Instance)
		{
		}


		static public readonly Aver<T,TBe> Singleton = SingletonByDefault<Aver<T,TBe>>.Instance;

	}
}
