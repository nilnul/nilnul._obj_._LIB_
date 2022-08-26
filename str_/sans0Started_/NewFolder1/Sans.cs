using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	public interface SansI :StrI{ }
	public class Sans<T>:StrI<T>,SansI
	{
	}
}
