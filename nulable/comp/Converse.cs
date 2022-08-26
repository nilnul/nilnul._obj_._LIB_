using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.comp
{
	/// <summary>
	/// comparer defined a relation that is total, linear order.
	/// Converse of such relation means 
	/// </summary>
	public class Converse<TNulable> :
		nilnul.obj.Box1<IComparer<TNulable>>
		,
		IComparer<TNulable>
	{
		/// <summary>
		/// comparer of nulable
		/// </summary>
		/// <param name="val"></param>
		public Converse(IComparer<TNulable> val) : base(val)
		{
		}

		/// <summary>
		/// the default must be nulable.Comparer
		/// </summary>
		public Converse():base(
			Comparer<TNulable>.Default
		)
		{

		}

		/// <summary>
		/// converse is same as negative as long as the comparer is defined to be a linear order
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(TNulable x, TNulable y)
		{
			return boxed.Compare(y,x);
		}

		static public Converse<TNulable> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Converse<TNulable>>.Instance;
			}
		}

	}
}
