using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow._ed_
{
	[Obsolete()]

	public abstract class VowedA<T>
		: _ed_.VowedI<T>
	{
		
		public VowedA( T val)
		{
			_ed = val;


		}

		private T _ed;

		[Obsolete(nameof(ed))]
		public T vowed
		{
			get
			{
				return _ed;
				//throw new NotImplementedException();
			}
		}

		public T ed {
			get {
				return _ed;
			}
		}

		public override string ToString()
		{
			return _ed.ToString();
		}

		static public implicit operator T(VowedA<T> ed) { return ed.ed; }
	}
}
