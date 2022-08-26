using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{

	public class Anto<T>
	:

	BeI<T>
		,
		BeI1<T>


	{
		private nilnul.obj.BeI<T> _be;

		public nilnul.obj.BeI<T> beField
		{
			get { return _be; }
			set { _be = value; }
		}


		public Anto(nilnul.obj.BeI<T> be)
		{
			_be = be;

		}
		public bool be(T obj)
		{
			return !_be.be(obj);

			//throw new NotImplementedException();
		}
	}

	public class Anto<T, TBe> :

		nilnul.obj.be.Anto<T>

		where TBe : nilnul.obj.BeI<T>, new()
	{
		public Anto() : base(SingletonByDefault<TBe>.Instance)
		{

		}


		static public Anto<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Anto<T,TBe>>.Instance;
			}
		}

		

	}
}
