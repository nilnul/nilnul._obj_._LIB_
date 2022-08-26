using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be_.le.vow.ed
{
	public class LowerUpper<T>
		: nilnul.obj.Box<Ed<T>>
	{
		public LowerUpper(Ed<T> val) : base(val)
		{

		}

		public T lower { get {
				return boxed.ed.Item1;
			} }

		public T upper { get {
				return boxed.ed.Item2;
			} }

	}
}
