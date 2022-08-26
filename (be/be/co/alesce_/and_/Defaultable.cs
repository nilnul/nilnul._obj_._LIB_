using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.co.alesce_.and_
{
	/// <summary>
	/// </summary>
	public class Defaulted<TObj,TBe,TBe1> :
		And<TObj>
		where TBe: nilnul.obj.BeI1<TObj>,new()
		where TBe1: nilnul.obj.BeI1<TObj>,new()
	{


		public Defaulted() : base( nilnul.obj_.Singleton<TBe>.Instance, nilnul.obj_.Singleton<TBe1>.Instance)
		{
		}


		static public Defaulted<TObj,TBe,TBe1> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaulted<TObj,TBe,TBe1>>.Instance;
			}
		}


	}

	
}
