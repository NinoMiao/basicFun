/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018-06-25
 * 时间: 10:05
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Clair_Library
{
	public class Convert
	{
		public string ArraryToStr<T>(T [] array,Func<T,string> convertFun,char delimiter=",")
		{
			string result="";
			int len=array.Length;
			for (int i = 0; i < len; i++) 
			{
				if (i<len-1)
					result=convertFun(array[i])+delimiter;
			}
			return result;
		}
		public T[] strToArray<T>(string str,Func<string,T> convertFun,char delimiter=",")
		{
			string [] temp=str.Split(delimiter);
			int len=temp.Length;
			T[] result=new T[len];
			for (int i = 0; i < len; i++) {
				T[i]=convertFun(temp[i]);
			}
			return result;
		}
		
 	    /// <summary>
	    /// string转datetime
	    /// </summary>
	    /// <param name="time"></param>
	    /// <param name="format">格式 如hh：mm：ss</param>
	    /// <param name="sty">0是datetime 1是 date 2是time</param>
	    /// <returns></returns>
	    public static DateTime strToDatetime(string time, string format,int sty)
	    {
	        DateTimeFormatInfo df = new DateTimeFormatInfo();
	        switch(sty)
	        {
	            case 0:
	                df.FullDateTimePattern=format;
	                break;
	            case 1:
	                df.ShortDatePattern=format;
	                break;
	            case 2:
	                df.ShortTimePattern=format;
	                break;
	        }
	        return Convert.ToDateTime(time, df); 
	    }
	}
}