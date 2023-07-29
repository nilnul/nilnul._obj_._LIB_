using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public interface ITernary:obj.IOp
		,
		obj.of_.IOfTriple

	{
	}

	public interface ITernary<T>
		:
		obj.of_.vec_.IOfTriple<T,T>
		,
		ITernary

	{
	}

	public interface TernaryI<T>
		:
		obj.of_.vec_.OfTripleI<T,T>

	{
		//T op(T x, T y, T z);
	}



}
