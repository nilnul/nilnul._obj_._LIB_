using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cascader_
{
	public class OpDefault<T, TOp>
		: Cascader<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault() : base(nilnul.obj_.Singleton<TOp>.Instance)
		{
		}


		static public OpDefault<T, TOp> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OpDefault<T, TOp>>.Instance;
			}
		}

	}
}
