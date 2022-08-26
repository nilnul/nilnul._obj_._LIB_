using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.lex_
{
	/*
	 A binary serialized object can only be deserialized if you "know the class", as this is part of the serialized data.

If you do not have that class available in your application you can not deserialize that object using a binary serializer.
You can alwasy read the data as byte[], but parsing that could be very hard.

The class will be determined using the fully qualified name. So the class should have the same name, namespace and assembly.

If this is a strong typed assembly, the version should be the same as well.

	need to implement my own formatter/serialization process to better handle versioning
BinaryFormatter stores multiple copies of the same objects or not? Netizens are argueing.
	
	 
	 */
	/*
	 vs: xml
	-) it also includes the type info, which might be versioned.
	-)BinaryFormatter has very unusual powers, nothing else resembles what it does. It can create an object of your class without running its constructor. And it can give a value to your properties without running the property setter accessor methods. (Hans Passant)
	-)XmlSerializer is safe to use in all cases because it only serializes publicly accessible data, that users of the class could access anyway.

Any of the runtime formatters (including BinaryFormatter) serialize both publicly and privately accessible information, so may give callers access to information that they otherwise shouldn't have. By marking your type as [Serializable] you're effectively saying that you've thought about this and are granting permission to anybody to look at the serialized information about your type. (Greg Beech)




stackoverflow.com/questions/34976027/why-classes-not-marked-with-serializable-cannot-be-serialized-using-binaryformat
	Hans Passant

	stackoverflow.com/questions/1596317/why-does-binary-serialization-require-the-object-to-be-marked-as-serializable

	Greg Beech
	 */
	
	/// as binary serialization is not recommended by MS, we need to use custom one such as <see cref="byt_._Base64X"/>, which stores a txt in the fs.
	 
	interface IByt
	{

	}
}
