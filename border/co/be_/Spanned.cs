using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be_
{
	public class Spanned<T,TBorder>
		: BeA<T,TBorder>
		where TBorder:obj.BorderI<T>
	{
		private IComparer<T> _elComp;

		public IComparer<T> elComp
		{
			get { return _elComp; }
			set { _elComp = value; }
		}

		public Spanned(IComparer<T> elEq)
		{
			_elComp = elEq;
		}
		public override bool be(in (TBorder,TBorder) obj)
		{
			return _elComp.Compare( obj.Item1.mark,obj.Item2.mark)<0;
		}
		


	


	}
}
