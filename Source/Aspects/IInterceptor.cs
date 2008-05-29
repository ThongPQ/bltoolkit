using System;
using System.Reflection;

namespace BLToolkit.Aspects
{
	public interface IInterceptor
	{
		void Init     (CallMethodInfo    info);
		void Intercept(InterceptCallInfo info);
	}
}
