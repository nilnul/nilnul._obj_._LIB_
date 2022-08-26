using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_.nulMax_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TNulable">nulable type</typeparam>
	/// <typeparam name="TComparerOfNonnul"> comparer of non-nul</typeparam>
	public class ComparerDefault<TNulable,TComparerOfNonnul> :
		nilnul.obj.nulable.comp_.NulMax<TNulable>

		where TComparerOfNonnul:IComparer<TNulable>,new()
		where TNulable:class
	{
		public ComparerDefault() : base(nilnul.obj_.Singleton<TComparerOfNonnul>.Instance)
		{
		}


		static public ComparerDefault<TNulable,TComparerOfNonnul> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault<TNulable,TComparerOfNonnul>>.Instance;
			}
		}



	}
}
