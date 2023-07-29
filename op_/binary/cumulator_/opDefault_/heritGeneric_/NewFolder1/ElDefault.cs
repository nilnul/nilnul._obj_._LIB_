using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_.opDefault_.heritGeneric
{

	
	public class ElDefault<T, TOp>
		:
		HeritGeneric<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where T : new()
	{

		public ElDefault() : base(nilnul.obj_.Singleton<T>.Instance)
		{

		}

		static public ElDefault<T, TOp> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ElDefault<T, TOp>>.Instance;
			}
		}

	}

	




}
