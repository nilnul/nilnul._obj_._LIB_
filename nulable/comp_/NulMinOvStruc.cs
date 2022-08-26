using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_
{
	public class NulMinOvStruc<TStruc> :
		nilnul.obj.nulable.comp.Converse<TStruc?>
		
		where TStruc:struct
	{
		/// <summary>
		/// comparer of non-nulable
		/// </summary>
		/// <param name="val"></param>
		public NulMinOvStruc(IComparer<TStruc> val) : base(new NulMaxOvStruc<TStruc>(
			new nilnul.obj.comparer.Converse<TStruc>(
				val
			)
		))
		{
		}
		/// <summary>
		/// comparer of non-nul
		/// </summary>
		public NulMinOvStruc():this(Comparer<TStruc>.Default)
		{

		}


		static public NulMinOvStruc<TStruc> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMinOvStruc<TStruc>>.Instance;
			}
		}

	}
}
