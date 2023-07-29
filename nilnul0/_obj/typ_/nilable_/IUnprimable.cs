using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.nilable_
{
	/// <summary>
	/// the type has a parameter constructor, and it creates an instance that is context-free (that is, it does not be affected by settings).
	/// eg:
	///		nilnul.bit.op_.And
	///		nilnul.bit.stream_.slider_.Alt (0,1,0,1,0,1)
	///		<see cref="unprimable_.ISingulable"/>
	/// counter eg:
	///		Random is not defautable. Even it has parameterless ctor, it initializes using time as parameter.
	///		EmailSmtpClient is not defautable, as it initializes using user-given settings/configuration.
	///	
	/// </summary>
	/// <remarks>
	/// a type can have both parameterless ctor, and parameterized ctor. such type can be further divided by peeling off some responsibility into a type of only parameterless ctor, and a type of parameterized ctor.
	/// a type of only parameterless ctor, and if the type disregard configuration/settings, then the instances created by the type are all the same initially (even if they may get differently lately).
	/// alias:
	///		cfgless
	///		Unconfigurable
	///		Unsettable
	///		Unprimable
	///			you can not prime the student by letting him run a step earlier by means of money/previlege/etc
	/// </remarks>
	public interface IUnprimable:INilable
	{
	}
}
