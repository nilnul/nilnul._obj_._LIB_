using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started
{

	public interface BeI<out T,in TStr>
		:
		nilnul.obj.BeI1<TStr>

		where TStr:nilnul.obj.str_.Sans0StartedI<T>
	{

	}


	public interface BeI< T>
		:BeI<T, nilnul.obj.str_.Sans0StartedI< T>>
	{

	}



}
