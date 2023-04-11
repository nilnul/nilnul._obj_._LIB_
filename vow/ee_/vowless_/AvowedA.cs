using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.avow._ed_
{
	[Obsolete()]
	public abstract class AvowedA<T>
		: _ed_.EdI<T>
	{
		
		public AvowedA( T val)
		{
			_avowed = val;


		}

		private T _avowed;
		public T avowed
		{
			get
			{
				return _avowed;
				//throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return _avowed.ToString();
		}
	}
}
