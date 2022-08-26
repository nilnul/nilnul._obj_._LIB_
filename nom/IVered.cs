using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nom
{
	/// <summary>
	/// <see cref="obj.IId"/>
	/// </summary>
	public interface IVered
	{
	}
	/// versioning shall be as local as possible.
	/// -) inside the same type, add a method of the same nom, but increment the version.
	/// -) inside the same project add a type of the same nom, but increment the version
	///		<see cref="nilnul._obj.typ.nom.IVered"/>
	/// 
	/// don't forget to mark the previous method as obsolete and add a seealso to the newer one.
	///
	/// This allows us to keep the project's version stable. Note that deps of varied version might break winForm designer.
	/// rather we can increment the pac version without increase the dll's version.
	/// 

}
