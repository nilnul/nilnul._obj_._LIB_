using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.op_.binary_
{
	public class Or<T> : nilnul.obj.be.op_.BinaryI<T>
		,
		_unitable.UnitI<T>
		,_nilable.NilI<T>
	{

		public BeI1<T> unit
		{
			get
			{
				return nilnul.obj.be_.False<T>.Singleton;

				//throw new NotImplementedException();
			}
		}

		public BeI1<T> op(BeI1<T> arg, BeI1<T> arg1)
		{
			return new _or.Ret<T>(arg, arg1);

			//throw new NotImplementedException();
		}

		static public Or<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Or<T>>.Instance;
			}
		}

		public BeI1<T> nil => nilnul.obj.be_.True<T>.Singleton;
	}
}
