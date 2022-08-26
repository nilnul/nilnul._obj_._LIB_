using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.box_
{
	public class OfNew<T> : nilnul.obj.Box<T>
		where T:new()
	{
		public OfNew() : base(new T())
		{
		}
	}
}
