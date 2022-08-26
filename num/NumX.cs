using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.num
{
	public class NumX
	{
		static public decimal ToDecimal(double a){
			
			return ToDecimal_convert(a);
		
		}

		static public decimal ToDecimal_cast(double a)
		{

			return (decimal)a;

		}

		static public decimal ToDecimal_convert(double a) {
			return Convert.ToDecimal(a);
		}

		static public long IntegerPart(double x) {

			return Convert.ToInt64(Math.Floor(x));//this is round

		
		}

		static public long Floor(double x)
		{

			return Convert.ToInt64(Math.Floor(x));//this is round


		}

		static public Tuple<int, long, double> SignIntegerTail(double x) {

			Tuple<long, double> intTail;
			if (x<0)
			{
				 intTail=IntegerAndTail_forNonNeg(-x);
				return new Tuple<int, long, double>(-1, intTail.Item1, intTail.Item2);
				
			}
			 intTail = IntegerAndTail_forNonNeg(x);
			return new Tuple<int, long, double>(1, intTail.Item1, intTail.Item2);

		}

		static public Tuple<long, double> IntegerAndTail_forNonNeg(double _nonNeg) {


			var integer = IntegerPart(_nonNeg);
			var tail = _nonNeg - integer;

			return new Tuple<long, double>(integer, tail);
			
		
		}


		static public Tuple<long, double> FloorAndTail(double _nonNeg)
		{

			var floor = Floor(_nonNeg);
			var tail = _nonNeg - floor;
			tail=tail>0?tail:0;

			return new Tuple<long, double>(floor, tail);


		}

		static public long IntegerPart(decimal x)
		{
			return Convert.ToInt64( decimal.Truncate(x));



		}

	}
}
