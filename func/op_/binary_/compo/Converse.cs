using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.op_.binary_.compo
{
	/// <summary>
	/// from right to left.
	/// </summary>
	public class Converse:
		nilnul.obj.op_.binary.converse_.OpDefault<obj.FuncI3, CompoLeft2right>
		,
		op_.BinaryI
	{


		static public Converse Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Converse>.Instance;
			}
		}

	}
}
