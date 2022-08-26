﻿namespace nilnul.obj._id._nom.term.posteriorsed
{

	/// <summary>
	/// apply  <see cref="_adfixed.adfix_.prefix_"/> for onece
	/// eg:
	///		Abc
	///		IAbc
	///		
	///		IIAbc
	///			it seems useless.
	///		
	///		
	///		Abc_
	///		
	///		Abc__
	///		IAbc_
	///		IAbc__
	///			it seems useless.
	///		
	/// </summary>
	/// <remarks>
	/// whether this is valid or need further constraint is upto the user, eg: <see cref="_obj._typ._ns.seg_"/>
	/// </remarks>
	class IPrefixed
	{

	}

	/// <summary>
	/// apply <see cref="IPrefixed"/> 0, 1, 2, or more times.
	/// </summary>
	class IPrefixesed
		:extsed.Adfixsed
	{

	}
}

