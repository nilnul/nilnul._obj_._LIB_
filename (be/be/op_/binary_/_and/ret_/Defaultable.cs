using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.op_.binary_._and.ret_
{
	/// <summary>
	/// </summary>
	public class Defaultable<TObj,TBe,TBe1> :
		Ret<TObj>
		where TBe: nilnul.obj.BeI1<TObj>,new()
		where TBe1: nilnul.obj.BeI1<TObj>,new()
	{


		public Defaultable() : base( nilnul.obj_.Singleton<TBe>.Instance, nilnul.obj_.Singleton<TBe1>.Instance)
		{
		}


		static public Defaultable<TObj,TBe,TBe1> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable<TObj,TBe,TBe1>>.Instance;
			}
		}


	}

	
}
