using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_
{


	public class BeDefaulted4<T, TBe> : 
		Vow4<T>

		where TBe : nilnul.obj.BeI1<T>,new()

	{
		public BeDefaulted4(  ) : base( nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefaulted4<T, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaulted4<T, TBe>>.Instance;
			}
		}


	}

	





}