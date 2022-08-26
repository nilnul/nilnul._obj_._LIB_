using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// can dynamically assign a[0] a[1] to variables.
	/// can assign to dynamical list of vars.
	/// </remarks>
	/// 
	[Obsolete(".set")]

	public partial class NamingContext2
	{

		static public NamingContext2 StaticContext = new NamingContext2();




		static public void Name(_var.VarI_dynamicTyped var, string name)
		{
			StaticContext.name(var, name);
		}

		static public string Name(_var.VarI_dynamicTyped var)
		{
			return StaticContext.name(var);
		}

		private int _next;

		public int next
		{
			get { return _next; }
			set { _next = value; }
		}

		private string _reservedPrefix="_";

		public string reservedPrefix
		{
			get { return _reservedPrefix; }
			set { _reservedPrefix = value; }
		}


		private Dictionary<_var.VarI_dynamicTyped, string> _names = new Dictionary<_var.VarI_dynamicTyped, string>();

		public Dictionary<_var.VarI_dynamicTyped, string> names
		{
			get { return _names; }
			set
			{
				_names = value;

			}
		}


		public IEnumerable<string> names2
		{
			get
			{
				return _names.Values;
			}
		}


		public void name(_var.VarI_dynamicTyped var, string name)
		{
			//nilnul.NotNullX.AssertIsNotNull(var);
			if (string.IsNullOrEmpty(name))
			{
				throw new Exception();
			}

			if (_names.ContainsKey(var))
			{
				_names[var] = name;

			}
			else
			{
				_names.Add(var, name);
			}
			var names = new HashSet<string>(names2);
			if (names.Count() != _names.Count())
			{
				throw new Exception("there are conflicting names.");

			}

		}




		public string name(_var.VarI_dynamicTyped var)
		{
			if (!_names.ContainsKey(var))
			{

				name(var, $"{reservedPrefix}{next}");
				next++;
			}
			return _names[var];
		}


		



	}
	static public class NamingContextX
	{
		static public string ToTxt(this _var.VarI_dynamicTyped var) {

			return NamingContext2.StaticContext.name(var);

		}

	}
}
