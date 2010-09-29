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
		
		[Test()]
		public void OnShouldHaveBeenCalled_When_Called_Should_Fail_And_Indicate_The_Call_Wasnt_Made()
		{
			var mockDog = new Mock<IDog> ();
			
			Shouldly.Should.Throw<MockException> (() =>mockDog.Verify(dog => dog.Bark()));
		}
	}
}

