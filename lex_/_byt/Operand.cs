using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.lex_._byt
{
	/// It needs an explicit okay that it is safe to do this. This cannot be a formal okay when you write the code to de/serialize the object, that would be easy but it in practice you don't know enough about the class since you did not write it. The class author needs to do this, he does so by giving it the [Serializable] attribute.
	/// 
	///stackoverflow.com/questions/34976027/why-classes-not-marked-with-serializable-cannot-be-serialized-using-binaryformat
	///Hans Passant
	/// <summary>
	/// 
	/// </summary>
	class Operand
	{
		/*
		either because of security concerns or because field values depend on runtime state too much. Note how security is an issue since an attacker could manipulate the serialized data and get your object into an inconsistent state, state that is exploitable. Say an IsAdministrator property. A good example of critical runtime state is the Control.Handle property, it can never have the same value when you deserialize. 
		 */
	}
	/*
	 [Serializable]
public class ObjectTwo : MyObject
{
    public int num;

    public ObjectTwo()
      : base()
    {
    }

    protected ObjectTwo(SerializationInfo si, StreamingContext context)
      : base(si, context)
    {
        num = si.GetInt32("num");
    }

    public override void GetObjectData(SerializationInfo si, StreamingContext context)
    {
        base.GetObjectData(si,context);
        si.AddValue("num", num);
    }
}
	 */
}
