using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.collection.op_.unary_._complement
{
	public class Ret<T,TCollection>
		: nilnul.obj.call_._unary.ArgA<TCollection>
		,
		nilnul.obj._collection_.ContainI<T>

		where TCollection: nilnul.obj._collection_.ContainI<T>
	{
		public Ret(TCollection arg) : base(arg)
		{
		}

		public bool contain(T element)
		{
			return !arg.contain(element) ;
		}
	}
}
