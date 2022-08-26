using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	/// <summary>
	/// applies more after
	/// </summary>
	/// 
	[Obsolete()]
	public class And<T> :
		nilnul.obj._call_.ArgA<nilnul.obj.BeI<T>>
		,
		nilnul.obj.BeI<T>
	{
		private System.Func<T, bool> _additional;

		public Func<T, bool> additional
		{
			get { return _additional; }
			//set { _additional = value; }
		}


		public And(BeI<T> arg, System.Func<T, bool> additional) : base(arg)
		{
		}

		public bool be(T obj)
		{
			return arg.be(obj) && _additional(obj);

			//throw new NotImplementedException();
		}
	}

	[Obsolete()]
	public class Add<T, TBe>
		: And<T>
		where TBe : nilnul.obj.BeI<T>, new()
	{
		public Add(System.Func<T, bool> additional) : base(SingletonByDefault<TBe>.Instance, additional)
		{
		}
	}
}
