using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{
	/// <summary>
	/// a strict partial order.
	/// This is also partial preord, or a cannonical form of sub proper: left is smaller than right. 
	/// different from le, lt requires eq to define Ord
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface LtI<T>:ReI<T>
	{
	}
}
