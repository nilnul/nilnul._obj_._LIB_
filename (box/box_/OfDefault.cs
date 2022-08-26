using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.box_
{
	public class OfSingleton<T> : nilnul.obj.Box<T>
		where T:new()
	{
		public OfSingleton() : base(nilnul.obj_.Singleton<T>.Instance)
		{
		}
	}
}
