using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable
{

	[Obsolete(nameof(nulable.Eq<T,TEq>))]
	public class Eq<T, TEq> : Eq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Eq() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public Eq<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<T,TEq>>.Instance;
			}
		}
	}
}
