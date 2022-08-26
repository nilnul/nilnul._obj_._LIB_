using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq._fold_
{
	/// <summary>
	/// convert a str to an element
	/// </summary>
	/// 
	public interface Fold_ofEl1<T>
	{
		T fold(nilnul.obj.str_.SeqI2<T> x);
	}

	public interface OvSeq<TEl> {
		TEl fold(IEnumerable<TEl> x);

	}
}