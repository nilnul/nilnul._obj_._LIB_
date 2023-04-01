namespace nilnul.obj._id._nom.term.postiorsed
{
	/// <summary>
	/// apply <see cref="IPrefixed"/> 0, 1, 2, or more times.
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
	class IPrefixesed
		:extersed.IAdfixsed
	{

	}
}

