using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.lex_._byt.bind_
{
	public sealed class ByName : SerializationBinder
	{
		/*codeproject.com/Tips/1101106/How-to-Serialize-Across-Assemblies-with-the-Binary
		 The BindToName method is where the assembly-name and type-name are chosen to be written into the serialization. So your type can be de-serialized in another assembly, we are setting the assembly-name to "NA" - if you leave the assembly-name as NULL, the normal assembly name will be written into the stream, which is why we set a non-null value (you could use a zero-length string)
		 */
		public override  void BindToName(Type serializedType, out string? assemblyName, out string? typeName) {
			assemblyName = serializedType.Assembly.FullName;
			typeName = serializedType.FullName;
		}

		/*The BindToType method is essentially the reverse of the BindToName method. This is the method responsible for finding the correct type to de-serialize into.*/
		public override Type BindToType(string assemblyName, string typeName)
		{
			return Type.GetType(
				nilnul._obj._typ._NameX.OfTypeAndAssembly(typeName,assemblyName)
			);

		}


		static public ByName Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByName>.Instance;
			}
		}

	}
}
