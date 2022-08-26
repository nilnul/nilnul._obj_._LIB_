using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// succession: a str that is distinct
	/// </summary>
	/// 
	[Obsolete(nameof(SortieI))]
	public interface SucI
	{

	}
	[Obsolete(nameof(SortieI<T>))]

	public interface SucI<T> : SucI, nilnul.ObjsI2<T>, _suc_.EqI<T> {

	}
}
