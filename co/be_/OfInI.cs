using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.be_
{
	public interface OfInI<T,T1>
		:
		nilnul.obj.BeI_ofIn< (T,T1)>
	{
	}
	public abstract class OfInA<T,T1>
		:
		obj.BeA_ofIn<(T,T1)>
		,
		OfInI<T,T1>
	{

	}

	public interface OfInI<T> : OfInI<T, T> {

	}

	public abstract class OfInA<T>
		:
		obj.BeA_ofIn<(T,T)>
		,
		OfInI<T>
	{

	}


}
