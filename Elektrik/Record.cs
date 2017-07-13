/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 13.7.2017
 * Time: 23:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Elektrik
{
	/// <summary>
	/// Description of Record.
	/// </summary>
	public class Record
	{
		public DateTime Timestamp;
		public double KwhTotal;
		public double Temperature;
		
		public Record(DateTime dt, double kwh, double temp)
		{
			Timestamp = dt;
			KwhTotal = kwh;
			Temperature = temp;
		}
	}
}
