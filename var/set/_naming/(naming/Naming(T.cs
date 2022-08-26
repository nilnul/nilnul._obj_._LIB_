using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	[Obsolete()]
	public partial class Naming<T>
	{
		private Dictionary<Var<T>, string> _names = new Dictionary<Var<T>, string>();

		public Dictionary<Var<T>, string> names
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

		public void set(Var<T> var, string name)
		{
			nilnul.NotNullX.AssertIsNotNull(var);
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

		public Var<T> add(string name)
		{

			var r = new Var<T>();
			set(r, name);
			return r;


			throw new NotImplementedException();

		}




	}
}
