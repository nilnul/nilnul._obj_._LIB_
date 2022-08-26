using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp_
{
	public class NulMax<TNulable> :
		nilnul.obj.Box1<IComparer<TNulable>>
		,
		IComparer<TNulable>
		where TNulable:class
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">
		/// comparer of non-nulable
		/// </param>
		public NulMax(IComparer<TNulable> val) : base(val)
		{
		}
		/// <summary>
		/// of comparer of non-nulable
		/// </summary>
		
		public NulMax():this(Comparer<TNulable>.Default)
		{

		}

		/// <summary>
		/// result according to x-y
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(TNulable x, TNulable y)
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
			return boxed.Compare(x, y);

			//throw new NotImplementedException();
		}


		static public NulMax<TNulable> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<NulMax<TNulable>>.Instance;
			}
		}

	}
}
