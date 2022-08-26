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
	public interface Fold_ofEl<T>
	{
		T fold(nilnul.obj.str_.SeqI1<T> x);
	}
}