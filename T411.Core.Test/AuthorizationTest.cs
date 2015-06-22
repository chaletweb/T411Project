using NUnit.Framework;
using System;

namespace T411.Core.Test
{
	[TestFixture ()]
	public class AuthorizationTest
	{
		[Test ()]
		public void ShouldReturnCodeErrorWithBadCredential ()
		{
			T411.Core.AuthorizationFactory authFactory = new T411.Core.AuthorizationFactory ();
			var auth = authFactory.GetAuthorizationWithCredential ("Toto", "fake");
			Assert.AreEqual(107, auth.Code); 
		}

		[Test ()]
		public void ShouldReturnNoErrorWithGoodCredential ()
		{
			T411.Core.AuthorizationFactory authFactory = new T411.Core.AuthorizationFactory ();
			var auth = authFactory.GetAuthorizationWithCredential ("youhyouh27", "NA");
			Assert.AreEqual(0, auth.Code); 
			// token = "7827821:168:3fab3eb05a3cbf1f120607cf2a5656a5"
		}
	}
}

