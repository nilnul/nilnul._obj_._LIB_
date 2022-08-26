using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.collection.op_.binary_._intersect
{
	public class Ret<T,TCollection>
		: nilnul.obj.call_._binary_.args_.SameTypeA<TCollection>
		,
		nilnul.obj._collection_.ContainI<T>

		where TCollection: nilnul.obj._collection_.ContainI<T>
	{
		public Ret(TCollection arg, TCollection arg1) : base(arg, arg1)
		{
		}

		public bool contain(T element)
		{
			return arg.contain(element) && arg1.contain(element);
		}
	}
}
