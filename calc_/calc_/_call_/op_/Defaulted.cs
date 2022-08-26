using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.op._call_.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// <remarks>
	///	 abstract makes it impossible to create a singleton.
	/// </remarks>
	public abstract  class Defaulted<TOp>
		:_call_.OpA<TOp>
		where TOp:new()

	{
		
		public Defaulted():base(nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}
}
