using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_
{
	public class NulMin<TNulable> :
		nilnul.obj.nulable.comp.Converse<TNulable>
		
		where TNulable:class
	{
		/// <summary>
		/// comparer of non-nulable
		/// </summary>
		/// <param name="val"></param>
		public NulMin(IComparer<TNulable> val) : base(new NulMax<TNulable>(
			new nilnul.obj.comparer.Converse<TNulable>(
				val
			)
		))
		{
		}
		/// <summary>
		/// comparer of non-nul
		/// </summary>
		public NulMin():this(Comparer<TNulable>.Default)
		{

		}


		static public NulMin<TNulable> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMin<TNulable>>.Instance;
			}
		}

	}
}
