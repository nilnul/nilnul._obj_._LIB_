using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.be_
{
	[Obsolete()]
	public class FroAnd<T, TBe, TBe1>
		: BeI<T>
		where TBe : BeI<T>
		where TBe1 : BeI<T>

	{
		private TBe1 _be1;

		public TBe1 be1
		{
			get { return _be1; }
			set { _be1 = value; }
		}

		private TBe _be0;

		public TBe be0
		{
			get { return _be0; }
			set { _be0 = value; }
		}


		public FroAnd(TBe be, TBe1 be1)
		{
			_be0 = be;
			_be1 = be1;

		}
		public bool be(T obj)
		{
			return _be0.be(obj) && _be1.be(obj);
			//throw new NotImplementedException();
		}

	}

	[Obsolete()]
	public class FroAnd_defaultable<T, TBe, TBe1>
		: BeI<T>
		where TBe : BeI<T>, new()
		where TBe1 : BeI<T>, new()
	{
		 

		public bool be(T obj)
		{
			return SingletonByDefault<TBe>.Instance.be(obj) && SingletonByDefault<TBe1>.Instance.be(obj); 


			//throw new NotImplementedException();
		}

		public class En :
			nilnul.be.Asserted_assertDefaultDiscarded<T, FroAnd_defaultable<T, TBe, TBe1>>
		{
			public En(T val) : base(val)
			{
			}
		}
	}
}
