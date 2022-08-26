using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.lex_._byt.bind_.name_
{
	public sealed class ToTypeOnly : SerializationBinder
	{
		

		public override Type BindToType(string assemblyName, string typeName)
		{
			return Type.GetType(
				nilnul._obj._typ._NameX.OfTypeAndAssembly(typeName,assemblyName)
			);

		}


		static public ToTypeOnly Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ToTypeOnly>.Instance;
			}
		}

	}
}
