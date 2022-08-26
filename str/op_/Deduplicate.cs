using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.op_
{
	public class Deduplicate<T> :
		nilnul.objs._eq.ElEq<T>
		,
		OpI<T>
	{
		public Deduplicate(IEqualityComparer<T> val) : base(val)
		{
		}

		private nilnul.objs.Disown<T> _disown;
		public nilnul.objs.Disown<T> disown
		{
			get { return _disown; }
			set { _disown = value; }
		}

		public ObjsI2<T> op(ObjsI2<T> arg)
		{
			return new Objs<T>(
				_op(arg.toArr()).ToArray()
			);

			throw new NotImplementedException();
		}

		public IEnumerable<T> _op(IEnumerable<T> objs)
		{

			var picked = new List<T>();

			foreach (var item in objs)
			{
				if (disown.disown(picked, item))
				{
					picked.Add(item);
				}
			}
			return picked;

		}


	}
	public class Deduplicate<T, TEq> : Deduplicate<T>
			where TEq : IEqualityComparer<T>, new()
	{
		public Deduplicate() : base(nilnul.obj.SingletonByDefault<TEq>.Instance)
		{
		}

		static public Deduplicate<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Deduplicate<T,TEq>>.Instance;
			}
		}

	}
}
