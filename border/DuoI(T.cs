using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{
	public interface CoI<T,TBorder,TBorder1>
		where TBorder:BorderI<T>
		where  TBorder1:BorderI<T>
	{
		TBorder lower { get; }
		TBorder1 upper { get; }
	}


	public interface CoI<T, TBorder>
		:CoI<T,TBorder,TBorder>
		where TBorder:BorderI<T>

	{

	}
}
