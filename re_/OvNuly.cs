using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">nulable. default to class?. But it can also accodmodate Nullable </typeparam>
	public interface  OvNulyI<T>
		:ReI<T>
		
	{
	}


	public interface NulyOvStructI<T>
		:OvNulyI<T?>
		where T: struct
	{ }


}
