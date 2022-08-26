using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{
	[Obsolete()]
	public class Ed<T, TOp>
		: ProcessedA<T>, 
		_ed_.EdI<T>
		where TOp : nilnul.obj.OpI<T>
	{

		public Ed(T input, TOp op):base(op.eval(input))
		{

		}
		static public implicit operator T(Ed<T, TOp> ed) {
			return ed.processed;
		}
		 
	}

	[Obsolete()]

	public class Ed_opDefaultable<T, TOp>
		: Ed<T, TOp>
		where TOp : nilnul.obj.OpI<T>, new()

	{
		public Ed_opDefaultable(T input) : base(input, SingletonByDefault<TOp>.Instance)
		{
		}
	}
	[Obsolete()]

	public class Ed1<T> : Ed<T, nilnul.obj.OpI<T>>
	{
		public Ed1(T input, obj.OpI<T> op) : base(input, op)
		{
		}


	}
	 
}
