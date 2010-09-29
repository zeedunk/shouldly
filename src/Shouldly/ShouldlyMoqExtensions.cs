using System;
using Moq;
using System.Linq.Expressions;

namespace Shouldly
{
	public static class ShouldlyMoqExtensions 
	{
		public static void ShouldHaveBeenCalled<T> (this Mock<T> mock, Expression<Action<T>> action) where T : class
		{
			mock.Verify(action);
		}

	}
	
}
	
