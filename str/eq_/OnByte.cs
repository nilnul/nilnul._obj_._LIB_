using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.eq_
{
	/// <summary>
	/// over/of the type Byte
	/// </summary>
	public class OvByte:Eq1<byte>
	{

		static public OvByte Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OvByte>.Instance;
			}
		}

	}
}
