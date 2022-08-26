using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.opt
{
	public class Eq1<T,TOpt> : IEqualityComparer<TOpt>
		where TOpt: nilnul.obj.Opt1<T>
	{
		private nilnul.obj.opt_.one.Eq<T> _oneEq;

		public nilnul.obj.opt_.one.Eq<T> oneEq
		{
			get { return _oneEq; }
			set { _oneEq = value; }
		}

		public Eq1(IEqualityComparer<T> valEq)
		{
			_oneEq = new obj.opt_.one.Eq<T>(valEq);
		}
		public bool Equals(TOpt x, TOpt y)
		{
			if (x.val is nilnul.obj.opt_.One<T>)
			{
				if ( y.val is nilnul.obj.opt_.One<T>)
				{
					return _oneEq.Equals(x as nilnul.obj.opt_.One<T>, y as nilnul.obj.opt_.One<T>);

				}
				return false;

			}
			if (y.val is nilnul.obj.opt_.NonI)
			{
				return true;

			}
			return false;

			//throw new NotImplementedException();
		}

		public int GetHashCode(TOpt obj)
		{

			if (obj.val is nilnul.obj.opt_.One<T>)
			{
				
					return _oneEq.GetHashCode(obj as nilnul.obj.opt_.One<T>);
			}
			return 0;
			//throw new NotImplementedException();
		}
	}
}
