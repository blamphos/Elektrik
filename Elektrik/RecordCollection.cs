/*
 * Created by SharpDevelop.
 * User: RTM
 * Date: 13.7.2017
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Elektrik
{
	/// <summary>
	/// Description of RecordCollection.
	/// </summary>
	public sealed class RecordCollection
	{
		public string CsvFileName;
		public List<Record> Items;
		
		public RecordCollection()
		{
			Items = new List<Record>();
		}
		
		public void Add(Record record)
		{
			Items.Add(record);
		}
		
		public List<int> Years
		{
			get
			{
				return Items.Select(x => x.Timestamp.Year).Distinct().ToList();	
			}			
		}
		
		public List<Record> GetYearData(int year)
		{
			return Items.Where(x => x.Timestamp.Year == year).ToList();
		}
		
		public double GetYearDailyAverage(int year)
		{
			var days = Items.Where(x => x.Timestamp.Year == year).ToList().Count / 24;
			return YearTotalKwh(year) / days;
		}
		
		public List<Record> GetMonthData(int year, int month)
		{
			var yearData = GetYearData(year);	
			return yearData.Where(x => x.Timestamp.Month == month).ToList();
		}
		
		public List<Record> GetDayData(int year, int month, int day)
		{
			var monthlyData = GetMonthData(year, month);
			return monthlyData.Where(x => x.Timestamp.Day == day).ToList();
		}
		
		public double YearTotalKwh(int year)
		{
			return GetYearData(year).Sum(x => x.KwhTotal);
		}

		public double MonthlyTotalKwh(int year, int month)
		{						
			return GetMonthData(year, month).Sum(x => x.KwhTotal);
		}
		
		public double DailyTotalKwh(int year, int month, int day)
		{							
			return GetDayData(year, month, day).Sum(x => x.KwhTotal);
		}
		
		public double DailyAverageKwh(int year, int month, int day)
		{							
			return GetDayData(year, month, day).Average(x => x.KwhTotal);
		}
		
		public List<double> MonthlyTotalKwh(int year)
		{
			var yearData = GetYearData(year);
			
			var list = new List<double>();
			for (var i = 1; i <= 12; i++)
			{
				list.Add(yearData.Where(x => x.Timestamp.Month == i).Sum(x => x.KwhTotal));
			}
			
			return list;
		}
	}
}
