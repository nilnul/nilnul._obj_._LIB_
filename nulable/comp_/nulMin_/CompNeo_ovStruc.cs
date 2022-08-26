using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_.nulMin_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TStruc">nulable type</typeparam>
	/// <typeparam name="TComparerOfNonnul"> comparer of non-nul</typeparam>
	public class CompNeo_ovStruc<TStruc,TComparerOfNonnul> :
		nilnul.obj.nulable.comp_.NulMinOvStruc<TStruc>

		where TComparerOfNonnul:IComparer<TStruc>,new()
		where TStruc:struct
	{
		public CompNeo_ovStruc() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComparerOfNonnul>.Instance

			)
		{
		}



		static public CompNeo_ovStruc<TStruc,TComparerOfNonnul> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompNeo_ovStruc<TStruc,TComparerOfNonnul>>.Instance;
			}
		}




	}
}
