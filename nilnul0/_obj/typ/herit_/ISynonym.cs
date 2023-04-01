namespace nilnul._obj.typ.herit_
{
	/// <summary>
	/// inherit a higher tier interface such as to inherit not only the directly chain of inheritanche and also merge other chain of inheritanc;
	/// eg:
	///		nilnul.rel_.net_.dwelted_.acyclic_.Connected  :  nilnul.rel_.net_.Connected
	///		note: the local name is the same, as is distinct from <see cref="nilnul._obj.typ.identy.of_.unary_.IPromote"/>
	///		also note: nilnul.rel_.net_.Connected can be not dwelted, or dwelted but not acyclic; So here nilnul.rel_.net_.dwelted_.acyclic_.Connected inheriting nilnul.rel_.net_.dwelted_.Acyclic is not enough, lacking nilnul.rel_.net_.Connected;
	///		
	/// </summary>
	/// <remarks>
	/// a typ in higher hierarchy;
	/// </remarks>
	/// alias:
	///		side
	///		
	public interface ISynonymHier { }
}
