using System;
using NUnit.Framework;
using Shouldly;
using Moq;
using System.Linq.Expressions;

namespace Tests
{
	[TestFixture()]
	public class ShouldlyMoqTests
	{
		public interface IDog
		{
			void Bark();
		}
		
		[Test()]
		public void OnShouldHaveBeenCalled_When_Called_Should_Pass()
		{
			var mockDog = new Mock<IDog>();
			
			mockDog.Object.Bark();
			
			mockDog.ShouldHaveBeenCalled(dog => dog.Bark());
		}
		
	}
}

