/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018-06-25
 * 时间: 10:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections;
namespace Clair_Library
{
	/// <summary>
	/// Description of Event.
	/// </summary>
	public class Event
	{
		    /// <summary>
		    /// 延迟执行
		    /// </summary>
		    /// <param name="action"></param>
		    /// <param name="delaySeconds"></param>
		    /// <returns></returns>
		    public static IEnumerator DelayToInvoke(Action action,float delaySeconds)
		    {
		        yield return new WaitForSeconds(delaySeconds);
		        action();
		    }
	}
}
