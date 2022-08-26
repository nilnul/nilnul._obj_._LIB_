using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp.converse_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TComparer"> must be nulable.Comparer</typeparam>
	public class ComparerDefault<T,TComparer> :
		nilnul.obj.nulable.comp.Converse<T>
		where TComparer:IComparer<T>,new()
	{
		public ComparerDefault() : base(nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}


		static public ComparerDefault<T,TComparer> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault<T,TComparer>>.Instance;
			}
		}



	}
}
