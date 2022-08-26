using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_
{
	public class NulMaxOvStruc<TStruc> :
		nilnul.obj.Box1<IComparer<TStruc>>
		,
		IComparer<TStruc?>
		where TStruc:struct
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// comparer of non-nulable
		/// </param>
		public NulMaxOvStruc(IComparer<TStruc> val) : base(val)
		{
		}
		/// <summary>
		/// of comparer of non-nulable
		/// </summary>
		
		public NulMaxOvStruc():this(Comparer<TStruc>.Default)
		{

		}

		/// <summary>
		/// result according to x-y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(TStruc? x, TStruc? y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return 0;
				}
				return 1;
			}
			if (y is null)
			{
				return -1;
			}
			return boxed.Compare(x.Value, y.Value);

			//throw new NotImplementedException();
		}


		static public NulMaxOvStruc<TStruc> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMaxOvStruc<TStruc>>.Instance;
			}
		}

	}
}
