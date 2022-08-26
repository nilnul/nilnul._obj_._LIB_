using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.combine_
{
	public class And<T> : nilnul.obj.be.CombineI<T>,nilnul.obj.be._combine_.UnitI<T>
	{
		public static BeI<T> Unit = nilnul.obj.be_.True<T>.Singleton;

		public BeI<T> unit
		{
			get
			{
				return nilnul.obj.be_.True<T>.Singleton;

				//throw new NotImplementedException();
			}
		}

		public BeI<T> eval(BeI<T> arg, BeI<T> arg1)
		{
			return new _and.Ret<T>(arg, arg1);

			//throw new NotImplementedException();
		}
	}
}
