using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp.re_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TNulable"></typeparam>
	/// <typeparam name="TCompOfNulable"></typeparam>
	/// <remarks>
	/// comp is deliberately named to innuendo:
	///		1) comparere
	///		2) complete. in regards to the fact that: a comparer itself doesn't make the releation "total order"; it only make it "complete" (in other words total). Note: a total order is not only compelte, it 's also order(reflexive, transitive, and antisymmetric)
	/// </remarks>
	public  class CompDefault<TNulable, TCompOfNulable>
		:
		Re<TNulable>

		where TCompOfNulable:IComparer<TNulable>,new()

	{

		public CompDefault( )
			:base(
				nilnul.obj_.Singleton<TCompOfNulable>.Instance	 
			)
		{

		}


		static public CompDefault<TNulable, TCompOfNulable> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CompDefault<TNulable, TCompOfNulable>>.Instance;
			}
		}



	}

	
}
