#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_
{
	/// <summary>
	/// extending the type to nulable.
	/// </summary>
	/// <typeparam name="T">
	/// expected: reference
	///		or
	///		nullable{struct}
	/// </typeparam>
	public interface OvNulyI<T>
		:
		
		nilnul.obj.op_.binary_.CommutableI<T>
		//where T: class , Nullable
	{
	


		
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	/// 
	/// if it's struct, the argument shall be Nullable{S}
	/// </typeparam>
	public interface NulyOvStructI<T>
		:
		OvNulyI<T?>
		//,
		//nilnul.obj.op_.binary_.CommutableI<T?>
		where T: struct
	{
	


		
	}



}
